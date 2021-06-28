/*Escribir un programa que contenga:

1. Árbol binario

2. Árbol con múltiples hijos

3. Contar niveles

4. Contar hojas

5. Contar nodos

6. Navegación horizontal

7. Expresión matemática con + - * / tomar en cuenta las prioridades*/
using System.Linq;
using System;
using System.Collections.Generic;
namespace TareaArbol
{
    internal class ControladorArbol
    {
        internal int ContarHojas(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador += actual.Valor.Count() + actual.Hijos.Count();
            }
            return acumulador;
        }

        internal int ContarNodos(Nodo nodo)
        {
            int acumulador = 0;
            acumulador+=nodo.nodoRaiz+nodo.Hijos.Count();
            foreach (Nodo actual in nodo.Hijos)
            {
                acumulador+=actual.Hijos.Count;
            }
            return acumulador;
        }
        internal int ContarNiveles(Nodo nodo){
         int acumulador=0;
         foreach (Nodo actual in nodo.Hijos)
         {
             acumulador+=actual.Valor.Count();
         }
            return acumulador;
        }
       
    }
}