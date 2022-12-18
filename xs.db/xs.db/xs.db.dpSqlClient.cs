using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace xs.db
{
    #region SqlClient DataProvider
    public class dpSqlClient : DataProvider
    {
        #region Değiştirilen Propertiler
        [Browsable(true)]
        [DefaultValue("")]
        [SettingsBindable(true)]
        [RefreshProperties(RefreshProperties.All)]
        //[Editor("Microsoft.VSDesigner.Data.SQL.Design.SqlConnectionStringEditor, Microsoft.VSDesigner, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new string ConnectionString
        {
            get { return base.ConnectionString; }
            set { base.ConnectionString = value; }
        }

        #endregion

        public override void ReadSchema(ref DataTable dt, string SqlText)
        {
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            da.FillSchema(dt, SchemaType.Source);            
        }

        public override void ReadData(ref DataTable dt, string SqlText)
        {
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            da.FillSchema(dt, SchemaType.Source);
            da.Fill(dt);
        }

        public override void SaveChanges(ref DataRow dr, string SqlText, ConflictOption _ConflictOption)
        {
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.SetAllValues = false; // sadece değiştirilmiş alanlar için update cümlesi oluşturulacak
            cb.ConflictOption = _ConflictOption; // Çakışma Ayarlayıcısı  

            DataRow[] drArray = new DataRow[1];
            drArray[0] = dr;            
            da.Update(drArray);
        }

        public override void ExecuteNonQuery(string SqlText)
        {
            using (SqlCommand Command = new SqlCommand(SqlText, new SqlConnection(this.ConnectionString)))
            {
                Command.Connection.Open();
                Command.ExecuteNonQuery();
                Command.Connection.Close();
            }
        }

        public override object ExecuteScalar(string SqlText)
        {
            object rV = null;
            using (SqlCommand Command = new SqlCommand(SqlText, new SqlConnection(this.ConnectionString)))
            {
                Command.Connection.Open();
                rV = Command.ExecuteScalar();
                Command.Connection.Close();
            }
            return rV;
        }

        public override void ExecuteNonQueryWithTransection(List<string> SqlTextList)
        {
            SqlCommand Command = new SqlCommand("", new SqlConnection(this.ConnectionString));
            Command.Connection.Open();
            SqlTransaction Transaction = Command.Connection.BeginTransaction();

            try
            {
                foreach (string S in SqlTextList)
                {
                    Command.CommandText = S;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
                Command.Connection.Close();
            }
            catch (Exception ex)
            {
                Transaction.Rollback();
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                Command.Connection.Close();
                Command.Dispose();
            }
        }

        public override string SqlConvertFetching(string SqlText, int StartRecord, int FetchSize)
        {
            return SqlText + " OFFSET "+StartRecord.ToString()+" ROWS FETCH NEXT "+FetchSize.ToString()+" ROWS ONLY";
        }

        public override List<string> GetTableList()
        {
            List<string> rV = new List<string>();

            DataTable dt = new DataTable("Tablo1");
            string SqlText = "Select name From sys.tables";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                rV.Add(dr[0].ToString());
            }

            return rV;
        }

        public override List<string> GetColumnList(string TableName)
        {
            List<string> rV = new List<string>();

            DataTable dt = new DataTable("Tablo1");
            string SqlText = "Select COLUMN_NAME From INFORMATION_SCHEMA.COLUMNS Where TABLE_NAME='" + TableName + "' Order By ORDINAL_POSITION";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                rV.Add(dr[0].ToString());
            }


            return rV;
        }

        public override List<string> GetProcedureList()
        {
            List<string> rV = new List<string>();

            DataTable dt = new DataTable("Tablo1");
            string SqlText = "Select name From sys.procedures";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                rV.Add(dr[0].ToString());
            }

            return rV;
        }

        public override List<string> GetFunctionList()
        {
            List<string> rV = new List<string>();

            DataTable dt = new DataTable("Tablo1");
            string SqlText = "Select name From sys.objects Where type='FN'";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                rV.Add(dr[0].ToString());
            }

            return rV;
        }

        public override List<string> GetViewList()
        {
            List<string> rV = new List<string>();

            DataTable dt = new DataTable("Tablo1");
            string SqlText = "Select name From sys.views";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                rV.Add(dr[0].ToString());
            }

            return rV;
        }

        public override List<string> GetSequenceList()
        {
            List<string> rV = new List<string>();

            DataTable dt = new DataTable("Tablo1");
            string SqlText = "Select name From sys.sequences";
            SqlDataAdapter da = new SqlDataAdapter(SqlText, this.ConnectionString);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                rV.Add(dr[0].ToString());
            }

            return rV;
        }
    }
    #endregion

}
