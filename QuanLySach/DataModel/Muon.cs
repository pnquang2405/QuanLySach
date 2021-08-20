using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySach.DataModel
{
    public class Muon
    {
        [Key]
        [Column(Order = 1)]
        public int IDSach { get; set; }
        [Key]
        [Column(Order = 2)]
        public int IDKH { get; set; }
        public virtual Sach Sach { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}