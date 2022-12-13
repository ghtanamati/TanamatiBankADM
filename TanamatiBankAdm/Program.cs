using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanamatiBankAdm.Funcionarios;
using TanamatiBankAdm.Utilitarios;
using TanamatiBankAdm.SistemaInterno;
using TanamatiBankAdm.Parceria;

namespace TanamatiBankAdm
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Diretor Roberta = new Diretor("111.222.990-56");
            Roberta.Nome = "Roberta";
            Console.WriteLine(Roberta.Nome);
            Console.WriteLine($"R$ {Roberta.Salario}");
            Console.WriteLine($"Bonificação: R$ {Roberta.GetBonificacao()}");
            gerenciador.Registrar(Roberta);
            Roberta.AumentarSalario();
            Console.WriteLine($"Novo Salário: R$ {Roberta.Salario}\n");

            Designer Pedro = new Designer("000.000.212-88");
            Pedro.Nome = "Pedro";
            Console.WriteLine(Pedro.Nome);
            Console.WriteLine($"R$ {Pedro.Salario}");
            Console.WriteLine($"Bonificação: R$ {Pedro.GetBonificacao()}");
            gerenciador.Registrar(Pedro);
            Pedro.AumentarSalario();
            Console.WriteLine($"Novo Salário: R$ {Pedro.Salario}\n");

            GerenteDeContas Gustavo = new GerenteDeContas("064.671.777-88");
            Gustavo.Nome = "Gustavo";
            Console.WriteLine(Gustavo.Nome);
            Console.WriteLine($"R$ {Gustavo.Salario}");
            Console.WriteLine($"Bonificação: R$ {Gustavo.GetBonificacao()}");
            gerenciador.Registrar(Gustavo);
            Gustavo.AumentarSalario();
            Console.WriteLine($"Novo Salário: {Gustavo.Salario}\n");

            Auxiliar Gabriel = new Auxiliar("065.722.819-66");
            Gabriel.Nome = "Gabriel";
            Console.WriteLine(Gabriel.Nome);
            Console.WriteLine($"R$ {Gabriel.Salario}");
            Console.WriteLine($"Bonificação: R$ {Gabriel.GetBonificacao()}");
            gerenciador.Registrar(Gabriel);
            Gabriel.AumentarSalario();
            Console.WriteLine($"Novo Salário: R$ {Gabriel.Salario}\n");

            Console.WriteLine($"Total de Funcionários: {Funcionario.TotalDeFuncionarios}");
            Console.WriteLine($"Total de Bonificações: R$ {gerenciador.TotalDeBonificacao}");

            Sistema sistemaTanamati = new Sistema();

            Diretor Ingrid = new Diretor("999.123.758-11");
            Ingrid.Nome = "Ingrid Silva";
            Ingrid.Login = "ingridsilva";
            Ingrid.Senha = "password";

            GerenteDeContas Ursula = new GerenteDeContas("154.985.752-99");
            Ursula.Nome = "Ursula Machado";
            Ursula.Login = "ursulamachado";
            Ursula.Senha = "senha";

            ParceiroComercial Caio = new ParceiroComercial();
            Caio.Senha = "senh@";
            Caio.Login = "caiocandido";

            sistemaTanamati.Logar(Ingrid, "ingridsilva", "password");
            sistemaTanamati.Logar(Ursula, "ursulamachado", "senha");
            sistemaTanamati.Logar(Caio, "caiocandido", "senh@");
        }
    }
}