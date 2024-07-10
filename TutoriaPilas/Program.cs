// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

// Definir una pila de cadenas
Stack<string> materias = new Stack<string>();
// Otra forma de crear una pila
var otraPila = new Stack<string>();

//Agregar datos a la pila
materias.Push("Matemáticas"); // Matemáticas se va al fondo
materias.Push("Química"); 
materias.Push("Física"); // Fisica será el top de los elementos

// Recorre la pila y la imprime
// foreach (var item in materias){
//     System.Console.WriteLine(item);
// }
imprimirPila(materias);

// pila con lectura de datos
for(int i =1; i<=5; i++){
    System.Console.Write("Ingrese un nombre: ");
    otraPila.Push(Console.ReadLine());
}

imprimirPila(otraPila);

static void imprimirPila(Stack<string> pila){
    System.Console.WriteLine("**************************");
    foreach (var item in pila){
        System.Console.WriteLine(item);
    }
}