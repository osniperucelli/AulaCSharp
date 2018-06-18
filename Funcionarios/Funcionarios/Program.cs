using FuncionariosModel.Model;
using FuncionariosController.Controller;
using System;
using System.Collections.Generic;
using Util;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            FuncionarioController controller = new FuncionarioController();

            int opcao;
            do
            {
                opcao = ImprimirMenu();

                switch (opcao)
                {
                    case 1:
                        string nome = UtilTeclado.LerDoTeclado("Nome: ");
                        string cargo = UtilTeclado.LerDoTeclado("Cargo: ");
                        double salario = UtilTeclado.LerDouble("Salario: ");

                        Funcionario novoFuncionario = controller.CadastrarFuncionario(nome, cargo, salario);
                        funcionarios.Add(novoFuncionario);
                        break;

                    case 2:
                        controller.ListarFuncionarios(funcionarios);
                        break;

                    case 3:
                        string nomeBuscar = UtilTeclado.LerDoTeclado("Nome do funcionario a alterar: ");
                        controller.AlterarFuncionario(nomeBuscar, funcionarios);  ///funcionarios é a colecao a list
                        break;

                    case 4:
                        controller.ExcluirFuncionario(funcionarios);
                        break;

                    case 0:
                        FimDoPrograma();
                        break;

                    default:
                        UtilTeclado.ImprimirMensagem("Opcao Invalida. Tente novamente!");
                        break;

                }

            } while (opcao != 0);

        }

        static void FimDoPrograma()
        {
            UtilTeclado.ImprimirMensagem("Fim do programa... pressione enter para finalizar");
            Console.ReadLine();
        }

        static int ImprimirMenu()
        {
            //imprimir na tela as opcoes menu
            UtilTeclado.ImprimirMensagem("Menu de Opcoes: ");
            UtilTeclado.ImprimirMensagem("1 - Incluir Funcionario");
            UtilTeclado.ImprimirMensagem("2 - Listar Funcionario");
            UtilTeclado.ImprimirMensagem("3 - Alterar Funcionario");
            UtilTeclado.ImprimirMensagem("4 - Excluir Funcionario");
            UtilTeclado.ImprimirMensagem("0 - Sair");

            //ler opcao escolhida
            int opcao = UtilTeclado.LerInteiro("Escolha uma opcao: ");

            //retornar opcao escolhida
            return opcao;
        }
    }
}
