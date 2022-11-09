using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    internal class DataProvider
    {
        private static DataProvider instance;

        private string strConnectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            try
            {
                DataTable data = new DataTable();

                using (SqlConnection conn = new SqlConnection(strConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);


                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');

                        int i = 0;

                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);


                    da.Fill(data);

                    conn.Close();

                }

                return data;
            }
            catch
            {
                return null;
            }

            

        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {


            int data = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(strConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);


                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');

                        int i = 0;

                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = cmd.ExecuteNonQuery();
                    Console.WriteLine(data);
                    conn.Close();

                }

                return data;
            }
            catch
            {
                return 0;
            }

           

        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {

            object data = 0;

            using (SqlConnection conn = new SqlConnection(strConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);


                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                conn.Close();

            }

            return data;
        }
    }
}
