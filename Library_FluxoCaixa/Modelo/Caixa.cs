using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_FluxoCaixa.Modelo.Pessoa.Heranca;

namespace Library_FluxoCaixa.Modelo
{
    class Caixa
    {
        #region *** PROPRIEDADE ***
        private int id;
        private DateTime dataHoraAbertura;
        private DateTime dataHoraFechamento;

        public Funcionario Funcionario;

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
        public Caixa()
        {

        }
        public Caixa(int Id, DateTime dataHoraAbertura, DateTime DataHoraFechamento, Funcionario Funcionario)
        {
            this.Id = Id;
            this.DataHoraAbertura = DataHoraAbertura;
            this.DataHoraFechamento = DataHoraFechamento;
            this.Funcionario = Funcionario;
        }
        #endregion
    }
}
