using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Localizacao
{
    public class Endereco
    {
        #region *** PROPRIEDADES ***
        private int id;
        private int numero;
        private string complemento;
        private bool status;

        public CEP CEP;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        #region *** CONSTRUTOR ***

        public Endereco()
        {

        }

        public Endereco(int Id, int Numero, string Complemento, bool Status)
        {
            this.Id = Id;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.Status = Status;
        }
        #endregion

    }
}
