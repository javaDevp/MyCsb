using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touha.Tools.Csb.Dal
{
    public class DalTrans
    {
        private static DataSet dsTrans = new DataSet();

        static DalTrans()
        {
            dsTrans.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "Trans.xml");
        }

        public DataTable GetTransInfo()
        {
            return dsTrans.Tables[0];
        }

        public DataTable GetTransFields()
        {
            return dsTrans.Tables[1];
        }

        public bool HasChanged()
        {
            return dsTrans.GetChanges() != null;
        }

        public void SaveChanges()
        {
            dsTrans.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "Trans.xml");
        }

        public DataTable GetFiledTypes()
        {
            DataTable dtFieldType = new DataTable();
            dtFieldType.Columns.Add("ID");
            dtFieldType.Columns.Add("Name");
            foreach(string enumName in Enum.GetNames(typeof(FieldType)))
            {
                DataRow drFiledType = dtFieldType.NewRow();
                drFiledType["ID"] = (int)Enum.Parse(typeof(FieldType), enumName);
                drFiledType["Name"] = enumName;
                dtFieldType.Rows.Add(drFiledType);
            }
            return dtFieldType;
        }
    }

    public enum FieldType
    {
        Int = 0,
        Decimal = 1,
        String = 2,
        DataTime = 3
    }
}
