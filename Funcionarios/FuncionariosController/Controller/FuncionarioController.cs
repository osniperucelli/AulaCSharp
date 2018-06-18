using FuncionariosModel.Model;
using Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncionariosModel.DAL;

namespace FuncionariosController.Controller
{
    public class FuncionarioController
    {
        private FuncionarioDAO funcionarioDAO;

        public FuncionarioController()
        {
            funcionarioDAO = new FuncionarioDAO();
        }

        public Funcionario CadastrarFuncionario(string nome, string cargo, double salario)
        {
            Funcionario func = new Funcionario();
            func.Nome = nome;
            func.Cargo = cargo;
            func.Salario = salario;

            //Gravar no banco atraves da DAL que se encontraria no projeto FuncionariosModel
            funcionarioDAO.Gravar(func);

            return func;
        }

        public void ExcluirFuncionario(List<Funcionario> funcionarios)
        {
            string nomeExcluir = UtilTeclado.LerDoTeclado("Nome do funcionario a excluir: ");
            Funcionario func = BuscarFuncionario(nomeExcluir, funcionarios); //classe variavel = funcao;
            if (func == null)                             //BuscarFuncionario retorna uma variavel funcionario, entoa, devo guardar em Funcionario. Se retornasse int, int func = ...
            {
                UtilTeclado.ImprimirMensagem("Nao encontrado");
            }
            else
            {
                //algoritmo de exclusao
                funcionarios.Remove(func);

                UtilTeclado.ImprimirMensagem("Excluido com sucesso");
            }

        }

        public void ListarFuncionarios(List<Funcionario> funcionarios)
        {
            if (funcionarios.Count == 0)
            {
                UtilTeclado.ImprimirMensagem("Nao ha funcionarios para listar");
            }

            //for (int i = 0; i < funcionarios.Count; i++)
            //{
            //    Funcionario f = funcionarios[i];
            //    ImprimirMensagem(f.Nome + " - " + f.Cargo + " - " + f.Salario);
            //}

            foreach (Funcionario func in funcionarios)
            {
                UtilTeclado.ImprimirMensagem(func.ToString());
            }
        }

        public void AlterarFuncionario(string nomeBuscar, List<Funcionario> funcionarios)
        {
            Funcionario funcionarioEncontrado = BuscarFuncionario(nomeBuscar, funcionarios);
            if (funcionarioEncontrado == null)
            {
                UtilTeclado.ImprimirMensagem("Nao encontrado");
            }
            else
            {
                string cargo = UtilTeclado.LerDoTeclado("Cargo: ");
                double salario = UtilTeclado.LerDouble("Salario: ");

                funcionarioEncontrado.Cargo = cargo; //.Cargo sem = chamo set ha alteracao, sem = chamo get
                funcionarioEncontrado.Salario = salario;

                UtilTeclado.ImprimirMensagem("Alterado com sucesso");
            }
        }

        public Funcionario BuscarFuncionario(string nome, List<Funcionario> funcionarios)
        {
            Funcionario encontradoFunc = null;
            foreach (Funcionario func in funcionarios)  //classe  variavel collecao  // func é objeto (variavel em tempo de execuacoa)
            {
                if (func.Nome.Equals(nome))
                {
                    //devo guardar o func
                    encontradoFunc = func;
                }
            }

            return encontradoFunc;
        }
    }
}
