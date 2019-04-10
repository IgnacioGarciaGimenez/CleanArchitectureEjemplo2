using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interactors
{
    public interface ITareaRepositorio
    {
        void Save(Tarea tarea);
    }
}
