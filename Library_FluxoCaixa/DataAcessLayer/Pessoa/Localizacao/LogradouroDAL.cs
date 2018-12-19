using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_FluxoCaixa.Modelo.Pessoa.Localizacao;
using System.Data;
using Library_FluxoCaixa.Conectividade;

namespace Library_FluxoCaixa.DataAcessLayer.Pessoa.Localizacao
{
    public class LogradouroDAL
    {
        public List<Logradouro> BuscarListaEnderecos()
        {
            StringBuilder SQL = new StringBuilder();
            DataTable tabLogradouros = new DataTable();
            List<Logradouro> listLogradouros = new List<Logradouro>();

            SQL.AppendLine("SELECT");
            SQL.AppendLine("      Id");
            SQL.AppendLine("    , Id_TipoLogradouro");
            SQL.AppendLine("    , CodBairro");
            SQL.AppendLine("    , Trecho"); //TODO: 1-Descricao ou Trecho
           // SQL.AppendLine("    , NomeLogradouro");
            SQL.AppendLine("    , IdCEP");
            SQL.AppendLine("FROM");
            SQL.AppendLine("    Logradouro ");
            SQL.AppendLine("INNER JOIN Bairro ON Logradouro.CodBairro = CodBairro");
            SQL.AppendLine("INNER JOIN Cidade ON Bairro.CodCidade = Cidade.CodCidade");
            SQL.AppendLine("INNER JOIN Estado ON Cidade.CodEstado = Estado.CodEstado");

            tabLogradouros = Conexao.getDatatable(SQL);
            foreach(DataRow rowRegistro in tabLogradouros.Rows)
            {
                Logradouro Logradouro = new Logradouro();
                Logradouro.Id = rowRegistro.Field<int>("Id");
                //TODO: 2-Difinir no banco coluna 'Descricao' no banco ou mudar para 'Trecho'
                Logradouro.Descricao = rowRegistro.Field<string>("Descricao");

                TipoLogradouro TipoLogradouro = new TipoLogradouro();
                TipoLogradouro.Id = rowRegistro.Field<int>("TipoLogradouro");
                Logradouro.TipoLogradouro = TipoLogradouro;

                Bairro Bairro = new Bairro();
                Bairro.Id = rowRegistro.Field<int>("CodBairro");
                Logradouro.Bairro = Bairro;

                listLogradouros.Add(Logradouro);
            }
            return listLogradouros;
        }


        public void Insert(Logradouro Logradouro)
        {
            StringBuilder SQL = new StringBuilder();
            SqlParametros parametros = new SqlParametros();

            SQL.AppendLine("INSERT INTO");
            SQL.AppendLine("        Logradouro");
            
            SQL.AppendLine("    ( Id");
            SQL.AppendLine("    , Id_TipoLogradouro");
            SQL.AppendLine("    , CodBairro");
            SQL.AppendLine("    , Trecho"); 
           // SQL.AppendLine("    , NomeLogradouro");
            SQL.AppendLine("    , IdCEP)");
            SQL.AppendLine("VALUES");
            SQL.AppendLine("    ( @ID");
            SQL.AppendLine("    , @ID_TIPOLOGRADOURO");
            SQL.AppendLine("    , @CODBAIRRO");
            SQL.AppendLine("    , @TRECHO");
           // SQL.AppendLine("    , @NOMELOGRADOURO");
            SQL.AppendLine("    , @IDCEP)");

            parametros.Adicionar("@ID", Logradouro.Id)
                      .Adicionar("ID_TIPOLOGRADOURO", Logradouro.TipoLogradouro.Id)
                      .Adicionar("CODBAIRRO", Logradouro.Bairro.Id)
                      .Adicionar("TRECHO", Logradouro.Descricao)
                      .Adicionar("IDCEP", Logradouro.Nome);

            Conexao.execCommand(SQL, parametros);
        }
        public void Update(Logradouro Logradouro)
        {
            StringBuilder SQL = new StringBuilder();
            SqlParametros parametros = new SqlParametros();

            SQL.AppendLine("UPDATE");
            SQL.AppendLine("        Logradouro");
            SQL.AppendLine("SET");
            SQL.AppendLine("        Id                = @ID,");
            SQL.AppendLine("        Id_TipoLogradouro = @ID_TIPOLOGRADOURO,");
            SQL.AppendLine("        CodBairro         = @CODBAIRRO,");
            SQL.AppendLine("        Trecho            = @TRECHO,");
            // SQL.AppendLine("NomeLogradouro");
            SQL.AppendLine("        IdCEP             = @IDCEP)");
            SQL.AppendLine("WHERE");
            SQL.AppendLine("      Id = @ID");


            parametros.Adicionar("@ID", Logradouro.Id)
                      .Adicionar("@ID_TIPOLOGRADOURO", Logradouro.TipoLogradouro.Id)
                      .Adicionar("@CODBAIRRO", Logradouro.Bairro.Id)
                      .Adicionar("@TRECHO", Logradouro.Descricao)
                      .Adicionar("@IDCEP", Logradouro.Nome);
            
            Conexao.execCommand(SQL, parametros);
        }
        private void Delete(Logradouro Logradouro)
        {
            StringBuilder SQL = new StringBuilder();
            SqlParametros parametros = new SqlParametros();

            SQL.AppendLine("DELETE FROM");
            SQL.AppendLine("        Logradouro");
            SQL.AppendLine("WHERE");
            SQL.AppendLine("      Id = @ID");

            Conexao.execCommand(SQL, parametros);

        }
    }
}
