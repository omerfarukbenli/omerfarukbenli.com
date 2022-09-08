using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalPortfolioWebSite.Data.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvTurk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CvEnglish = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Linkedln = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Github = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Urls = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "CvEnglish", "CvTurk" },
                values: new object[] { 1, "Hello, if I need to introduce myself briefly, my name and surname is Ömer Faruk Benli.I was born on 26.02.1993 in Istanbul. My university education, Sakarya University-Labor Economy and Industrial Relations with a GPA of (3.52). After university education, I worked as an assistant real estate appraiser in the private sector for 3.5 years. In 2021 Istarted to take sofwtware trainings with the idea pf dping it in the software industry. Software It focuses on C# as the language, Asp.Net CORE and Angular as the framework, and MsSQL and MongoDB as the database.I create using these technologies. Currently, as a Freelence project, the promotion site of an elevator manufacturer company I'm busy programming it as full-stack. Thanks for visiting my site.     ", "Merhabalar, kendimi kısaca tanıtmam gerekirse adım ve soyadım Ömer Faruk Benli, 26.02.1993 tarihinde, İstanbul'da doğdum. Üniversite eğitimimi, Sakarya Üniversitesi-Çalışma Ekonomisi ve Endüstri İlişkileri Bölümünde, 3.52 not ortalaması ile tamamladım. Üniversite eğitimi sonrası, 3.5 yıl boyunca özel sektörde gayrimenkul değerleme uzman yardımcısı olarak görev yaptım. 2021 yılında yazılım alanında kariyer yapmak düşüncesiyle yazılım eğitimleri almaya başladım. Yazılım dili olarak C#, Framework olarak Asp.Net CORE ve Angular, database olarak ise MsSQL ve MongoDB'ye yoğunlaşmış olup, projelerimi bu teknolojileri kullanarak oluşturmaktayım. Şuan Freelence bir proje olarak, asansör üreticisi bir firmanın tanıtım sitesinin full-stack olarak programlanması konusunda meşgul olmaktayım.Sitemi ziyaret ettiğiniz için teşekkürler.    " });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Address", "Email", "FullName", "Phone" },
                values: new object[] { 1, "İstanbul/Ümraniye", "omerfarukbenli@hotmail.com", "Ömer Faruk Benli", "0(544) 205 98 45" });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "Id", "Github", "Linkedln", "Youtube" },
                values: new object[] { 1, "https://github.com/omerfarukbenli", "https://www.linkedin.com/in/%C3%B6mer-faruk-benli-5a6719241/", "https://www.youtube.com/channel/UCnlOSRG2OWoXfwbhpMdzTQw" });

            migrationBuilder.InsertData(
                table: "Link",
                columns: new[] { "Id", "Subtitle", "Title", "Urls" },
                values: new object[,]
                {
                    { 1, "Asp.Net CORE 6 - Crud", "Asp.Net CORE 6", "https://github.com/omerfarukbenli/Asp.Net-6-Crud-Many-to-Many" },
                    { 2, "Asp.Net CORE 6 - Authantication", "Asp.Net CORE 6", "https://github.com/omerfarukbenli/Asp.Net-6-Auth" },
                    { 3, "Angular 14 - Crud", "Angular 14", "https://github.com/omerfarukbenli/Angular-Crud-islemleri" },
                    { 4, "MongoDB - Crud", "Asp.Net CORE 6", "https://github.com/omerfarukbenli/MongoDB-Asp.Net-6-WebApi-Crud" }
                });

            migrationBuilder.InsertData(
                table: "Repo",
                columns: new[] { "Id", "ContentSummary", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "C# ile Algoritma 101", "Turkcell Geleceği Yazanlar", "../assets/images/s1.jpg" },
                    { 2, "#C ile Algoritma 201", "Turkcell Geleceği Yazanlar", "../assets/images/s2.jpg" },
                    { 3, "Web Programlama 101", "Turkcell Geleceği Yazanlar", "../assets/images/s3.jpg" },
                    { 4, "Web Programlama 201", "Turkcell Geleceği Yazanlar", "../assets/images/s4.jpg" },
                    { 5, "Web Programlama 301", "Turkcell Geleceği Yazanlar", "../assets/images/s5.jpg" },
                    { 6, "Asp.Net CORE 6-Angular 14", "Bilgi Teknolojileri Kurumu Akademi", "../assets/images/s6.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Home");

            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "Repo");
        }
    }
}
