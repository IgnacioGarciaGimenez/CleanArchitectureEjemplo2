using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    class SimulacionDBSingleton
    {
        public static SimulacionDBSingleton instance = null;
        public List<Tarea> repo = new List<Tarea>();

        private SimulacionDBSingleton() { }

        public static SimulacionDBSingleton GetInstance()
        {
            if (instance == null)
                instance = new SimulacionDBSingleton();
            return instance;
        }
    }
}
