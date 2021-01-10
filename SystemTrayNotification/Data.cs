using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTrayNotification
{
    class Data
    {
        DataTable table;

        public DataTable Table { get => table; set => table = value; }

        public Data()
        {
            Table = new DataTable("MyTable");
            CreateTable();
        }
        public void CreateTable()
        {
            Table.Columns.Add(new DataColumn("Id", Type.GetType("System.String")));
            Table.Columns.Add(new DataColumn("Length", Type.GetType("System.Int32")));
            Table.Columns.Add(new DataColumn("Words", Type.GetType("System.String")));

        }
        public void AddRow(LineWord lineWord)
        {

            DataRow newRow = Table.NewRow();
            newRow["Id"] = Guid.NewGuid().ToString();
            newRow["Length"] = lineWord.Length;
            newRow["Words"] = GeneralMethods.GetWords(lineWord.Words);
            Table.Rows.Add(newRow);
        }
        public string GetStringToTextArea()
        {

            string result="";
            
            IEnumerable<DataRow> query = 
                        from table in this.Table.AsEnumerable()
                        orderby table.Field<int>("Length") descending
                        select table;

            IEnumerable<DataRow> tableArray = query.ToArray();

            foreach (DataRow element in tableArray)
            {
                result += element[2].ToString() + Environment.NewLine;
            }
            return result;
        }
        public void ResetValues()
        {
            table.Rows.Clear();
        }

    }
}
