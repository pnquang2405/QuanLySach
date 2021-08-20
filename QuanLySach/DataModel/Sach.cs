using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DataModel
{
    public class Sach
    {
        [Key]
        public int IDSach { get; set; }
        [Required]
        public string TenSach { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        public virtual ICollection<Muon> Muons { get; set; }
    }
}
