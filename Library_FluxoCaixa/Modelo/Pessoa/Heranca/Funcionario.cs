using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_FluxoCaixa.Modelo.Pessoa.Heranca
{
    public class Funcionario: Pessoa
    {
        #region *** PROPRIEDADES ***

        private string senha;
        private double salario;
        public Cargo Cargo;
        public Permissao Permissao;

        public string Senha
        {
            get { return senha; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    Exception ex = new Exception("Senha vazia! Por favor informe a senha.");
                    throw ex;
                }
                else
                {
                    for (int i = 0; i <= value.Length; i++ )
                    {
                        if(Char.IsLetterOrDigit(value,i) == true)
                        {
                            Exception ex = new Exception("Senha inválida! Digite apenas letras ou números.");
                            throw ex;
                        }
                    }
                    senha = value; 
                }
            }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        #endregion 

        #region *** CONSTRUTOR ***

        public Funcionario(int Id, string Senha)
        {
            this.Id = Id;
            this.Senha = Senha;
        }

        public Funcionario(double Salario, Cargo Cargo, Permissao Permissao)
        {
            this.Salario = Salario;
            this.Cargo = Cargo;
            this.Permissao = Permissao;
        }

        #endregion

    }
}
