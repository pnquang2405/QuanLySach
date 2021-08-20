using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySach.DataModel
{
    public class TheLoai
    {
        public TheLoai()
        {
            Sach = new HashSet<Sach>();
        }
        [Key]
        public int MaTL { get; set; }
        [Required]
        public string TenTL { get; set; }

        public virtual ICollection<Sach> Sach { get; set; }
    }
}