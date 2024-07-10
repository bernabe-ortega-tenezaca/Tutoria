// See https://aka.ms/new-console-template for more information
using System.Collections;

// Definición de las torres
Stack<string> TorreA = new Stack<string>();
Stack<string> TorreB = new Stack<string>();
Stack<string> TorreC = new Stack<string>();

TorreA.Push("ficha"); 
System.Console.WriteLine("Torre A"); imprimirPila(TorreA);
System.Console.WriteLine("Torre B"); imprimirPila(TorreB);
System.Console.WriteLine("Torre C"); imprimirPila(TorreC);

TorreC.Push(TorreA.Pop());
//moverFicha(TorreA, TorreC);
System.Console.WriteLine("Torre A"); imprimirPila(TorreA);
System.Console.WriteLine("Torre B"); imprimirPila(TorreB);
System.Console.WriteLine("Torre C"); imprimirPila(TorreC);

static void moverFicha(Stack<string> torreOrigen, Stack<string> torreDestino){
    torreDestino.Push(torreOrigen.Pop());
}





// imprimirPila(TorreA);
// imprimirPila(TorreB);
// imprimirPila(TorreC);
// System.Console.WriteLine("********************************");
// TorreB.Push(TorreA.Pop()); //la ficha pasa desde la torre A hasta la torre B

// imprimirPila(TorreA);
// imprimirPila(TorreB);
// imprimirPila(TorreC);

// TorreC.Push(TorreB.Pop()); // la ficha pasa desde la torre B hasta la torre C
// System.Console.WriteLine("********************************");
// imprimirPila(TorreA);
// imprimirPila(TorreB);
// imprimirPila(TorreC);
// System.Console.WriteLine("********************************");
// TorreA.Push(TorreC.Pop()); // la ficha pasa de la torre C hasta la B
// System.Console.WriteLine("********************************");
// imprimirPila(TorreA);
// imprimirPila(TorreB);
// imprimirPila(TorreC);
// System.Console.WriteLine("********************************");

// Stack<string> transportesAereos = new Stack<string>();
// Stack<string> transportesTerrestres = new Stack<string>();

// transportesAereos.Push("avión");
// transportesAereos.Push("avioneta");
// transportesAereos.Push("jet");
// transportesAereos.Push("automovil");

// transportesTerrestres.Push("patineta");
// transportesTerrestres.Push("bicicleta");
// transportesTerrestres.Push("moto");

// System.Console.WriteLine("Transportes aereos");
// imprimirPila(transportesAereos);
// System.Console.WriteLine();
// System.Console.WriteLine("Transportes terrestes:");
// imprimirPila(transportesTerrestres);

// string temporal =  transportesAereos.Pop();
// transportesTerrestres.Push(temporal);

// transportesAereos.Push(transportesTerrestres.Pop());

// Console.ReadLine();

// System.Console.WriteLine("Transportes aereos");
// imprimirPila(transportesAereos);
// System.Console.WriteLine();
// System.Console.WriteLine("Transportes terrestes:");
// imprimirPila(transportesTerrestres);





// Console.WriteLine("Hello, World!");

// // Definir una pila de cadenas
// Stack<string> materias = new Stack<string>();
// // Otra forma de crear una pila
// var otraPila = new Stack<string>();

// //Agregar datos a la pila
// materias.Push("Matemáticas"); // Matemáticas se va al fondo
// materias.Push("Química"); 
// materias.Push("Física"); // Fisica será el top de los elementos

// // Recorre la pila y la imprime
// // foreach (var item in materias){
// //     System.Console.WriteLine(item);
// // }
// //imprimirPila(materias);

// // pila con lectura de datos
// for(int i =1; i<=5; i++){
//     System.Console.Write("Ingrese un nombre: ");
//     otraPila.Push(Console.ReadLine());
// }

// imprimirPila(otraPila);
// otraPila.Pop(); //Elimina el elemento superior
// imprimirPila(otraPila);

// string borrado =  otraPila.Pop(); //capturo el dato borrado
// System.Console.WriteLine("ha borrado: " + borrado);
// imprimirPila(otraPila);


static void imprimirPila(Stack<string> pila){
    System.Console.WriteLine("**************************");
    foreach (var item in pila){
        System.Console.WriteLine(item);
    }
    System.Console.WriteLine("**************************");
    System.Console.WriteLine();
}
// System.Console.WriteLine("Pilas originales");
// imprimirPila(materias);
// imprimirPila(otraPila);

// //otraPila.Push(materias.Pop());
// //Remover de una pila y poner en otra
// string temporal = materias.Pop(); //capturo el elemento que he borrado
// otraPila.Push(temporal);

// Console.ReadLine();
// System.Console.WriteLine("Pilas modificadas");
// imprimirPila(materias);
// imprimirPila(otraPila);
