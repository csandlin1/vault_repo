using System;
using System.Data;
using System.Data.SqlClient;
using TractInc.TrueTract.Entity;

namespace TractInc.TrueTract.Data
{
    class ExternalUserDataMapper
    {
        private const string SQL_EXISTS =
            @"
            SELECT * from db_ddladmin.[user_def]
             WHERE [user_name] = '{0}'
        ";

        private const string SQL_CREATE =
            @"
            INSERT INTO db_ddladmin.[user_def] (
                [user_name],
                [password], 
                first_name, 
                last_name,
                email,
                phone_num
                ) 
            VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}')
        ";

        public ExternalUserInfo Create(SqlConnection conn, ExternalUserInfo user)
        {
            string sql = String.Format(SQL_CREATE,
                                       user.UserName, user.Password,
                                       user.FirstName, user.LastName,
                                       user.Email, user.PhoneNum);

            SQLHelper.ExternalExecuteNonQuery(conn, CommandType.Text, sql, null);

            return user;
        }

        public bool Exists(SqlConnection conn, string userName)
        {
            string sql = String.Format(SQL_EXISTS,
                                       userName);

            using (SqlDataReader rdr = SQLHelper.ExternalExecuteReader(conn, CommandType.Text, sql, null))
            {
                return rdr.Read();
            }

        }

    }
}
