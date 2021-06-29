using System;
using System.Collections.Generic;
using System.Collections.Immutable;
namespace ProyectoIntegrador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] DiasDe = new string[]{
                 "Lunes",
                "Martes",
                "Miercoles",
                "Juevez",
                "Viernes",
                "Sabado",
                "Domingo"
            };

            DiasDeCirculacion placa1 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 1,
                Dias ={
                   DiasDe[0],DiasDe[4],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa2 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 2,
                Dias ={
                   DiasDe[0],DiasDe[1],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa3 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 3,
                Dias ={
                   DiasDe[0],DiasDe[1],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa4 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 4,
                Dias ={
                    DiasDe[1],DiasDe[2],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa5 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 5,
                Dias ={
                    DiasDe[1],DiasDe[2],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa6 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 6,
                Dias ={
                     DiasDe[2],DiasDe[3],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa7 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 7,
                Dias ={
                    DiasDe[2],DiasDe[3],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa8 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 8,
                Dias ={
                    DiasDe[3],DiasDe[4],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa9 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 9,
                Dias ={
                    DiasDe[3],DiasDe[4],DiasDe[5],DiasDe[6]
                }
            };
            DiasDeCirculacion placa0 = new DiasDeCirculacion()
            {
                UltimoDigitoPlaca = 0,
                Dias ={
                    DiasDe[0],DiasDe[4],DiasDe[5],DiasDe[6]
                }
            };
        
            placa0.Dias.ForEach(delegate(String dia){
                Console.WriteLine(dia);
            });

        }

        }
        class Vehiculo
        {
            string IDPlaca { get; set; }

            int NumeroMatricula
            {
                get; set;
            }


        }
        class Matricula
        {
            DateTime FechaMatricula
            {
                get; set;
            }
            DateTime FechaCaducidadMatricula
            {
                get; set;
            }

        }
        public class DiasDeCirculacion
        {
            public int UltimoDigitoPlaca
            {
                get; set;
            }
            public List<string> Dias
            {
                get; set;
            } = new List<string>();
        };



    }







/*Programa para ayudar a recordar los dias de circulacion de un vehiculo y fecha de matriculacion*/