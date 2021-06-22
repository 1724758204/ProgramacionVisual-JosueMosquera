using System.Collections.Generic;
using System;

namespace martes22
{
    class Pais
    {
        public int PaisId
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }

        public List<Provincia> Provincias{
            get;set;
        }
        
        public  int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            
            foreach (Provincia actual in Provincias)
            {
                acumulador = acumulador + actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    }
}
