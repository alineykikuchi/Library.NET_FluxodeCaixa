using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_FluxoCaixa.Conectividade
{
    //[Serializable]
    public class ConexaoEx
    {
        
        private SqlConnection connection;
        private Int32 commandTimeout;


        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        public Int32 CommandTimeout
        {
            get { return commandTimeout; }
            set { commandTimeout = value; }
        }


        private SqlTransaction Transacao;

        #region *** Métdodo de Controle de Transacao ***
        public void IniciarTransacao()
        {
            this.BeginTransacao();
        }
        public void BeginTransacao()
        {
            this.Transacao = this.Connection.BeginTransaction();
        }
        public void CommitTransacao()
        {
            this.Transacao.Commit();
            this.Transacao = null;
        }
        public void Rollback()
        {
            this.Transacao.Rollback();
            this.Transacao = null;
        }
        #endregion


        public DataTable getDataTable(string strSQL)
        {
            return getDataTable(strSQL, new List<SqlParameter>());
        }
        public DataTable getDataTable(string SQL, List<SqlParameter> Parametros)
        {    
            SqlDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            SqlCommand Command = new SqlCommand();

            Command.Connection = this.Connection;
            Command.CommandTimeout = this.CommandTimeout;
            Command.CommandText = SQL.ToString();

            foreach(SqlParameter parametros in Parametros )
            {
                Command.Parameters.Add(parametros);
            }

            dataAdapter = new SqlDataAdapter(Command);
            dataAdapter.Fill(dataTable);
            dataTable.Dispose();

            return dataTable;
        }

        public void execCommand(string SQL)
        {

        }
        public void execCommand(string SQL, List<SqlParameter> Parametros)
        {
            SqlCommand Command = new SqlCommand();
            try
            {
                Command.Connection = this.Connection;
                Command.CommandTimeout = this.CommandTimeout;

                this.IniciarTransacao();
                
                Command.CommandText = SQL.ToString();

                foreach (SqlParameter parametros in Parametros)
                {
                    Command.Parameters.Add(parametros);
                }
                Command.ExecuteNonQuery();

                if (this.Transacao != null)
                {
                    this.CommitTransacao();
                }
            }
            catch (Exception ex)
            {
                this.Rollback();
                throw ex;
            }
            
        }
    }
}
