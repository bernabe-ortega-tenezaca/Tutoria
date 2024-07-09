// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

// Definir una pila de cadenas
Stack<string> materias = new Stack<string>();
// Otra forma de crear una pila
var otraPila = new Stack<string>();

System.Console.WriteLine("Ingres una materia");
string materia = Console.ReadLine();

materias.Push(materia);
materias.Push("Quimica");
materias.Push("Física");

