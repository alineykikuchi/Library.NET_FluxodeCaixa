using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Venda.Produto
{
    class Produto
    {
        #region *** PROPRIEDADE ***
        private int id;
        private string descricao;
        private double valorDescricao;

        public CategoriaProduto CategoriaProduto;
        public Marca Marca;

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
        public double ValorDescricao
        {
            get { return valorDescricao; }
            set { valorDescricao = value; }
        }
        #endregion

        #region*** COSNTRUTOR ***
        public Produto()
        {

        }
        public Produto(int Id)
        {
            this.Id = Id;
        }
        #endregion
    }
}
