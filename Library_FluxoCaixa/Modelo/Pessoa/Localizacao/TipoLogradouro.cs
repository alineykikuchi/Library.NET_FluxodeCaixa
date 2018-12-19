using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Localizacao
{
    public class TipoLogradouro
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;

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

        #region*** CONSTRUTOR ***

        public TipoLogradouro()
        {

        }

        public TipoLogradouro(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }
        #endregion
    }
}
