using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Venda.Produto
{
    class ItemPedido
    {
        #region *** PROPRIEDADE ***
        private int qtde;
        private double valor;

        public Produto Produto;
        public Pedido Pedido;


        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        #endregion

        #region *** CONSTRUTOR ***
        public ItemPedido()
        {

        }
        #endregion
    }
}
