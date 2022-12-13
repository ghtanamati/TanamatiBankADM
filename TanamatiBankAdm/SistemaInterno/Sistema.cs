using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanamatiBankAdm.Funcionarios;
using TanamatiBankAdm.Parceria;

namespace TanamatiBankAdm.SistemaInterno
{
    public class Sistema
    {
        public bool Logar(IAutenticavel autenticavel, string login, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(login,senha);
            if(usuarioAutenticado)
            {
                Console.WriteLine($"{login}, seja bem-vindo ao sistema da Tanamati Bank");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou senha incorretos");
                return false;
            }
        }
    }
}