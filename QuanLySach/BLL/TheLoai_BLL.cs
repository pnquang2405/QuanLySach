using QuanLySach.DAL;
using QuanLySach.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.BLL
{
    class TheLoai_BLL
    {
        private static TheLoai_BLL _Instance;
        public static TheLoai_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TheLoai_BLL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        public List<TheLoai> getListTL()
        {
            return TheLoai_DAL.Instance.getListTL();
        }

        public TheLoai getTLByID(int id)
        {
            return TheLoai_DAL.Instance.getTLByID(id);
        }
    }
}
