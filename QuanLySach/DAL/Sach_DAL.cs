using QuanLySach.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAL
{
    class Sach_DAL
    {

        private ContextDB db;
        private static Sach_DAL _Instance;
        public static Sach_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Sach_DAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public Sach_DAL()
        {
            db = new ContextDB();
        }

        public void AddSach(Sach sach)
        {
            db.Saches.Add(sach);
        }

        public void Sync()
        {
            db.SaveChanges();
        }
    }
}
