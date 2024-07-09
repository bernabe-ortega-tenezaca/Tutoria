// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

// Definir una pila de cadenas
Stack<string> materias = new Stack<string>();
// Otra forma de crear una pila
var otraPila = new Stack<string>();

System.Console.WriteLine("Ingres una materia");
//string materia = Console.ReadLine();

//Agregar datos a la pila
materias.Push("Matemáticas"); // Matemáticas se va al fondo
materias.Push("Química"); 
materias.Push("Física"); // Fisica será el top de los elementos
imprimirPila(materias);




static void imprimirPila(Stack<string> pila){
    foreach (var item in pila){
        System.Console.WriteLine(item);
    }
}