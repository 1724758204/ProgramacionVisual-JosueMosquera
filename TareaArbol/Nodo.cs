/*Escribir un programa que contenga:

1. Árbol binario

2. Árbol con múltiples hijos

3. Contar niveles

4. Contar hojas

5. Contar nodos

6. Navegación horizontal

7. Expresión matemática con + - * / tomar en cuenta las prioridades*/
using System.Collections.Generic;
namespace TareaArbol
{
    class Nodo
    {
        public List<Nodo> Nodos
        {
            get;set;
        } = new List<Nodo>();
        public string Valor { get; set; }
        public List<Nodo> Hijos
        {

            get; set;
        } = new List<Nodo>();
        public int nivel;
        
        public int nodoRaiz=1;
    }
}
