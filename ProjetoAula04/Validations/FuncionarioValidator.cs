using FluentValidation;
using ProjetoAula04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Validations
{
    /// <summary>
    /// Classe para a validação dos dados do funcionário
    /// </summary>
    public class FuncionarioValidator : AbstractValidator <Funcionario>   
    {
        /// <summary>
        /// Método construtor para implementar as validaçoes do funcionario
        /// </summary>
        public FuncionarioValidator ()
        {
            //Validaçoes do campo Id
            RuleFor(f => f.Id)
                .NotEmpty().WithMessage("Por favor informe o ID do funcionário.");

            //Validaçoes do campo Nome
            RuleFor(f => f.Nome)
                .NotEmpty ().WithMessage("Por favor informe o Nome do funcionário.")
                .Length (8, 150).WithMessage("Por favor informe o Nome do funcionário de 8 a 150 caracteres.");

            //Validaçoes do campo Cpf
            RuleFor(f => f.Cpf)
                .NotEmpty().WithMessage("Por favor informe o Cpf do funcionário.")
                .Matches(@"^\d{11}$").WithMessage("Por favor, Informe o cpf com exatamente 11 números");
            
            //Validaçoes do campo Salario
            RuleFor(f => f.Salario)
                .GreaterThan(0).WithMessage("Por favor informe o salario com valor maior do que zero.");

            //Validaçoes do campo Tipo (enum)
            RuleFor(f => f.Tipo)
                .IsInEnum().WithMessage("Por favor informe o tipo de contratação válido (1, 2 ou 3)");
        }

       
    }
}
