using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace UI.Controllers
{
    public class ControllerBase:DataControllerBase { 
        public string getDataAndType(object obj)
        {
            string result="";
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                if (prop.GetIndexParameters().Length == 0)
                {
                    result += prop.Name+"\t";
                    result += prop.PropertyType.Name + "\t";
                    result += prop.GetValue(obj) + "\t";
                }
                else
                {
                    result += prop.Name + "\t";
                    result += prop.PropertyType.Name + "\t";
                }
                result += "\n";
            }
            return result;
        }
        public string Insert(object obj,string spName)
        {
            string result = "";
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 0;
            objToSqlParameters(obj);
            if (UseTransaction)
            {
                result = command.ExecuteNonQuery().ToString();
            }
            else
            {
                connection.Open();
                result = command.ExecuteNonQuery().ToString();
                connection.Close();
            }
            return result;
        }
        public string InsertID(object obj, string spName)
        {
            string result = "";
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 0;
            objToSqlParameters(obj);
            if (UseTransaction)
            {
                result = command.ExecuteScalar().ToString();
            }
            else
            {
                connection.Open();
                result = command.ExecuteScalar().ToString();
                connection.Close();
            }
            return result;
        }
        public string Update(object obj, string spName)
        {
            string result = "";
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 1;
            objToSqlParameters(obj);
            if (UseTransaction)
                result = command.ExecuteScalar().ToString();
            else
            {
                connection.Open();
                result = command.ExecuteNonQuery().ToString();
                connection.Close();
            }
            return result;
        }
        public string DeleteByID(string spName, string fieldID, string fieldValue)
        {
            string result = "";
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 2;
            command.Parameters.Add("@" + fieldID, SqlDbType.Char).Value = fieldValue;
            if (UseTransaction)
                result = command.ExecuteScalar().ToString();
            else
            {
                connection.Open();
                result = command.ExecuteNonQuery().ToString();
                connection.Close();
            }
            return result;
        }
        public DataTable SelectAll(string spName)
        {
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 3;
            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable SelectByID(string spName,string fieldID,string fieldValue)
        {
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 4;
            command.Parameters.Add("@"+fieldID, SqlDbType.Char).Value = fieldValue;
            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable SelectAllActive(string spName)
        {
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 5;
            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public string AutoGenerateCode(string spName)
        {
            string result = "";
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 6;
            if (UseTransaction)
                result = command.ExecuteScalar().ToString();
            else
            {
                connection.Open();
                result = command.ExecuteScalar().ToString();
                connection.Close();
            }
            return result.PadLeft(4,'0');
        }
        public string DefaultID(string spName)
        {
            string result = "";
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 7;
            if (UseTransaction)
                if (command.ExecuteScalar() != null)
                    result = command.ExecuteScalar().ToString();
                else
                    result = "";
            else
            {
                connection.Open();
                if (command.ExecuteScalar() != null)
                    result = command.ExecuteScalar().ToString();
                else
                    result = "";
                connection.Close();
            }
            return result;
        }
        private void objToSqlParameters(object obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                string fieldName = "@" + prop.Name;
                string fieldType = prop.PropertyType.Name;
                object fieldValue = prop.GetValue(obj);
                sqlParaAdd(fieldName, fieldType, fieldValue, command);
            }
        }
        
        private void sqlParaAdd(string fieldName,string fieldType , object fieldValue,SqlCommand cmd)
        {
            switch (fieldType)
            {
                case "String":
                    command.Parameters.Add(fieldName, SqlDbType.NVarChar).Value = GetNull(fieldValue);
                    break;
                case "Int32":
                    command.Parameters.Add(fieldName, SqlDbType.Int).Value = GetNull(fieldValue);
                    break;
                case "Boolean":
                    command.Parameters.Add(fieldName, SqlDbType.Bit).Value = GetNull(fieldValue);
                    break;
                case "DateTime":
                    command.Parameters.Add(fieldName, SqlDbType.DateTime).Value = GetNull(fieldValue);
                    break;
                case "Decimal":
                    command.Parameters.Add(fieldName, SqlDbType.Decimal).Value = GetNull(fieldValue);
                    break;
                case "Double":
                    command.Parameters.Add(fieldName, SqlDbType.Float).Value = GetNull(fieldValue);
                    break;
                default:
                    break;
            }
        }
    }
}
