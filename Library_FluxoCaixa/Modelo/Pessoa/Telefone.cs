using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa
{
    public class Telefone
    {
        #region *** PROPRIEDADES ***
        private int id;
        private int _DDD;
        private int numero;
        public TipoTelefone TipoTelefone;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int DDD
        {
            get { return _DDD; }
            set { _DDD = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        #endregion

        #region *** CONSTRUTOR ***

        public Telefone()
        {

        }

        public Telefone(int Id, int DDD, int Numero)
        {
            this.Id = Id;
            this.DDD = DDD;
            this.Numero = Numero;
        }

        public Telefone(int Id, int DDD, int Numero, TipoTelefone TipoTelefone)
        {
            this.Id = Id;
            this.DDD = DDD;
            this.Numero = Numero;
            this.TipoTelefone = TipoTelefone;
        }
        #endregion 
    }
}
