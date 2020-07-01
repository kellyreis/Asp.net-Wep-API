using enquete.Domain;
using System.Data.Entity;
using enquete.infra.Mappings;
namespace enquete.infra.DataContexts
{
    public class enqueteDataContext : DbContext
    {
        public enqueteDataContext() : base("stringConnection")
        {
            //   Database.SetInitializer<enqueteDataContext>(new enqueteDataContextInitializer());

            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
       

        }

        public DbSet<poll> poll { get; set; }
        public DbSet<options> option { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new optionsTOMap());
            modelBuilder.Configurations.Add(new pollTOMap());
      
            base.OnModelCreating(modelBuilder);
        }
    }


    public class enqueteDataContextInitializer : DropCreateDatabaseIfModelChanges<enqueteDataContext>
    {
        protected override void Seed(enqueteDataContext context)
        {

            context.poll.Add(new poll { poll_id = 1, poll_description = "testeasjdoad", views = 50 });
            context.poll.Add(new poll { poll_id = 2, poll_description = "Nova questão teste", views = 50 });
            context.SaveChanges();

            context.option.Add(new options { option_id = 1, poll_id = 1, option_description = "1 qiestão", qty = 50 });
            context.option.Add(new options { option_id = 2, poll_id = 1, option_description = "2 qiestão", qty = 50 });
            context.option.Add(new options { option_id = 3, poll_id = 2, option_description = "1 questao total", qty = 50 });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
