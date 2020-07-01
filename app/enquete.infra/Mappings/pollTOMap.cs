using System.Data.Entity.ModelConfiguration;
using enquete.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace enquete.infra.Mappings
{
    public class pollTOMap : EntityTypeConfiguration<poll>
    {
        public pollTOMap()
        {
            ToTable("poll");
            HasKey(x => x.poll_id);
            Property(x => x.poll_description).HasMaxLength(200).IsRequired();
       
           
        }
    }
}
