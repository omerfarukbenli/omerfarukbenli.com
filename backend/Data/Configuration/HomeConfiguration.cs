using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Configuration
{
    public class HomeConfiguration : IEntityTypeConfiguration<Home>
    {
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Linkedln).IsRequired();
            builder.Property(x => x.Github).IsRequired();
            builder.Property(x => x.Youtube).IsRequired();
            builder.HasData(
                    new Home
                    {
                        Id = 1,
                        Linkedln = "https://www.linkedin.com/in/%C3%B6mer-faruk-benli-5a6719241/",
                        Github = "https://github.com/omerfarukbenli",
                        Youtube = "https://www.youtube.com/channel/UCnlOSRG2OWoXfwbhpMdzTQw"
                    }
                    );
        }
    }
}
