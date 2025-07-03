using System;

namespace Semana6
{
    // Paso 1: Clase Nodo
    public class Nodo
    {
        public int valor;
        public Nodo? siguiente;

        public Nodo(int valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }
    }

    // Paso 2: Clase Lista con método para invertir
    public class ListaInvertida
    {
        private Nodo? cabeza;

        // Paso 3: Agregar un nuevo nodo al inicio
        public void Agregar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.siguiente = cabeza;
            cabeza = nuevo;
        }

        // Paso 4: Método para invertir la lista enlazada
        public void Invertir()
        {
            Nodo? anterior = null;
            Nodo? actual = cabeza;
            Nodo? siguiente;

            while (actual != null)
            {
                siguiente = actual.siguiente;  // Guardar el siguiente nodo
                actual.siguiente = anterior;   // Revertir el enlace
                anterior = actual;             // Avanzar anterior
                actual = siguiente;            // Avanzar actual
            }

            cabeza = anterior; // Nueva cabeza es el último nodo original
        }

        // Paso 5: Mostrar los elementos de la lista
        public void Mostrar()
        {
            Nodo? actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.valor + " → ");
                actual = actual.siguiente;
            }
            Console.WriteLine("null");
        }
    }
}