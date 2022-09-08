using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalPortfolioWebSite.Data.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CvEnglish", "CvTurk" },
                values: new object[] { "Hello, if I need to introduce myself briefly, my name and surname is Ömer Faruk Benli.I was born on 26.02.1993 in Istanbul. My university education, Sakarya University-Labor Economy and Industrial Relations with a GPA of (3.52). After university education, I worked as an assistant real estate appraiser in the private sector for 3.5 years. In 2021 Istarted to take sofwtware trainings with the idea pf dping it in the software industry. Software It focuses on C# and Javascript as the language, Asp.Net CORE and Angular as the framework, and MsSQL and MongoDB as the database.I create using these technologies. Currently, as a Freelence project, the promotion site of an elevator manufacturer company I'm busy programming it as full-stack. Thanks for visiting my site.     ", "Merhabalar, kendimi kısaca tanıtmam gerekirse adım ve soyadım Ömer Faruk Benli, 26.02.1993 tarihinde, İstanbul'da doğdum. Üniversite eğitimimi, Sakarya Üniversitesi-Çalışma Ekonomisi ve Endüstri İlişkileri Bölümünde, 3.52 not ortalaması ile tamamladım. Üniversite eğitimi sonrası, 3.5 yıl boyunca özel sektörde gayrimenkul değerleme uzman yardımcısı olarak görev yaptım. 2021 yılında yazılım alanında kariyer yapmak düşüncesiyle yazılım eğitimleri almaya başladım. Yazılım dili olarak C# ve Javascript, Framework olarak Asp.Net CORE ve Angular, database olarak ise MsSQL ve MongoDB'ye yoğunlaşmış olup, projelerimi bu teknolojileri kullanarak oluşturmaktayım. Şuan Freelence bir proje olarak, asansör üreticisi bir firmanın tanıtım sitesinin full-stack olarak programlanması konusunda meşgul olmaktayım.Sitemi ziyaret ettiğiniz için teşekkürler.    " });

            migrationBuilder.InsertData(
                table: "Link",
                columns: new[] { "Id", "Subtitle", "Title", "Urls" },
                values: new object[,]
                {
                    { 5, "Asp.Net CORE 6 - Image Upload", "Asp.Net CORE 6", "https://github.com/omerfarukbenli/Asp.Net-CORE-6-Image-Upload" },
                    { 6, "Angular 14 - Authentication", "Angular 14", "https://github.com/omerfarukbenli/Authentication-Frontend-Backend" },
                    { 7, "Asp.Net 6 - Angular 14 Ogrenci Kayit Sistemi - Backend and Frontend", "Asp.Net CORE 6 -  Angular 14", "https://github.com/omerfarukbenli/Asp.Net-6-OgrenciKayitSistemi-Backend-Frontend" },
                    { 8, "Asp.Net 6 - Angular 14 Forum - Backend and Frontend", "Asp.Net CORE 6 -  Angular 14", "https://github.com/omerfarukbenli/Asp.Net-6-Angular-14-Blog-Backend-Frontend" }
                });

            migrationBuilder.UpdateData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 6,
                column: "ContentSummary",
                value: "HTML");

            migrationBuilder.InsertData(
                table: "Repo",
                columns: new[] { "Id", "ContentSummary", "Title", "Url" },
                values: new object[,]
                {
                    { 7, "Angular", "Bilgi Teknolojileri Kurumu Akademi", "../assets/images/s7.jpg" },
                    { 8, "C#", "Bilgi Teknolojileri Kurumu Akademi", "../assets/images/s8.jpg" },
                    { 9, "CSS", "Bilgi Teknolojileri Kurumu Akademi", "../assets/images/s9.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Link",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "About",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CvEnglish", "CvTurk" },
                values: new object[] { "Hello, if I need to introduce myself briefly, my name and surname is Ömer Faruk Benli.I was born on 26.02.1993 in Istanbul. My university education, Sakarya University-Labor Economy and Industrial Relations with a GPA of (3.52). After university education, I worked as an assistant real estate appraiser in the private sector for 3.5 years. In 2021 Istarted to take sofwtware trainings with the idea pf dping it in the software industry. Software It focuses on C# as the language, Asp.Net CORE and Angular as the framework, and MsSQL and MongoDB as the database.I create using these technologies. Currently, as a Freelence project, the promotion site of an elevator manufacturer company I'm busy programming it as full-stack. Thanks for visiting my site.     ", "Merhabalar, kendimi kısaca tanıtmam gerekirse adım ve soyadım Ömer Faruk Benli, 26.02.1993 tarihinde, İstanbul'da doğdum. Üniversite eğitimimi, Sakarya Üniversitesi-Çalışma Ekonomisi ve Endüstri İlişkileri Bölümünde, 3.52 not ortalaması ile tamamladım. Üniversite eğitimi sonrası, 3.5 yıl boyunca özel sektörde gayrimenkul değerleme uzman yardımcısı olarak görev yaptım. 2021 yılında yazılım alanında kariyer yapmak düşüncesiyle yazılım eğitimleri almaya başladım. Yazılım dili olarak C#, Framework olarak Asp.Net CORE ve Angular, database olarak ise MsSQL ve MongoDB'ye yoğunlaşmış olup, projelerimi bu teknolojileri kullanarak oluşturmaktayım. Şuan Freelence bir proje olarak, asansör üreticisi bir firmanın tanıtım sitesinin full-stack olarak programlanması konusunda meşgul olmaktayım.Sitemi ziyaret ettiğiniz için teşekkürler.    " });

            migrationBuilder.UpdateData(
                table: "Repo",
                keyColumn: "Id",
                keyValue: 6,
                column: "ContentSummary",
                value: "Asp.Net CORE 6-Angular 14");
        }
    }
}
