using Entidades;
using System;

namespace Interactors
{
    public class TasksInteractor : ITasksInteractor
    {
        private readonly ITareaRepositorio _repositorio;

        public TasksInteractor(ITareaRepositorio repo)
        {
            _repositorio = repo;
        }

        public void GuardarTarea(TareaDTO tarea)
        {
            Tarea tar = new Tarea();
            tar.Nombre = tarea.Nombre;
            tar.Descripcion = tarea.Descripcion;
            _repositorio.Save(tar);

        }

    }
}
