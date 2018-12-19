using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Heranca
{
    public class Cargo
    {
        #region *** PROPRIEDADES ***
        private int id;
        private string descricao;

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

        #region *** CONSTRUTOR ***
        public Cargo()
        {

        }

        public Cargo(int Id, string Descricao)
        {
            this.Id = Id;
            this.Descricao = Descricao;
        }
        #endregion
    }
}