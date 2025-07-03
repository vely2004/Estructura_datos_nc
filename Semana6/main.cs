using System;

class ProgramaPrincipal
{
    static void Main()
    {
        Console.WriteLine("Ejecutando ListaInvertida:");

        var lista = new Semana6.ListaInvertida();
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        Console.Write("Lista original: ");
        lista.Mostrar();

        lista.Invertir();
        Console.Write("Lista invertida: ");
        lista.Mostrar();

        Console.WriteLine("\nEjecutando ListaEstudiantes:");

        var listaEstudiantes = new Semana6.ListaEstudiantes();

        listaEstudiantes.Agregar(new Semana6.Estudiante("0101", "Ana", "Pérez", "ana@mail.com", 8.5f));
        listaEstudiantes.Agregar(new Semana6.Estudiante("0202", "Luis", "Gómez", "luis@mail.com", 6.0f));
        listaEstudiantes.Agregar(new Semana6.Estudiante("0303", "Marta", "Suárez", "marta@mail.com", 7.0f));

        listaEstudiantes.Mostrar();

        listaEstudiantes.Contar(out int aprobados, out int reprobados);
        Console.WriteLine($"Aprobados: {aprobados}, Reprobados: {reprobados}");
    }
}
