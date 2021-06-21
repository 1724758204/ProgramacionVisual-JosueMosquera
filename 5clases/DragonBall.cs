using System;
namespace _5_clases
{
    public class DragonBall
    {
        public string personajes;
        public string habilidades;
        public int esferasDelDragon;
        public string enemigos;
        public string videojuegos;
        public string peliculas;
        public int capitulos;
        public string creador;
        public DateTime fechaDeEmisión;
        public int idiomasTraducidos;
           public void mostrarPersonajes()
            {
                 Console.Write("los personajes principales son: Goku,Vegetta,Gohan,Bulma,Giren \n");

            }
            public void mostrarHabilidades()
            {
                Console.Write("las habilidades principales son:Kameha,Kiensan,Genkidama,Big-Bang,Kayoken,Ultra Instinto \n");
            }
            public void mostrarEnemigos()
            {
                Console.Write("los enemigos principales son:MajinBoo,Cell,Freezer,Giren,Janemba,Raditz,Cooler \n");

            }
            public void mostrarCreador(){
                Console.Write("el creador de dragon ball se llama Akira Toriyama \n");
            }
            public void mostrarFechaEmisión(){
                Console.Write("Dragon ball se emitio por primera vez el 26 de febrero de 1986 \n");
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
