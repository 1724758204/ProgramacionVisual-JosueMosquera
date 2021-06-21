using System;
namespace _5_clases
{
    class MarvelSpiderman
    {
        public DateTime fechaAparición;
        public string AliadosDeSpiderman;
        public string habilidadesdeSpiderman;
        public string EnemigosDeSpiderman;
        public string peliculas;
        public string videojuegos;
        public string  reseñaSpiderman;
        public DateTime fechaPrimeraPublicacion;
        public string CancionesDeSpiderman;
        public string trajesdeSpiderman;

        public void mostrarFechaAparición(){
            Console.Write("Spiderman aparece por primera vez el 10 de agosto de 1962 \n");  
        }
        public void mostrarHabilidadesSpiderman(){
            Console.Write("las principales habilidades de spiderman son: lanzar telarañas,trepar paredes,fuerza sobrehumana,instintos amplicados.\n");
        }
         public void mostraraliadosDeSpiderman(){
            Console.Write("los principales aliados de spiderman son: Daredevil,Capitan America,AntorchaHumana,Doctor Strange.\n");
        }
         public void mostraenemigosDeSpiderman(){
            Console.Write("los principales enemigos de spiderman son: Rinho,Buitre,Duende Verde,Hombre de Arena,Dr Octopus\n");
        }
         public void mostrarReseñaSpiderman(){
            Console.Write("Spiderman es un personaje ficticio el cual adquiere sus poderes debido al mordisco de una araña, su historia se da en la ciudad de queens new york donde surgen sus aventuras.\n");
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
