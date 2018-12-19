using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Venda.Produto
{
    class Marca
    {
        #region *** PROPRIEDADE ***
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

        #region *** CONSTRUTOR ***
        public Marca()
        {

        }
        public Marca(int Id)
        {
            this.Id = Id;
        }
        #endregion
    }
}
