﻿using System;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace FooFoo
{
    public partial class Download
    {
        public class DataTableToCsvMapper
        {
            public MemoryStream Map(DataTable dataTable)
            {
                MemoryStream ReturnStream = new MemoryStream();                
                StreamWriter sw = new StreamWriter(ReturnStream);
                WriteColumnsNames(dataTable, sw);
                WriteRows(dataTable, sw);
                sw.Flush();
                sw.Close();
                return ReturnStream;
            }

            private static void WriteRows(DataTable dt, StreamWriter sw)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    WriteRow(dt, dr, sw);
                    sw.WriteLine();
                }
            }

            private static void WriteRow(DataTable dt, DataRow dr, StreamWriter sw)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    WriteCell(dr, i, sw);
                    WriteSeparatorIfRequired(dt, i, sw);
                }
            }

            private static void WriteSeparatorIfRequired(DataTable dt, int index, StreamWriter streamWritter)
            {
                if (index < dt.Columns.Count - 1)
                {
                    streamWritter.Write(",");
                }
            }

            private static void WriteCell(DataRow dataRow, int index, StreamWriter sw)
            {
                if (!Convert.IsDBNull(dataRow[index]))
                {
                    string str = String.Format("\"{0:c}\"", dataRow[index].ToString()).Replace("\r\n", " ");
                    sw.Write(str);
                }
                else
                {
                    sw.Write("");
                }
            }

            private static void WriteColumnsNames(DataTable dt, StreamWriter sw)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i]);
                    if (i < dt.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();
            }

            
        }
    }

    public class TableReader
    {
        public DataTable GetDataTable()
        {
            string strConn = ConfigurationManager.ConnectionStrings["FooFooConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [FooFoo] ORDER BY id ASC", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "FooFoo");
            DataTable dt = ds.Tables["FooFoo"];
            return dt;
        }
    }
}