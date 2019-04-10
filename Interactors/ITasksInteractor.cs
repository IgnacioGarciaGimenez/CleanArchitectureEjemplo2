using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interactors
{
    public interface ITasksInteractor
    {
        void GuardarTarea(TareaDTO tarea);
    }
}
