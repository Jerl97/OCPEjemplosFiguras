﻿using System;

namespace OCPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de areas");

            Refactorizacion.Calculadora calculadora = new Refactorizacion.Calculadora();

            Refactorizacion.Triangulo triangulo = new Refactorizacion.Triangulo
            {
                Base = 10,
                Altura = 5
            };

            Console.WriteLine("El area del triangulo es :{0}", calculadora.CalculadoraArea(triangulo));


            Refactorizacion.Cuadrado cuadrado = new Refactorizacion.Cuadrado
            {
                Lado = 6.0
            };


            Console.WriteLine("El area del cuadradp es :{0}", calculadora.CalculadoraArea(cuadrado));

            Refactorizacion.Circulo circulo = new Refactorizacion.Circulo
            {
                Radio = 5.0
            };


            Console.WriteLine("El area del circulo es :{0}", calculadora.CalculadoraArea(circulo));

            Refactorizacion.Rectangulo rectangulo = new Refactorizacion.Rectangulo
            {
                Base = 3.0,
                Atura = 5.2
            };
            Console.WriteLine("El area del rectangulo es :{0}", calculadora.CalculadoraArea(rectangulo));

            Refactorizacion.Cilindro cilindro = new Refactorizacion.Cilindro
            {
                Altura = 8.0,
                Radio = 5.0
            };
            Console.WriteLine("El Area del cilindro es :{0}", calculadora.CalculadoraArea(cilindro));

            Refactorizacion.Cono cono = new Refactorizacion.Cono
            {
                Base = 4.0,
                Altura = 6.0,
                Radio = 5.0
            };

            Console.WriteLine("El area de un cono es :{0}", calculadora.CalculadoraArea(cono));

            Refactorizacion.Pentagono pentagono = new Refactorizacion.Pentagono
            {
                LongitudLados = 6.0,
                Apotema = 8.0
            };
            Console.WriteLine("El area de un pentagono es :{0}", calculadora.CalculadoraArea(pentagono));

            Refactorizacion.Esfera esfera = new Refactorizacion.Esfera
            {
                Radio = 24
            };
            Console.WriteLine("El Area de una esfera es :{0}", calculadora.CalculadoraArea(esfera));
        }
    }
}