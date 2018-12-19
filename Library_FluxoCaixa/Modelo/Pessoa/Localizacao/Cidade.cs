using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Localizacao
{
    public class Cidade
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;
        public Estado Estado;
      
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        #endregion

        #region "CONSTRUTOR"

        public Cidade()
        {

        }
        public Cidade(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }

        public Cidade(int Id, string Descricao, Estado Estado)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Estado = Estado;
        }

        #endregion
    }
}
