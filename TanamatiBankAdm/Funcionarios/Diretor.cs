using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanamatiBankAdm.SistemaInterno;

namespace TanamatiBankAdm.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf, double salario = 5000) : base (cpf, salario)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario*0.5;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}