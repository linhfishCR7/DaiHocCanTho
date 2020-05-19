using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaiHocCanTho.Models
{
    public class Khoa
    {
        public int Id { get; set; }
        public string KhoaImages { get; set; }
        public string KhoaName { get; set; }
        public string NoiDung { get; set; }
        public string Link { get; set; }

        public DateTime Published { get; set; }
    }
}