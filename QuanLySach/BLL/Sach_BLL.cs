using QuanLySach.DAL;
using QuanLySach.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.BLL
{
    class Sach_BLL
    {
        private static Sach_BLL _Instance;
        public static Sach_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Sach_BLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        public void Add(Sach sach)
        {
            Sach_DAL.Instance.AddSach(sach);
            Sach_DAL.Instance.Sync();
        }
    }
}
