//using System;

//class ProgramaPrincipal
//{
    //static void Main()
    {
        Console.WriteLine("Ejecutando ejercicio 1:");
        Ejercicio1.Mostrar();
        Console.WriteLine("\nEjecutando ejercicio 2");
        GestorPrecios gestor = new GestorPrecios();
        gestor.MostrarResultados();
        Console.WriteLine("\nEjecutando ejercicio 3");
        ProgramaAsignaturas.Mostrar();
        Console.WriteLine("\nEjecutando ejercicio 4");
        ListaNumeros lista = new ListaNumeros();
        lista.MostrarInverso();
        Console.WriteLine("\nEjecutando ejercicio 5");
        Console.Write("Ingrese una palabra para contar vocales:");
        string palabra = Console.ReadLine();
        ContadorVocales contador = new ContadorVocales(palabra);
        contador.MostrarResultado();

    }
//}
