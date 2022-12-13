using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanamatiBankAdm.SistemaInterno;

namespace TanamatiBankAdm.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf, double salario = 4000) : base(cpf, salario)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario*0.25;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}