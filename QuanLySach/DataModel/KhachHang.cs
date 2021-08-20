using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DataModel
{
    public class KhachHang
    {
        [Key]
        public int IDKH { get; set; }
        public string TenKH { get; set; }
        public virtual ICollection<Muon> Muons { get; set; }
    }

}
