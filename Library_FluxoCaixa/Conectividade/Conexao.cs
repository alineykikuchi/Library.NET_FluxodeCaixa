using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_FluxoCaixa.Conectividade
{
    public static class Conexao
    {
        public static ConexaoEx ConexaoEx = new ConexaoEx();

        public static DataTable getDatatable(StringBuilder SQL)
        {
            return ConexaoEx.getDataTable(SQL.ToString());
        }
        public static DataTable getDatatable(StringBuilder SQL, List<SqlParameter> Parametros)
        {
            return ConexaoEx.getDataTable(SQL.ToString());
        }
        public static void execCommand(StringBuilder SQL, SqlParametros Parametros)
        {
            ConexaoEx.execCommand(SQL.ToString(), Parametros.ListaParametros);
        }
        
    }
}
