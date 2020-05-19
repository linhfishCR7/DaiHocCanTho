using DaiHocCanTho.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DaiHocCanTho.Context
{
    public class KhoaContext : DbContext
    {
        public DbSet<Khoa> Khoas { get; set; }
    }
}