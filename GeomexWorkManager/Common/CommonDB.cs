using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomexWorkManager.Common
{
    class CDB
    {
        private string m_connString = "";

        public  CDB(string ip,string port,string db,string id,string pw)
        {
            m_connString = string.Format("Server={0};Port{1};UserId={2};Password={3};Database={4}",ip,port,id,pw,db);
        }

        public static NpgsqlConnection CreateConn()
        {
            return new NpgsqlConnection(CV.DBConn);
        }
        //조회한 결과값 datatable로 반환
        public static DataTable ExcuteDataTable(string _sql,params object[] args)
        {
            NpgsqlConnection conn = CreateConn();
            NpgsqlCommand cmd = null;
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = _sql;
                if (args != null && args.Length > 0)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(i.ToString(), args[i]);
                    }
                }
                DataTable dt = new DataTable();
                using (NpgsqlDataAdapter ad = new NpgsqlDataAdapter(cmd))
                {
                    ad.Fill(dt);
                }
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                cmd?.Dispose();
                conn.Close();
            }
            return null;
        }

        // 쿼리날리기
        public static bool ExcuteQry(string _sql, params object[] args)
        {
            bool result = false;
            NpgsqlConnection conn = CreateConn();
            NpgsqlCommand cmd = null;
            try
            {
                conn.Open();
                cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = _sql;
                if (args != null && args.Length > 0)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(i.ToString(), args[i]);
                    }
                }

                cmd.ExecuteNonQuery();
                result = true;
      
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result = false;
            }
            finally
            {
                cmd?.Dispose();
                conn.Close();
            }
            
            return result;
        }

        //DB 접속 테스트
        public static bool TestDatabase(string DBConnStr )
        {
            bool flag = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(DBConnStr))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("DB 접속 성공!");
                    conn.Close();
                    conn.Dispose();
                    flag = true;
                }
                catch (Exception E)
                {
                    Console.WriteLine("접속 실패.. \r\n" + E.Message);
                    flag = false;
                }
               return flag;
            }
        }
    }
}
