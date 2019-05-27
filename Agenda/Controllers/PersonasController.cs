using Agenda.Entidades;
using Agenda.Logica;
using Agenda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Controllers
{
    public class PersonasController : Controller
    {
        private LogicaPersonas _logiPerson;
        public PersonasController()
        {
            _logiPerson = new LogicaPersonas();
        }
        public ActionResult Detalle (int id)
        {
            var entidad = _logiPerson.getPerson(id);
            PersonaViewModel personavm = new PersonaViewModel
            {
                Id  = entidad.Id,
                Nombre = entidad.Nombre,
                Numero = entidad.Numero
            };
            return View(personavm);
        }
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear( CreaPersonaViewModel persona)
        {
            Persona entidadPersona = new Persona
            {
                Nombre = persona.Nombre,
                Numero = persona.Numero
            };
            _logiPerson.InsertPerson(entidadPersona);
            return RedirectToAction("Detalle", new { id = entidadPersona.Id });
        }

    }
}