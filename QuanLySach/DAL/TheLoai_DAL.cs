using QuanLySach.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ContextDB = QuanLySach.DataModel.ContextDB;

namespace QuanLySach.DAL
{
    class TheLoai_DAL
    {
        private ContextDB db;
        private static TheLoai_DAL _Instance;
        public static TheLoai_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TheLoai_DAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public TheLoai_DAL()
        {
            db = new ContextDB();
        }

        public List<TheLoai> getListTL()
        {
            List<TheLoai> list = (from sv in db.theLoais select sv).ToList();
            return list;
        }

        public TheLoai getTLByID(int id)
        {
            TheLoai tl = db.theLoais.FirstOrDefault(p => p.MaTL == id);
            return tl;
        }
    }
}
