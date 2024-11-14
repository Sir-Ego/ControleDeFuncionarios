using ProjetoAula04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Interfaces
{
   /// <summary>
   /// Interface para abstração do repositorio funcionario
   /// </summary>
    public interface IFuncionarioRepository
    {
        /// <summary>
        /// Método abstrato para exportar dados de funcionarios
        /// </summary>
        void ExportarDados(Funcionario funcionario);
    }
}
