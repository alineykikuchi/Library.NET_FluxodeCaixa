using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Localizacao
{
    public class Logradouro
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;
        private string nome;

        public TipoLogradouro TipoLogradouro;
        public Bairro Bairro;

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

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region *** CONSTRUTOR ***

        public Logradouro()
        {

        }
        public Logradouro(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }

        public Logradouro(int Id, string Descricao, Bairro Bairro)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Bairro = Bairro;
        }

        #endregion
    }
}
