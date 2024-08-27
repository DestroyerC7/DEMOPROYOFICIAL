using DEMOPROY1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_08_2024.Controladores
{
    public class DocenteController
    {
        private List<Docente> docentes = new List<Docente>();

        // Método para agregar un docente
        public void AgregarDocente(Docente docente)
        {
            docentes.Add(docente);
        }

        // Método para obtener todos los docentes
        public List<Docente> ObtenerDocentes()
        {
            return docentes;
        }

        // Método para actualizar un docente
        public void ActualizarDocente(Docente docente)
        {
            var existingDocente = docentes.FirstOrDefault(d => d.Id_Docente == docente.Id_Docente);
            if (existingDocente != null)
            {
                existingDocente.PrimerNombre = docente.PrimerNombre;
                existingDocente.SegundoNombre = docente.SegundoNombre;
                existingDocente.PrimerApellido = docente.PrimerApellido;
                existingDocente.SegundoApellido = docente.SegundoApellido;
                existingDocente.Email = docente.Email;
                existingDocente.Id_Titulo = docente.Id_Titulo;
            }
        }

        // Método para eliminar un docente
        public void EliminarDocente(int id)
        {
            var docente = docentes.FirstOrDefault(d => d.Id_Docente == id);
            if (docente != null)
            {
                docentes.Remove(docente);
            }
        }
    }
}
