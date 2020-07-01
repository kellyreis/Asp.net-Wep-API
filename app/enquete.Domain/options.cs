using System;

namespace enquete.Domain
{
    public class options
    {
        public int option_id { get; set; }
        public string option_description { get; set; }
        public int qty { get; set; }        
        public int poll_id { get; set; }
        public virtual poll poll { get; set; }

        public override string ToString()
        {
            return this.option_description;
        }
    }
}
