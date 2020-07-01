using enquete.Domain;
using System.Data.Entity.ModelConfiguration;

namespace enquete.infra.Mappings
{
    public class optionsTOMap : EntityTypeConfiguration<options>
    {
        public optionsTOMap()
        {

          
            ToTable("option");
            HasKey(x => x.option_id);
            Property(x => x.option_description).HasMaxLength(200).IsRequired();
            HasRequired(x => x.poll);  
            
                          
        }
    }
}
