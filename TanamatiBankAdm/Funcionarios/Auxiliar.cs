using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanamatiBankAdm.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf, double salario = 2000) : base (cpf, salario)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario*0.2;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}