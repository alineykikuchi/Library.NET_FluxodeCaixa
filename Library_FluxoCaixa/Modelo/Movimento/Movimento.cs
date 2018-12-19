using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_FluxoCaixa.Modelo.Venda;

namespace Library_FluxoCaixa.Modelo.Movimento
{
    class Movimento
    {
        private int id;
        private DateTime data;
        private double valorTotal;

        public Caixa Caixa;
        public FormaMovimento FormaMovimento;
        public Pedido Pedido;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public Movimento()
        {

        }
        public Movimento(int Id, DateTime Data, double ValorTotal)
        {
            this.Id = Id;
            this.Data = Data;
            this.ValorTotal = ValorTotal;
        }
    }
}
