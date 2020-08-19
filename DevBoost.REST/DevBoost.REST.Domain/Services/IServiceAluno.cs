using DevBoost.REST.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBoost.REST.Domain.Services
{
    public interface IServiceAluno
    {
        Task<List<Aluno>> Get();
        Task<Aluno> GetId(int id);
        Task<bool> Create(Aluno aluno);
        Task<bool> Update(Aluno aluno);
        Task<bool> Delete(int id);
    }
}
