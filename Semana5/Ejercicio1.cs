// Escribir un programa que almacene las asignaturas de un curso
using System;
using System.Collections.Generic;
using System.Data;
class Ejercicio1
{
    static void Mostrar()
    {
        List<string> lista = new List<string> { "Lenguaje", "Matemáticas", "Ciencias", "Sociales" };
        Console.WriteLine("Asignatura del curso");
        foreach (string asignatura in lista)
        {
            Console.WriteLine(asignatura);
        }
    }
    static void Main()
    {
        Mostrar();

    }
}


