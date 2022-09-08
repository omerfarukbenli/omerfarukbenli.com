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
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CvTurk).IsRequired();
            builder.Property(x => x.CvEnglish).IsRequired();
            builder.HasData(
                    new About
                    {
                        Id = 1,
                        CvTurk = "Merhabalar, kendimi kısaca tanıtmam gerekirse adım ve soyadım Ömer Faruk Benli, 26.02.1993 tarihinde, İstanbul'da doğdum. Üniversite eğitimimi, Sakarya Üniversitesi-Çalışma Ekonomisi ve Endüstri İlişkileri Bölümünde, 3.52 not ortalaması ile tamamladım. Üniversite eğitimi sonrası, 3.5 yıl boyunca özel sektörde gayrimenkul değerleme uzman yardımcısı olarak görev yaptım. 2021 yılında yazılım alanında kariyer yapmak düşüncesiyle yazılım eğitimleri almaya başladım. Yazılım dili olarak C# ve JavaScript, Framework olarak Asp.Net CORE ve Angular, database olarak ise MsSQL ve MongoDB'ye yoğunlaşmış olup, projelerimi bu teknolojileri kullanarak oluşturmaktayım. Şuan Freelence bir proje olarak, asansör üreticisi bir firmanın tanıtım sitesinin full-stack olarak programlanması konusunda meşgul olmaktayım.Sitemi ziyaret ettiğiniz için teşekkürler.    ",
                        CvEnglish = "Hello, if I need to introduce myself briefly, my name and surname is Ömer Faruk Benli.I was born on 26.02.1993 in Istanbul. My university education, Sakarya University-Labor Economy and Industrial Relations with a GPA of (3.52). After university education, I worked as an assistant real estate appraiser in the private sector for 3.5 years. In 2021, I started to taking software trainings with the thought of making a career in software industry. Software It focuses on C# and JavaScript as the language, Asp.Net CORE and Angular as the framework and MsSQL and MongoDB as the database. I develop my projects with these technologies.I am currently developing promotion site of an elevator manufacturer company as a full-stack an freelence."
                    }
                    );
        }
    }
}
