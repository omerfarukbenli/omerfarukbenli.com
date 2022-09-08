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
    public class LinkConfiguration : IEntityTypeConfiguration<Link>
    {
        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Subtitle).IsRequired();
            builder.Property(x => x.Urls).IsRequired();
            builder.HasData(
            new Link
            {
                Id = 1,
                Subtitle = "Asp.Net CORE 6 - Crud",
                Title = "Asp.Net CORE 6",
                Urls = "https://github.com/omerfarukbenli/Asp.Net-6-Crud-Many-to-Many"
            },
                new Link
                {
                    Id = 2,
                    Subtitle = "Asp.Net CORE 6 - Authantication",
                    Title = "Asp.Net CORE 6",
                    Urls = "https://github.com/omerfarukbenli/Asp.Net-6-Auth"
                },
                  new Link
                  {
                      Id = 3,
                      Subtitle = "Angular 14 - Crud",
                      Title = "Angular 14",
                      Urls = "https://github.com/omerfarukbenli/Angular-Crud-islemleri"
                  },
                    new Link
                    {
                        Id = 4,
                        Subtitle = "MongoDB - Crud",
                        Title = "Asp.Net CORE 6",
                        Urls = "https://github.com/omerfarukbenli/MongoDB-Asp.Net-6-WebApi-Crud"
                    },
                    new Link
                    {
                        Id = 5,
                        Subtitle = "Asp.Net CORE 6 - Image Upload",
                        Title = "Asp.Net CORE 6",
                        Urls = "https://github.com/omerfarukbenli/Asp.Net-CORE-6-Image-Upload"
                    },
                    new Link
                    {
                        Id = 6,
                        Subtitle = "Angular 14 - Authentication",
                        Title = "Angular 14",
                        Urls = "https://github.com/omerfarukbenli/Authentication-Frontend-Backend"
                    },
                    new Link
                    {
                        Id = 7,
                        Subtitle = "Asp.Net 6 - Angular 14 Ogrenci Kayit Sistemi - Backend and Frontend",
                        Title = "Asp.Net CORE 6 -  Angular 14",
                        Urls = "https://github.com/omerfarukbenli/Asp.Net-6-OgrenciKayitSistemi-Backend-Frontend"
                    },
                    new Link
                    {
                        Id = 8,
                        Subtitle = "Asp.Net 6 - Angular 14 Forum - Backend and Frontend",
                        Title = "Asp.Net CORE 6 -  Angular 14",
                        Urls = "https://github.com/omerfarukbenli/Asp.Net-6-Angular-14-Blog-Backend-Frontend"
                    }
                    );

        }
    }
    
}
