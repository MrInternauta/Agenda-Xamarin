using Agenda.Datos;
using Agenda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Logica
{
    public class LogicaPersonas
    {
        private RepositorioPersona _repoPersonas;
        public LogicaPersonas()
        {
            _repoPersonas = new RepositorioPersona();
        }
        public Persona getPerson (int id)
        {
            return _repoPersonas.ObtienePersona(id);
        }
        public void InsertPerson ( Persona  person)
        {
            _repoPersonas.InsertaPersona(person);
        }

    }
}
