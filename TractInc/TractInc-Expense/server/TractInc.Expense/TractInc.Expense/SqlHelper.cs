using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace TractInc.Expense
{
    internal class SqlHelper
    {
        
        #region Configuration Values

        private const string CONNECTION_STRING_KEY = "connectionStringRAID";

        #endregion

        #region Factory Methods

        public static SqlConnection CreateConnection() {
            return new SqlConnection(ConnectionString);
        }

        private static string ConnectionString {
            get {
                string result = ConfigurationManager.AppSettings[CONNECTION_STRING_KEY];
                if (null == result || result.Length == 0) {
                    throw new ConfigurationErrorsException("Connection string not found");
                }

                return result;
            }
        }

        #endregion

        #region Internal Methods

        internal static int ExecuteNonQuery(SqlTransaction tran, CommandType cmdType,
                                            string cmdText, params DbParameter[] cmdParams)
        {
            SqlCommand cmd = PrepareCommand(tran, cmdType, cmdText, cmdParams);
            int result;

            try {
                result = cmd.ExecuteNonQuery();
            } catch (Exception e) {
                try {
                    tran.Rollback();
                } catch {}
                throw e;
            }

            cmd.Parameters.Clear();

            return result;
        }

        internal static SqlDataReader ExecuteReader(SqlTransaction tran, CommandType cmdType,
                                                  string cmdText, params DbParameter[] cmdParams) {
            SqlCommand cmd = PrepareCommand(tran, cmdType, cmdText, cmdParams);

            SqlDataReader rdr;

            try {
                rdr = cmd.ExecuteReader();
            } catch (Exception e) {
                try {tran.Rollback();} catch {}
                throw e;
            }
            
            cmd.Parameters.Clear();
            return rdr;
        }

        internal static object ExecuteScalar(SqlTransaction tran, CommandType cmdType,
                                                  string cmdText, params DbParameter[] cmdParams) {
            SqlCommand cmd = PrepareCommand(tran, cmdType, cmdText, cmdParams);
            
            object result;
            
            try {
                result = cmd.ExecuteScalar();
            } catch (Exception e) {
                try {
                    tran.Rollback();
                } catch {}
                throw e;
            }
            
            cmd.Parameters.Clear();
            return result;
        }
        
        internal static SqlCommand PrepareCommand(SqlTransaction tran,
                                            CommandType cmdType, string cmdText, DbParameter[] cmdParams) {
            SqlCommand cmd = tran.Connection.CreateCommand();
            cmd.Connection = tran.Connection;
            cmd.Transaction = tran;
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;

            if (null != cmdParams) {
                foreach (DbParameter parm in cmdParams) {
                    cmd.Parameters.Add(parm);
                }
            }
            
            return cmd;
        }

        #endregion
    }
}
