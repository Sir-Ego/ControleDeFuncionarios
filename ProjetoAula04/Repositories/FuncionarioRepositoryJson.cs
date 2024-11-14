using Newtonsoft.Json;
using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Repositories
{
    /// <summary>
    /// Implementacao de repositorio de funcionario 
    /// para gravacao de dados em arquivos JSON
    /// </summary>
    public class FuncionarioRepositoryJson: IFuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            //converter dados do funcionario em JSON
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            //abrindo um arquivo para gravacao
            var streamWriter = new StreamWriter("c:\\temp\\funcionarios.json", true);

            //gravar dados no arquivo
            streamWriter.WriteLine(json);   

            //fechando o arquivo
            streamWriter.Close();   
        }
    }
}
