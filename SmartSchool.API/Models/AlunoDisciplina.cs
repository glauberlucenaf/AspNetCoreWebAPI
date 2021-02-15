using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina()
        {

        }
        public AlunoDisciplina(int aLunoId, int disciplinaId)
        {
            ALunoId = aLunoId;
            DisciplinaId = disciplinaId;
        }

        public int ALunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
