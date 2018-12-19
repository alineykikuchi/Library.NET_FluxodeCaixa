using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Heranca
{
    public class Permissao
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;
        private string funcao;

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
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }
        #endregion

        #region *** CONSTRUTOR ***

        public Permissao()
        {

        }

        public Permissao(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }
        #endregion 
    }
}
