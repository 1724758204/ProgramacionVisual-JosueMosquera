using System;

namespace _5_clases
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var dragon = new DragonBall();
            var dota2 = new videojuegoDota2();
            var lol = new VideojuegoLeagueOfLegends();
            var spider = new MarvelSpiderman();
            var saintseiya = new SaintSeiyaAnime();
            while (true)
            {
                Console.WriteLine("Bienvenido, Elija una opcion para ver la informacion de cada clase: \n 1.DragonBall \n 2.Dota 2 \n 3.League of Legends \n 4.Spiderman \n 5.Saint Seiya  \n 6.Salir ");
                var opcion = Console.ReadLine();
                int opcion1 = int.Parse(opcion);
                if (opcion1 == 1)
                {

                    dragon.mostrarPersonajes();

                    dragon.mostrarHabilidades();

                    dragon.mostrarCreador();

                    dragon.mostrarEnemigos();

                    dragon.mostrarFechaEmisión();

                }
                if (opcion1 == 2)
                {
                    dota2.mostrarPersonajes();

                    dota2.mostrarItems();

                    dota2.mostrarObjetivo();

                    dota2.mostrarRoles();

                    dota2.mostrarMedallas();

                }
                if (opcion1 == 3)
                {
                    lol.mostrarPersonajes();

                    lol.mostrarItems();

                    lol.mostrarObjetivo();

                    lol.mostrarRoles();

                    lol.mostrarMedallas();


                }

                if (opcion1 == 4)
                {
                    spider.mostrarReseñaSpiderman();

                    spider.mostraraliadosDeSpiderman();

                    spider.mostrarHabilidadesSpiderman();

                    spider.mostrarFechaAparición();

                    spider.mostraenemigosDeSpiderman();

                }

                if (opcion1 == 5)
                {
                    saintseiya.mostrarCreador();

                    saintseiya.mostrarEnemigos();

                    saintseiya.mostrarFechaEmisión();

                    saintseiya.mostrarPersonajes();

                    saintseiya.mostrarHabilidades();

                }
                if (opcion1==6){
                    Console.Write("Gracias por usar el programa Hasta la proxima");
                    break;
                }
            }
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
