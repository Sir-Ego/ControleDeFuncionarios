using ProjetoAula04.Entities;
using ProjetoAula04.Enums;
using ProjetoAula04.Repositories;
using ProjetoAula04.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Controllers
{
    /// <summary>
    /// Classe de controle para realizar os fluxos de açoes de funcionario
    /// </summary>
    public class FuncionarioController
    {
        /// <summary>
        /// Metodo para realizar o cadastro de funcionario
        /// </summary>
        public void Cadastrarfuncionario()
        {
            Console.WriteLine("\n*** CADASTRO DE FUNCIONARIO ***\n");

            // criando um objeto da classe Funcionario
            var funcionario = new Funcionario();

            Console.Write("INFORME O NOME DO FUNCIONARIO......: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("INFORME O CPF DO FUNCIONARIO......: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("INFORME O SALÁRIO DO FUNCIONARIO......: ");
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.Write("\t(1) ESTÁGIO");
            Console.Write("\t(2) CLT");
            Console.Write("\t(3) TERCEIRIZADO");
            Console.Write("\nINFORME O TIPO (1, 2 OU 3)........: ");
            funcionario.Tipo = (TipoContratacao) int.Parse(Console.ReadLine());

            #region Validação dos dados do funcionário

            //Instanciando a Classe de validação do funcionário
            var funcionarioValidator = new FuncionarioValidator();

            //Aplicar as regras de validação no objeto 'funcionário'
            var result = funcionarioValidator.Validate(funcionario);

            //Verificar se o funcionário passou nas validações
            if(result.IsValid)
            {
                //Instanciando a classe de repository JSON
                var funcionarioRepositoryJson = new FuncionarioRepositoryJson();
                funcionarioRepositoryJson.ExportarDados(funcionario);
                Console.WriteLine("\nFUNCIONARIO CADASTRADO COM SUCESSO!");

                //Instanciando a classe de repository SQL
                var funcionarioRepositorySql = new FuncionarioRepositorySql();
                funcionarioRepositorySql.ExportarDados(funcionario);
                Console.WriteLine("\nFUNCIONARIO CADASTRADO COM SUCESSO!");

            }
            else
            {
                Console.WriteLine("\nOCORRERAM ERROS DE VALIDAÇÃO:");

                //Percorrendo todos os erros de validação encontrados
                foreach (var item in result.Errors)
                {
                    //Imprimindo cada mensagem de erro de validação obtida
                    Console.WriteLine(item.ErrorMessage);
                }
            }
            #endregion
        }
    }
}
