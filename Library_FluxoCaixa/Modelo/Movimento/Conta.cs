using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Movimento
{
    class Conta
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;
        private string observacao;

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

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
        #endregion

        #region "CONSTRUTOR"

        public Conta()
        {

        }
        public Conta(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }

        public Conta(int Id, string Descricao, string Observacao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Observacao = Observacao;
        }

        #endregion
    }
}
