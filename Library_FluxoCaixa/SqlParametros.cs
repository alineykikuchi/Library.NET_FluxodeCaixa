using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;

namespace Library_FluxoCaixa
{
    //TODO: estudar Recursividade


    //string texto;
    //texto = sqlNome.Substring(0, 10).Substring(4, 6);

    public class SqlParametros
    {
        private List<SqlParameter> listaParametros;

        public List<SqlParameter> ListaParametros
        {
            get { return listaParametros; }
            set { listaParametros = value; }
        }


        public SqlParametros()
        {

        }

        public SqlParametros Adicionar(string strSQL, object valor)
        {
            this.Add(strSQL, valor);
            return this;
        }
        private void Add(string sqlNome, object valor)
        {
            SqlParameter newParam = new SqlParameter();
            newParam.ParameterName = sqlNome;

            if (valor == null)
            {
                newParam.Value = DBNull.Value;
            }
            else
            {
                if (valor.GetType().BaseType.Equals(typeof(System.Enum)))
                {
                    if (EnumExtension.GetDatavalue((Enum)valor) != null)
                    {
                        newParam.Value = EnumExtension.GetDatavalue((Enum)valor);
                    }
                }
                else
                {
                    newParam.Value = valor;
                }
            }
            listaParametros.Add(newParam);
        }       
    }
}
