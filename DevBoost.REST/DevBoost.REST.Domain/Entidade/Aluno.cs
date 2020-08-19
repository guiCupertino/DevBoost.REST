using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.REST.Domain.Entidade
{
    public class Aluno : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
