using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Library_FluxoCaixa.Conectividade
{
    interface IConexao
    {
        DataTable getDatatable(string SQL);

        void execCommand(string SQL);

        int getScalar(string SQL);
    }
}
