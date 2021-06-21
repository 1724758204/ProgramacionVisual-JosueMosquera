using System;
namespace _5_clases
{
    class videojuegoDota2
    {
        public string personajes;
        public string roles;
        public string items;
        public string objetivo;
        public int heroesEnTotal;
        public DateTime fechaDeLanzamiento;
        public float espacioEnElSistema;
        public string medallas;
        public string mejoresJugadores;
        public string ultimoEquipoCampeonInternacional;

        public void mostrarPersonajes() {
            Console.Write("los personajes principales son: Invoker,Mirana,Techies,Drow Ranger,Meepo \n");
        }
        public void mostrarRoles(){
              Console.Write("los roles en Dota2 son: mid,support5,support4,hard carry,offlaner \n");
        }
        public void mostrarItems(){
              Console.Write("los items principales en dota 2 son: mango,tangos,salve,divine rapier,botella,vanguard\n");
        }
         public void mostrarObjetivo(){
              Console.Write("el objetivo del juego consiste en destruir la base enemiga,seras un personaje en un equipo de 5 personas.\n");
        }
         public void mostrarMedallas(){
              Console.Write("el juego en clasificatoria se divide en las siguientes medallas: heraldo,guardian,cruzado,arconte,leyenda,ancestral,divino,inmortal.\n");
        }
    }

}
/*Debes escribir un programa de consola con lenguaje C#, sobre los temas indicados en clase.

Cree 5 clases, cada una con 10 campos, sus propiedades correspondientes y 5 métodos.

Las clases deben enfocarse en algún juego de video, anime, tira cómica. ejemplo: Capitán Escudo ..

El programa debe cumplir:

El uso de "Console" los métodos de lectura y escritura, con sus sobrecargas.
La lectura de los parámetros enviados al programa y que se acceden desde args[].
Incluir los textos de la llamada al programa con los parámetros y que se obtiene en la consola, esto último incluir en el Readme
Subir los fuentes al git (no subir bin, obj)
El programa debe compilar.
El programa debe ejecutarse y los mensajes en pantalla deben ser claros.
Se deben respetar los estándares de programación.
Los nombres de las clases, objetos, métodos, atributos, variables, etcétera deben tener coherencia con el concepto que representan.*/
