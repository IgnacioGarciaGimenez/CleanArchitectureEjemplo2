using Entidades;
using Interactors;
using System;

namespace Repositorio
{
    public class TareaRepositorio : ITareaRepositorio
    {
        public void Save(Tarea tarea)
        {
            var db = SimulacionDBSingleton.GetInstance();
            db.repo.Add(tarea);
            db.repo.ForEach(x => Console.WriteLine(x.Nombre));
        }
    }
}
