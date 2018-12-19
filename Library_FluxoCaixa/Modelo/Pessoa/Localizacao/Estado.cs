using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Localizacao
{
    public class Estado
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;
        private string sigla;

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

        public string Sigla
        {
            get { return sigla.ToUpper(); }
            set { sigla = value; }
        }
        #endregion

        #region "CONSTRUTOR"

        public Estado()
        {

        }
        public Estado(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }

        public Estado(int Id, string Descricao, string Sigla)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Sigla = Sigla;
        }

        #endregion

    }
}
