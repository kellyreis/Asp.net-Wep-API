using enquete.Domain;
using enquete.infra.DataContexts;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Http.Cors;

namespace api.Controllers
{
  
  //  [EnableCors(origins:"*",headers:"*", methods:"*")]
    [RoutePrefix("")]

    public class pollController : ApiController
    {

        private enqueteDataContext db = new enqueteDataContext();

        [AcceptVerbs("GET")]
        [Route("GetAllPoll")]
        public HttpResponseMessage GetAllPoll()
        {
            var result = db.poll.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        

        [AcceptVerbs("GET")]
        [Route("GetAllOption")]
        public HttpResponseMessage GetAllOption()
        {
            var result = db.option.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);

        }

        [AcceptVerbs("GET")]
        [Route("poll/{id}")]
        public HttpResponseMessage getPolByOptions(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            var result = db.option.Include(x => x.poll).Where(x => x.poll_id == id).GroupBy(x => new { x.poll_id, x.poll.poll_description }).Select(group => new
            {
                group.Key,
                options = group.Select(mensagem => new
                {
                    option_id = mensagem.option_id,
                    option_description = mensagem.option_description
                  
                })

            }).ToList();


            if (result != null)
                return Request.CreateResponse(HttpStatusCode.OK, result);

            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        
        [HttpPost]
        [Route("poll")]
        public HttpResponseMessage PostPoll(JObject EmpData)
        {
            if (EmpData == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            try
            {
                dynamic json = EmpData;
                poll new_pol = new poll();
                new_pol.poll_description = json.poll_description;
                db.poll.Add(new_pol);
                db.SaveChanges();

                List<options> listStatus = new List<options>();
                foreach (var item in json.options)
                {
                    options statusNew = new options();
                    statusNew.option_description = item;
                    statusNew.poll_id = new_pol.poll_id;
                    listStatus.Add(statusNew);
                }
                db.option.AddRange(listStatus);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { poll_id = new_pol.poll_id });
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao incluir");
            }
        }


        [AcceptVerbs("GET")]
        [Route("poll/{id}/stats")]
        public HttpResponseMessage PutPolView(int id)
        {
            var update = db.poll.Find(id);
            update.views += 1;
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
               
           var result = db.option.Include(x => x.poll).Where(x => x.poll_id == id).GroupBy(x => new { x.poll.views }).Select(group => new
            {
                group.Key.views,
                votes = group.Select(mensagem => new
                {
                    option_id = mensagem.option_id,
                    qty = mensagem.qty

                })

            }).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        
        [HttpPost]
        [Route("poll/{id}/vote")]
        public HttpResponseMessage PutVoteOption(int id, options option)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "O id informado na URL deve ser maior que zero.");

            if (id != option.option_id)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "O id informado na URL deve ser igual ao id informado no corpo da requisição.");
            try
            {
                if (db.option.Count(e => e.option_id == id) == 0)
                    return Request.CreateResponse(HttpStatusCode.NotFound);

                var result = db.option.Find(option.option_id);
                result.qty += 1;
                db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return Request.CreateResponse(HttpStatusCode.OK, new { total_votes = result.qty });
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

    }
}
