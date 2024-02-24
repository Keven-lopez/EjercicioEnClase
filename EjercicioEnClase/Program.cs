//int x, y=0;
//do
//{
//    Console.WriteLine("Ingrese un numero positivo");
//    x=int.Parse(Console.ReadLine());
//    if (x < 0)
//    {
//        Console.WriteLine("Numero no positivo");
//    }
//    else
//    {
//        if (x > y)
//        {
//            y = x;
//        }
//    }
//} while (x!=0);
//Console.WriteLine("El numero mayor fue: " + y);

//int x = 2;
//while (x <= 100)
//{
//    Console.WriteLine(x );
//    x = x + 2;
//}

//for (int h = 1; h < 24; h++)
//{
//    for (int m = 1; m < 60;m++)
//    {
//        for (int s = 1; s < 60;s++)
//        {
//            Console.SetCursorPosition(10, 10);
//            Console.WriteLine($"{h}:{m}:{s}");
//        }
//    }
//}
//1.1.
//for (int y = 1; y <= 10; y++)
//{
//    if (y % 2 == 0)
//    {
//        Console.WriteLine(y);
//    }
//}
//1.2. 
//int resul = 0;
//for (int x=0; x <= 10; x++)
//{
//    resul = resul + x;
//}
//Console.WriteLine(resul);
//2.1.
//int x=0, y = 0;
//do
//{
//    Console.WriteLine("Ingrese un numero positivo(ingrese un numero negativo para terminar)");
//    x = int.Parse(Console.ReadLine());
//    if (x >= 0)
//    {
//        y = x + y;
//    }
//} while (x>=0);
//Console.WriteLine("Suma de los numeros: " + y);
//2.2.
//int x = 1;
//while (true)
//{
//    if (x %7==0 && x % 11 == 0)
//    {
//        Console.WriteLine("EL primer numero entero positiov divisible entre 7 y 11 es: " + x);
//        break;
//    }
//    x++;
//}
//3.1.
//string contra = "";
//do
//{
//    Console.WriteLine("Ingrese contrasena");
//    contra=Console.ReadLine();
//    if (contra == "jutiapa")
//    {
//        Console.WriteLine("Bienvenidos, usuario.");
//        break;
//    }
//} while (true);
//3.2.
//Random random = new Random();
//int randomNumberInRange = random.Next(0, 100);
//int x = 0;
//do
//{
//    Console.WriteLine("ingrese un numero entre 0 y 100");
//    x=int.Parse(Console.ReadLine());
//    if (x > randomNumberInRange)
//    {
//        Console.WriteLine("El numero que ingresaste es mayor que el numero aleatorio.");
//    }
//    else if (x < randomNumberInRange)
//    {
//        Console.WriteLine("El numero que ingresaste es menor que el numero aleatorio.");
//    }
//    else if (x == randomNumberInRange)
//    {
//        Console.WriteLine("Es el numero correcto");
//        break;
//    }
//} while (true);