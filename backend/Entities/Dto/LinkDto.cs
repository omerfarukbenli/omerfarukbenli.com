using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Entities.Concrete.Dto
{
    public class LinkDto
    {
        public int Id { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; }
        public string Urls { get; set; }
    }
}