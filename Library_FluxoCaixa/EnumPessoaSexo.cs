using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Library_FluxoCaixa
{
    public class EnumPessoaSexo
    {
        public enum PessoaSexo
        {
            [DataValue("M"), Description("")]
            Masculino = 0,
            [DataValue("F")]
            Feminino = 1
        }
    }
}
