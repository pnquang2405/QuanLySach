using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DataModel
{
    public class ContextDB:DbContext
    {
        public ContextDB():base("QuanLySach")
        {

        }

        public DbSet<Sach> Saches { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<Muon> muons { get; set; }
        public DbSet<TheLoai> theLoais { get; set; }

    }
}
