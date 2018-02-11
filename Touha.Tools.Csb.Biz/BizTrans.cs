using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Touha.Tools.Csb.Dal;

namespace Touha.Tools.Csb.Biz
{
    public class BizTrans
    {
        private DalTrans dal = new DalTrans();

        public DataTable GetTransInfo()
        {
            return dal.GetTransInfo();
        }

        public DataTable GetTransFields()
        {
            return dal.GetTransFields();
        }

        public bool HasChanged()
        {
            return dal.HasChanged();
        }

        public void SaveChanges()
        {
            dal.SaveChanges();
        }

        public DataTable GetFiledTypes()
        {
            return dal.GetFiledTypes();
        }
    }
}
