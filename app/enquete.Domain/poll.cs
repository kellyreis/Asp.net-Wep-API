using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace enquete.Domain
{
    public class poll
    {
        public int poll_id { get; set; }
        public string poll_description { get; set; }
        public int views { get; set; }    

     

        public override string ToString()
        {
            return this.poll_description;
        }
    }
}
