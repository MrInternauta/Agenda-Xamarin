using Agenda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Datos
{
    public class RepositorioPersona
    {
        public static List<Persona> Data = new List<Persona>
        {
                new Persona { Id = 1, Nombre = "Tresa", Numero = "86-(298)400-4718" },
                new Persona { Id = 2, Nombre = "Heloise", Numero = "374-(504)537-6648" },
                new Persona { Id = 3, Nombre = "Karl", Numero = "63-(711)920-1723" },
                new Persona { Id = 4, Nombre = "Quincey", Numero = "420-(674)706-0990" },
                new Persona { Id = 5, Nombre = "Keely", Numero = "39-(739)212-0332" },
                new Persona { Id = 6, Nombre = "Mohammed", Numero = "46-(685)153-2680" },
                new Persona { Id = 7, Nombre = "Colby", Numero = "86-(454)575-7026" },
                new Persona { Id = 8, Nombre = "Lea", Numero = "62-(981)564-2972" },
                new Persona { Id = 9, Nombre = "Geordie", Numero = "1-(863)264-3908" },
                new Persona { Id = 10, Nombre = "Kacie", Numero = "55-(824)652-5355" },
                new Persona { Id = 11, Nombre = "Kin", Numero = "7-(271)441-0195" },
                new Persona { Id = 12, Nombre = "Mirabelle", Numero = "255-(369)425-3047" },
                new Persona { Id = 13, Nombre = "Dari", Numero = "62-(194)321-3945" },
                new Persona { Id = 14, Nombre = "Titus", Numero = "86-(686)580-5888" },
                new Persona { Id = 15, Nombre = "Camey", Numero = "86-(715)755-4909" },
                new Persona { Id = 16, Nombre = "Melisse", Numero = "86-(857)345-1102" },
                new Persona { Id = 17, Nombre = "Doloritas", Numero = "352-(515)915-4753" },
                new Persona { Id = 18, Nombre = "Barbey", Numero = "63-(576)466-3890" },
                new Persona { Id = 19, Nombre = "Flor", Numero = "57-(487)351-4680" },
                new Persona { Id = 20, Nombre = "Rheba", Numero = "55-(368)753-7642" },
                new Persona { Id = 21, Nombre = "Hale", Numero = "63-(955)136-5770" },
                new Persona { Id = 22, Nombre = "Keefe", Numero = "7-(678)624-5815" },
                new Persona { Id = 23, Nombre = "Bald", Numero = "62-(131)306-7765" },
                new Persona { Id = 24, Nombre = "Catlin", Numero = "351-(274)465-7813" },
                new Persona { Id = 25, Nombre = "Rorke", Numero = "86-(398)710-6099" },
                new Persona { Id = 26, Nombre = "Chloris", Numero = "98-(164)499-1504" },
                new Persona { Id = 27, Nombre = "Winifield", Numero = "86-(747)168-9394" },
                new Persona { Id = 28, Nombre = "Christoffer", Numero = "62-(146)454-6982" },
                new Persona { Id = 29, Nombre = "Akim", Numero = "81-(550)511-3855" },
                new Persona { Id = 30, Nombre = "Dasha", Numero = "86-(964)729-0764" }
        };
        public Persona ObtienePersona(int id)
        {
            return Data.FirstOrDefault(persona => persona.Id == id);
        }
        public void InsertaPersona(Persona persona)
        {
            int nextId = Data.Count() + 1;
            persona.Id = nextId;
            Data.Add(persona);
        }

    }
}

