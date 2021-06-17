using System;

namespace myapp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //10 datos de una persona
                SaludoInicial(args);
                Console.WriteLine("Bienvenido");
                Console.Write("Ingrese su nombre: ");
                var nombre = Console.ReadLine();
                Console.Write("Ingrese su edad: ");
                string edad= Console.ReadLine();
                int edad1 = int.Parse(edad);
                Console.Write("Ingrese su peso: ");
                string peso= Console.ReadLine();
                float peso1= float.Parse(peso);
                Console.Write("¿Le gusta el futbol?: ");
                string pregunta= Console.ReadLine();
                bool pregunta1 = bool.Parse(pregunta);
                Console.Write("¿Que fecha es hoy?: ");
                string fecha= Console.ReadLine();
               
                Console.Write("¿Cual es su altura?: ");
                string altura= Console.ReadLine();
                float altura1= float.Parse(altura);
                Console.Write("¿Cual es su deporte favorito?: ");
                string deporte= Console.ReadLine();
                
                Console.Write("¿Cual es su pasatiempo favorito?: ");
                string pasatiempo= Console.ReadLine();
                
                Console.Write("¿Cual es su sueldo?: ");
                string sueldo= Console.ReadLine();
                double sueldo1= double.Parse(sueldo);
                Console.Write("¿En que semestre esta?: ");
                string semestre= Console.ReadLine();
               
                var persona = new Persona();
                persona.nombre=nombre;
                persona.edad=edad1;
                persona.peso=peso1;
                persona.pregunta=pregunta1;
                persona.fecha=fecha;
                persona.altura=altura1;
                persona.deporte=deporte;
                persona.pasatiempo=pasatiempo;
                persona.sueldo=sueldo1;
                persona.semestre=semestre;
                
                Console.WriteLine("Su informacion es la siguiente: ");
                Console.Write("nombre:"+persona.nombre +" ");
                Console.Write("edad:"+persona.edad +" ");
                Console.Write("peso:"+persona.peso +" ");
                Console.Write("pregunta:"+persona.pregunta +" ");
                Console.Write("fecha:"+persona.fecha +" ");
                Console.Write("altura:"+persona.altura +" ");
                Console.Write("deporte:"+persona.deporte +" ");
                Console.Write("pasatiempo:"+persona.pasatiempo +" ");
                Console.Write("sueldo:"+persona.sueldo +" ");
                Console.Write("semestre:"+persona.semestre +" ");
                Console.WriteLine("Gracias por participar");
                Console.ReadKey();


               


            
            
        }
        static void SaludoInicial(string[] args){
             if (args.Length > 3){

                Console.WriteLine("Hola " + args[0]+' '+args[1]+' '+args[2]+' '+args[3]);
                }
            else
            {
                Console.WriteLine("hola desconocido");
            }
            Console.WriteLine("¿Cómo estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmmm,entiendo");
            Console.ReadKey();
        }




    
    }
}