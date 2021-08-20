using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DataModel
{
    class CreateDB : CreateDatabaseIfNotExists<ContextDB>
    {
        protected override void Seed(ContextDB context)
        {
        }
    }
}
