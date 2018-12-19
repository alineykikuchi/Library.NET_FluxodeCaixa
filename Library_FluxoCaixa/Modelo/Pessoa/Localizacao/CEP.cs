using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Localizacao
{
    public class CEP
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;
        public Logradouro Logradouro;
        
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

        public CEP()
        {

        }

        public CEP(int Id, string Descricao, Logradouro Logradouro)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }
        #endregion

    }
}
