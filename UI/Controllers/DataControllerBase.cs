using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UI.Controllers
{
    public class DataControllerBase
    {

        protected SqlCommand command;
        protected SqlTransaction Transaction;
        protected SqlConnection connection;

        #region Properties

        private bool _useTransaction;
        public bool UseTransaction
        {
            get { return _useTransaction; }
        }

        public static string MainDatabaseConnectionStringName
        {
            get { return "MAINDB"; }
        }

        #endregion

        #region Constructor

        public DataControllerBase()
        {
            connection = new SqlConnection("Server=.; Database=POS;User=sa;Password=2722014T&t;");
            //if (ConfigurationManager.AppSettings["User"] == "" && ConfigurationManager.AppSettings["Password"] == "")
            //{
            //    connection = new SqlConnection("Data Source=" + Functions.Decrypt(ConfigurationManager.AppSettings["Server"]) + ";Initial Catalog=" + Functions.Decrypt(ConfigurationManager.AppSettings["DataBase"]) + ";" + "Integrated Security=" + Functions.Decrypt(ConfigurationManager.AppSettings["Integrated Security Info"]) + ";");
            //}
            //else
            //{
            //    connection = new SqlConnection("Server=" + Functions.Decrypt(ConfigurationManager.AppSettings["Server"]) + ";" + "Database=" + Functions.Decrypt(ConfigurationManager.AppSettings["Database"]) + ";" + "User=" + Functions.Decrypt(ConfigurationManager.AppSettings["User"]) + ";" + "Password=" + Functions.Decrypt(ConfigurationManager.AppSettings["Password"]) + ";");
            //}
            ////connection = new SqlConnection(ConfigurationManager.ConnectionStrings["appSettings"].ConnectionString);
        }

        #endregion

        #region Transaction Control

        public void StartTransaction()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Transaction = connection.BeginTransaction();
            _useTransaction = true;
        }

        public void RollbackTransaction()
        {
            if (Transaction == null || connection.State != ConnectionState.Open) return;

            Transaction.Rollback();
            if (connection.State == ConnectionState.Open)
                connection.Close();

            _useTransaction = false;
        }

        public void CommitTransaction()
        {
            if (Transaction == null || connection.State != ConnectionState.Open) return;

            Transaction.Commit();
            if (connection.State == ConnectionState.Open)
                connection.Close();

            _useTransaction = false;
        }

        #endregion

        #region Helper Functions
        protected virtual object GetNull(object obj)
        {
            if (obj is String && obj.ToString() == "")
                obj = DBNull.Value;
            if (obj is DateTime && ((DateTime)obj) == DateTime.MinValue)
                obj = DBNull.Value;
            else if (obj is int && ((int)obj) == int.MinValue)
                obj = DBNull.Value;
            else if (obj is float && ((float)obj) == float.MinValue)
                obj = DBNull.Value;
            else if (obj is decimal && ((decimal)obj) == decimal.MinValue)
                obj = DBNull.Value;
            else if (obj is double && ((double)obj) == double.MinValue)
                obj = DBNull.Value;

            return obj;
        }

        #endregion

        #region BackUpRestore
        public void BackUpRestore(string str)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = new SqlCommand();
            command.CommandText = str;
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region Change Old Credit

        #endregion

    }
}
