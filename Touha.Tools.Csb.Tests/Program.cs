using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Touha.Tools.Csb.Dal;

namespace Touha.Tools.Csb.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            DataTable dtTransInfo = new DataTable();
            dtTransInfo.Columns.Add("TransID");
            dtTransInfo.Columns.Add("TransName");
            dtTransInfo.Columns.Add("TransDescription");
            DataRow drTransInfo = dtTransInfo.NewRow();
            drTransInfo["TransID"] = 1;
            drTransInfo["TransName"] = "T_1";
            drTransInfo["TransDescription"] = "T_1";
            dtTransInfo.Rows.Add(drTransInfo);

            DataTable dtTransFields = new DataTable();
            dtTransFields.Columns.Add("TransID");
            dtTransFields.Columns.Add("FieldName");
            dtTransFields.Columns.Add("FieldLength");
            dtTransFields.Columns.Add("FieldType");
            dtTransFields.Columns.Add("FieldIsRequired");
            dtTransFields.Columns.Add("FieldDescription");
            DataRow drTransFields = dtTransFields.NewRow();
            drTransFields["TransID"] = 1;
            drTransFields["FieldName"] = "Field";
            drTransFields["FieldLength"] = 8;
            drTransFields["FieldType"] = 0;
            drTransFields["FieldIsRequired"] = true;
            drTransFields["FieldDescription"] = "Desc";
            dtTransFields.Rows.Add(drTransFields);

            ds.Tables.Add(dtTransInfo);
            ds.Tables.Add(dtTransFields);

            ds.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "Trans.xml");

            DalTrans dal = new DalTrans();

        }
    }
}
