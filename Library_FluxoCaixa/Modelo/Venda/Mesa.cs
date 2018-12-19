using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Venda
{
    class Mesa
    {
        #region *** PROPRIEDADE ***
        private int id;
        private bool status;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion
 
        #region *** CONSTRUTOR ***
        public Mesa()
        {

        }
        #endregion 
    }
}
