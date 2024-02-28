using Database;
using Database.Interface;
using Database.Model;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Database
{
    public class ServerManager
    {
        private static SqlConnection SqlConn;

        private static string GetStringConnection(IConnectionRequest Request)
        {
            Type type = Request.GetType();
            PropertyInfo[] properties = type.GetProperties();

            string strConnection = "";

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(Request, null) is null) continue;

                string propName = property.Name;
                if (propName.Contains("__")) propName = propName.Replace("__", " ");

                var propValue = property.GetValue(Request, null);

                if (propValue.GetType() == typeof(int) && int.Parse(propValue.ToString()) == 0) continue;
                if (propValue.GetType() == typeof(bool) && bool.Parse(propValue.ToString()) == false) continue;

                strConnection += propName + "=" + propValue + ";";
            }
            return strConnection;
        }

        public static IConnectionResponse CheckServerConnection(IConnectionRequest Request)
        {
            if (string.IsNullOrEmpty(Request.Server) && string.IsNullOrEmpty(Request.Data__Source)) return new ConnectionResponse()
            {
                DateTime = DateTime.Now,
                Message = "Invalid Connection String\nEnter Server Address"
            };

            string strConn = GetStringConnection(Request);
            if (string.IsNullOrEmpty(strConn)) return new ConnectionResponse()
            {
                DateTime = DateTime.Now,
                Message = "Invalid Connection String"
            };

            try
            {
                SqlConn = new SqlConnection(strConn);
                SqlConn.Open();
                return new ConnectionResponse()
                {
                    DateTime = DateTime.Now,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                return new ConnectionResponse()
                {
                    DateTime = DateTime.Now,
                    Message = ex.Message
                };
            }
            finally
            {
                SqlConn.Close();
            }
        }

        public static IConnectionResponse GetDatabaseList(IConnectionRequest Request)
        {
            var serverStatus = CheckServerConnection(Request);
            if (!serverStatus.Success) return serverStatus;

            try
            {
                SqlConn = new SqlConnection(GetStringConnection(Request));
                SqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandText = "SELECT [name] FROM master.sys.databases WHERE [name] NOT IN ('master', 'model', 'msdb', 'tempdb') FOR JSON AUTO",
                    Connection = SqlConn
                };

                var retVal = sqlCommand.ExecuteScalar();
                if (retVal is null)
                {
                    return new ConnectionResponse()
                    {
                        DateTime = DateTime.Now,
                        Success = true,
                        Data = JsonSerializer.Deserialize<DatabaseModel[]>("[]")
                    };
                }
                var listNm = JsonSerializer.Deserialize<DatabaseModel[]>(retVal.ToString());
                return new ConnectionResponse()
                {
                    DateTime = DateTime.Now,
                    Success = true,
                    Data = listNm
                };
            }
            catch (Exception ex)
            {
                return new ConnectionResponse()
                {
                    DateTime = DateTime.Now,
                    Message = ex.Message
                };
            }
            finally
            {
                SqlConn.Close();
            }

        }

        public static IConnectionResponse CreateDatabase(IConnectionRequest Request)
        {

            if (string.IsNullOrEmpty(Request.Database) && string.IsNullOrEmpty(Request.Initial__Catalog)) return new ConnectionResponse()
            {
                DateTime = DateTime.Now,
                Message = "Invalid Connection String\nEnter Database"
            };

            string DataName = !string.IsNullOrEmpty(Request.Database) ? Request.Database : Request.Initial__Catalog;
            Request.Database = null;
            Request.Initial__Catalog = null;

            var databaseList = GetDatabaseList(Request);
            if (!databaseList.Success) return databaseList;

            var listNm = (DatabaseModel[])databaseList.Data;
            if (listNm.Count(n => n.name == DataName) > 0) return new ConnectionResponse()
            {
                DateTime = DateTime.Now,
                Success = true,
                Message = "Database already exist",
                Data = listNm
            };

            try
            {

                SqlConn = new SqlConnection(GetStringConnection(Request));
                SqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandText = "CREATE DATABASE " + DataName,
                    Connection = SqlConn
                };

                sqlCommand.ExecuteNonQuery();

                return new ConnectionResponse()
                {
                    DateTime = DateTime.Now,
                    Success = true,
                    Message = "Database created"
                };
            }
            catch (Exception ex)
            {
                return new ConnectionResponse()
                {
                    DateTime = DateTime.Now,
                    Message = ex.Message
                };
            }
            finally
            {
                SqlConn.Close();
            }
        }

        public static IConnectionResponse GetTableList(IConnectionRequest Request)
        {
            var serverStatus = CheckServerConnection(Request);
            if (!serverStatus.Success) return serverStatus;

            try
            {
                SqlConn = new SqlConnection(GetStringConnection(Request));
                SqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand()
                {
                    CommandText = "SELECT TABLE_NAME as 'name' FROM [" + Request.Database + "].INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' FOR JSON AUTO",
                    Connection = SqlConn
                };

                var retVal = sqlCommand.ExecuteScalar();
                if (retVal is null)
                {
                    return new ConnectionResponse()
                    {
                        DateTime = DateTime.Now,
                        Success = true,
                        Data = JsonSerializer.Deserialize<DatabaseModel[]>("[]")
                    };
                }
                var listNm = JsonSerializer.Deserialize<DatabaseModel[]>(retVal.ToString());
                return new ConnectionResponse()
                {
                    DateTime = DateTime.Now,
                    Success = true,
                    Data = listNm
                };
            }
            catch (Exception ex)
            {
                return new ConnectionResponse()
                {
                    DateTime = DateTime.Now,
                    Message = ex.Message
                };
            }
            finally
            {
                SqlConn.Close();
            }
        }

    }
}
