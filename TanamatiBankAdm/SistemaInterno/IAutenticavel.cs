using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanamatiBankAdm.Funcionarios;

namespace TanamatiBankAdm.SistemaInterno
{
    public interface IAutenticavel
    {
        string Login { get; set; }
        string Senha { get; set; }
        bool Autenticar(string login, string senha);
    }
}