////PROGRAMA 1
//try
//{
//    int numero, opcion;

//do
//{
//    numero = 0;
//    opcion = 0;

//    Console.Clear();
//    Console.WriteLine("Ingrese un numero entero: ");
//    numero = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("\nMENU DE OPCIONES");
//    Console.WriteLine("1). Calular el factorial del numero.");
//    Console.WriteLine("2). Calular la raiz cuadrada del numero.");
//    Console.WriteLine("3). Salir del programa.");
//    Console.WriteLine("\nElija una opcion: ");
//    opcion = Convert.ToInt32(Console.ReadLine());

//    switch (opcion)
//    {
//        case 1:
//            int factorial = 1;

//            for (int i = 1; i <= numero; i++)
//            {
//                factorial *= i;
//            }

//            Console.WriteLine($"El factorial de {numero} es: {factorial}\n");
//            break;

//        case 2:
//            double raiz = Math.Sqrt(numero);
//            Console.WriteLine($"La raiz cuadrada de {numero} es: {raiz}\n");
//            break;

//        case 3:
//            Console.WriteLine("Saliendo del programa.");
//            Environment.Exit(0);
//            break;

//        default:
//            Console.WriteLine("Opcion invalida.");
//            break;
//    }

//    Console.WriteLine("Presione cualquier tecla para continuar.");
//    Console.ReadKey();

//} while (opcion != 3);
//}
//catch (Exception error)
//{
//    Console.WriteLine("Ha ocurrido un error: " + error.Message);
//}



//PROGRAMA 2
//try
//{
//    double n1, n2, resultado;
//    char operador;

//    Console.WriteLine("Ingrese el primer numero:");
//    n1 = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine("Ingrese el segundo numero:");
//    n2 = Convert.ToDouble(Console.ReadLine());

//    if (n1 % 1 == 0 && n2 % 1 == 0)
//    {
//        Console.WriteLine("Ingrese un operador (+, -, *, /):");
//        operador = Convert.ToChar(Console.ReadLine());

//        switch (operador)
//        {
//            case '+':
//                resultado = n1 + n2;
//                Console.WriteLine($"\nEl resultado de la suma es: {resultado}");
//                break;

//            case '-':
//                resultado = n1 - n2;
//                Console.WriteLine($"\nEl resultado de la resta es: {resultado}");
//                break;

//            case '*':
//                resultado = n1 * n2;
//                Console.WriteLine($"\nEl resultado de la multiplicacion es: {resultado}");
//                break;

//            case '/':
//                resultado = n1 / n2;
//                Console.WriteLine($"\nEl resultado de la division es: {resultado}");
//                break;

//            default:
//                Console.WriteLine("El operador ingresado no es valido.");
//                break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Los numeros ingresados no son enteros.");
//    }
//}
//catch (Exception error)
//{
//    Console.WriteLine("Ha ocurrido un error: " + error.Message);
//}



////PROGRAMA 3
//try
//{
//    double num;

//    Console.WriteLine("Ingrese un numero:");
//    num = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine($"\nTabla de multiplicar del {num}:\n");

//    for (int i = 1; i <= 10; i++)
//    {
//        double mult = num * i;
//        Console.WriteLine($"\t{i} x {num} = {mult}");
//    }
//}
//catch (Exception error)
//{
//    Console.WriteLine("Ha ocurrido un error: " + error.Message);
//}



//PROGRAMA 4
try
{
    Random random = new Random();
    int numAleatorio = random.Next(1, 101);
    int num;

    Console.WriteLine("Adivinar numero secreto del 1 al 100\n");

    do
    {
        Console.WriteLine("Ingrese un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (numAleatorio > num)
        {
            Console.WriteLine("El numero secreto es mayor.\n");
        }
        else if (numAleatorio < num)
        {
            Console.WriteLine("El numero secreto es menor.\n");
        }

    } while (num != numAleatorio);

    Console.WriteLine("\n¡FELICIDADES, HA ADIVINADO EL NUMERO SECRETO!");
}
catch (Exception error)
{
    Console.WriteLine("Ha ocurrido un error: " + error.Message);
}