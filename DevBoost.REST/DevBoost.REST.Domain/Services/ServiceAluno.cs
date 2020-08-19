using DevBoost.REST.Domain.Entidade;
using DevBoost.REST.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBoost.REST.Domain.Services
{
    public class ServiceAluno : IServiceAluno
    {
        private readonly IRepositoryAluno _repositoryAluno;

        public ServiceAluno(IRepositoryAluno repositoryAluno)
        {
            _repositoryAluno = repositoryAluno;
        }

        public async Task<bool> Create(Aluno aluno)
        {
            return await _repositoryAluno.Create(aluno);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repositoryAluno.Delete(id);
        }

        public async Task<List<Aluno>> Get()
        {
            return await _repositoryAluno.Get();
        }

        public async Task<Aluno> GetId(int id)
        {
            return await _repositoryAluno.GetId(id);
        }

        public async Task<bool> Update(Aluno aluno)
        {
            return await _repositoryAluno.Update(aluno);
        }
    }
}
