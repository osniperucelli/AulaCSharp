//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Funcionarios
//{
//    class ProgramSemOO
//    {
//        static void Main2(string[] args)
//        {
//            string[] nomes = new string[10];
//            string[] cargos = new string[10];
//            double[] salarios = new double[10];
//            int qtd = 0;

//            int opcao;
//            do
//            {
//                opcao = ImprimirMenu();

//                switch(opcao)
//                {
//                    case 1:
//                        IncluirFuncionario(nomes, cargos, salarios, ref qtd);
//                        break;

//                    case 2:
//                        ListarFuncionarios(nomes, cargos, salarios, qtd);
//                        break;

//                    case 3:
//                        AlterarFuncionario(nomes, cargos, salarios, qtd);
//                        break;

//                    case 4:
//                        ExcluirFuncionario(nomes, cargos, salarios, ref qtd);
//                        break;

//                    case 0:
//                        FimDoPrograma();
//                        break;

//                    default:
//                        ImprimirMensagem("Opcao Invalida. Tente novamente!");
//                        break;

//                }

//            } while (opcao != 0);
                        
//        }

//        static void IncluirFuncionario(string[] nomes, string[] cargos, double[] salarios, ref int qtd)
//        {
//            string nome = LerDoTeclado("Nome: ");
//            string cargo = LerDoTeclado("Cargo: ");
//            double salario = LerDouble("Salario: ");

//            nomes[qtd] = nome;
//            cargos[qtd] = cargo;
//            salarios[qtd] = salario;

//            qtd++;

//            Funcionario func = new Funcionario();
//            func.Nome = nome;
//            func.Cargo = cargo;
//            func.Salario = salario;
//            List<Funcionario> funcionarios = new List<Funcionario>();
//            funcionarios.Add(func);
//        }

//        static void ExcluirFuncionario(string[] nomes, string[] cargos, double[] salarios, ref int qtd)
//        {
//            string nomeExcluir = LerDoTeclado("Nome do funcionario a excluir: ");
//            int posicaoFuncionario = BuscarFuncionario(nomeExcluir, nomes, qtd);
//            if (posicaoFuncionario == -1)
//            {
//                ImprimirMensagem("Nao encontrado");
//            }
//            else
//            {
//                //algoritmo de exclusao
//                for(int i = posicaoFuncionario; i < qtd - 1; i++)
//                {
//                    nomes[i] = nomes[i + 1];
//                    cargos[i] = cargos[i + 1];
//                    salarios[i] = salarios[i + 1];
//                }

//                ImprimirMensagem("Excluido com sucesso");

//                qtd--;
//            }

//        }


//        static void ListarFuncionarios(string[] nomes, string[] cargos, double[] salarios, int qtd)
//        {
//            if (qtd == 0)
//            {
//                ImprimirMensagem("Nao ha funcionarios para listar");
//            }

//            for(int i=0; i<qtd; i++)
//            {
//                ImprimirMensagem(nomes[i] + " - " + cargos[i] + " - " + salarios[i]);
//            }
//        }

//        static void AlterarFuncionario(string[] nomes, string[] cargos, double[] salarios, int qtd)
//        {
//            string nomeBuscar = LerDoTeclado("Nome do funcionario a alterar: ");
//            int posicaoFuncionario = BuscarFuncionario(nomeBuscar, nomes, qtd);
//            //int n = 10;
//            if (posicaoFuncionario == -1)
//            {
//                ImprimirMensagem("Nao encontrado");
//            }
//            else
//            {
//                string cargo = LerDoTeclado("Cargo: ");
//                double salario = LerDouble("Salario: ");

//                cargos[posicaoFuncionario] = cargo;
//                salarios[posicaoFuncionario] = salario;

//                ImprimirMensagem("Alterado com sucesso");
//            }
//        }

//        static int BuscarFuncionario(string nome, string[] nomes, int qtd)
//        {
//            for (int i = 0; i < qtd; i++)
//            {
//                if (nomes[i].Equals(nome))
//                {
//                    return i; //Poiscao encontrada
//                }
//            }

//            return -1; //Nao encontrou
//        }

//        static void FimDoPrograma()
//        {
//            ImprimirMensagem("Fim do programa... pressione enter para finalizar");
//            Console.ReadLine();
//        }

//        static void ImprimirMensagem(string mensagem)
//        {
//            Console.WriteLine(mensagem);
//        }

//        static int LerInteiro()
//        {
//            string line = Console.ReadLine();
//            int iLine = Convert.ToInt32(line);

//            return iLine;
//        }

//        static int LerInteiro(string mensagem)
//        {
//            ImprimirMensagem(mensagem);

//            return LerInteiro();
//        }

//        static double LerDouble()
//        {
//            string line = Console.ReadLine();
//            double dLine = Convert.ToDouble(line);

//            return dLine;
//        }

//        static double LerDouble(string mensagem)
//        {
//            ImprimirMensagem(mensagem);

//            return LerDouble();
//        }

//        static string LerDoTeclado()
//        {
//            string line = Console.ReadLine();

//            return line;
//        }

//        static string LerDoTeclado(string mensagem)
//        {
//            ImprimirMensagem(mensagem);

//            return LerDoTeclado();
//        }

//        static int ImprimirMenu()
//        {
//            //imprimir na tela as opcoes menu
//            ImprimirMensagem("Menu de Opcoes: ");
//            ImprimirMensagem("1 - Incluir Funcionario");
//            ImprimirMensagem("2 - Listar Funcionario");
//            ImprimirMensagem("3 - Alterar Funcionario");
//            ImprimirMensagem("4 - Excluir Funcionario");
//            ImprimirMensagem("0 - Sair");

//            //ler opcao escolhida
//            int opcao = LerInteiro("Escolha uma opcao: ");

//            //retornar opcao escolhida
//            return opcao;
//        }







//    }
//}
