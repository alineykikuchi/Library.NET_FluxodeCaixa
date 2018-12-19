using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_FluxoCaixa.Modelo.Pessoa.Heranca;

namespace Library_FluxoCaixa.Modelo.Venda
{
    class Pedido
    {
        #region *** PROPRIEDADE ***
        private int id;
        private DateTime dataHoraAbertura;        
        private DateTime dataHoraFechamento;

        public Mesa mesa;
        public Funcionario Funcionario;
        public Cliente Cliente;
        public FormaServico FormaServico;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DataHoraAbertura
        {
            get { return dataHoraAbertura; }
            set { dataHoraAbertura = value; }
        }
        public DateTime DataHoraFechamento
        {
            get { return dataHoraFechamento; }
            set { dataHoraFechamento = value; }
        }
        #endregion

        #region *** CONSTRUTOR ***
        public Pedido()
        {

        }
        public Pedido(int Id)
        {
            this.Id = Id;
        }
        #endregion
    }
}
