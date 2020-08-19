using DevBoost.REST.Domain.Entidade;
using DevBoost.REST.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevBoost.REST.Repository
{
    public class RepositoryAluno : IRepositoryAluno
    {
        public async Task<bool> Create(Aluno aluno)
        {
            return await Task.Run(() => true);
        }

        public async Task<bool> Delete(int id)
        {
            return await Task.Run(() => true);
        }

        public async Task<List<Aluno>> Get()
        {
            var listaAluno = new List<Aluno>() { new Aluno { Id = new Guid(), Name = "Guilherme", Email = "guilherme_cupertino@hotmail.com" } };
            return await Task.Run(() => listaAluno);
        }

        public async Task<Aluno> GetId(int id)
        {
            var aluno = new Aluno { Id = new Guid(), Name = "Guilherme", Email = "guilherme_cupertino@hotmail.com" };
            return await Task.Run(() => aluno);
        }

        public async Task<bool> Update(Aluno aluno)
        {
            return await Task.Run(() => true);
        }
    }
}
