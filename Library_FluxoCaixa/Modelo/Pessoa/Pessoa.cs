using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_FluxoCaixa.Modelo.Pessoa.Localizacao; 

namespace Library_FluxoCaixa.Modelo.Pessoa
{
    public class Pessoa
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string nome;
        public Endereco Endereco;
        public Telefone Telefone;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion 

        #region *** CONSTRUTOR ***

        public Pessoa()
        {

        }

        public Pessoa(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
        
        public Pessoa(int Id, string Nome, Endereco Endereco, Telefone Telefone)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
        }
        #endregion 
    }
}
