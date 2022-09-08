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
    public class RepoConfiguration : IEntityTypeConfiguration<Repo>
    {
        public void Configure(EntityTypeBuilder<Repo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.ContentSummary).IsRequired();
            builder.HasData(
                    new Repo
                    {
                        Id = 1,
                        Title = "Turkcell Geleceği Yazanlar",
                        ContentSummary = "C# ile Algoritma 101",
                        Url = "../assets/images/s1.jpg"
                    },
                    new Repo
                    {
                        Id = 2,
                        Title = "Turkcell Geleceği Yazanlar",
                        ContentSummary = "#C ile Algoritma 201",
                        Url = "../assets/images/s2.jpg"
                    },
                    new Repo
                    {
                        Id = 3,
                        Title = "Turkcell Geleceği Yazanlar",
                        ContentSummary = "Web Programlama 101",
                        Url = "../assets/images/s3.jpg"
                    },
                    new Repo
                    {
                        Id = 4,
                        Title = "Turkcell Geleceği Yazanlar",
                        ContentSummary = "Web Programlama 201",
                        Url = "../assets/images/s4.jpg"
                    },
                    new Repo
                    {
                        Id = 5,
                        Title = "Turkcell Geleceği Yazanlar",
                        ContentSummary = "Web Programlama 301",
                        Url = "../assets/images/s5.jpg"
                    },
                    new Repo
                    {
                        Id = 6,
                        Title = "Bilgi Teknolojileri Kurumu Akademi",
                        ContentSummary = "HTML 5 ile Web Geliştirme",
                        Url = "../assets/images/s6.jpg"
                    },
                    new Repo
                    {
                        Id = 7,
                        Title = "Bilgi Teknolojileri Kurumu Akademi",
                        ContentSummary = "Angular ile Web Programcılığı",
                        Url = "../assets/images/s7.jpg"
                    },
                    new Repo
                    {
                        Id = 8,
                        Title = "Bilgi Teknolojileri Kurumu Akademi",
                        ContentSummary = "C#",
                        Url = "../assets/images/s8.jpg"
                    },
                    new Repo
                    {
                        Id = 9,
                        Title = "Bilgi Teknolojileri Kurumu Akademi",
                        ContentSummary = "CSS Temelleri",
                        Url = "../assets/images/s9.jpg"
                    }
                    );
        }
    }
}
