using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Localizacao
{
    
    public class Bairro
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;

        public Cidade Cidade;

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

        

        #region "CONSTRUTOR"

        public Bairro()
        {

        }
        public Bairro(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }

        public Bairro(int Id, string Descricao, Cidade Cidade)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Cidade = Cidade;
        }

        #endregion
    }
}
