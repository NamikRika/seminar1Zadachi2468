// // Урок 1. Знакомство с языком программирования С#
// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// int pervoyeChislo = 0; // Obyavlayem peremenniye 
// int vtoroyeChislo = 0; 

// Console.Write("Задача 2: \n Напишите программу, которая на вход принимает два числа \n и выдаёт, какое число большее, а какое меньшее.");

// Console.Write("\n"); // "для создание оступов между строками"
// Console.Write("\n");

// Console.Write("Решение:");

// Console.Write("\n");// "для создание оступов между строками"
// Console.Write("\n");

// Console.Write("Задайте первое число ");
// pervoyeChislo = Convert.ToInt32(Console.ReadLine()); // "Принимаем данные от пользователя"
// Console.Write("Задайте второе число ");
// vtoroyeChislo = Convert.ToInt32(Console.ReadLine());

// Console.Write("\n");

//      if(pervoyeChislo > vtoroyeChislo) // "начало условия"
//          {
//              Console.Write("Из заданных данных " + pervoyeChislo  + " являеется большим числом а "+ vtoroyeChislo + " меньшим числом  ");
//          }
//          else
//          {
//              Console.Write("Из заданных данных " + vtoroyeChislo  + " являеется большим числом а " + pervoyeChislo  + " меньшим числом  ");
//          }   // "конец условия"

// // задача 2 завершена. ------------------------------------------------------------------------



// // Начало задачи 4

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// int pervoyeChislo = 0; // Obyavlayem peremenniye 
// int vtoroyeChislo = 0; 
// int tretyeChislo = 0; 

// Console.Write("Задача 4: \n Напишите программу, которая на вход принимает три числа \n и выдаёт, максимальное из этих чисел.");

// Console.Write("\n"); // "для создание оступов между строками"
// Console.Write("\n");

// Console.Write("Решение:");

// Console.Write("\n");// "для создание оступов между строками"
// Console.Write("\n");

// Console.Write("Задайте первое число ");
// pervoyeChislo = Convert.ToInt32(Console.ReadLine()); // "Принимаем данные от пользователя"
// Console.Write("Задайте второе число ");
// vtoroyeChislo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте третье число ");
// tretyeChislo = Convert.ToInt32(Console.ReadLine());

// Console.Write("\n");

//      if (pervoyeChislo > vtoroyeChislo && pervoyeChislo > tretyeChislo) // "начало условия"
//            {
//                Console.Write("Из чисел " + pervoyeChislo  + ", " + vtoroyeChislo + ", " +  tretyeChislo + ", " + " максимальным является " +  pervoyeChislo);
//            }
//          else if (vtoroyeChislo > pervoyeChislo && vtoroyeChislo > tretyeChislo)
//            {
//                 Console.Write("Из чисел " + pervoyeChislo  + ", " + vtoroyeChislo + ", " +  tretyeChislo + ", " + " максимальным является " + vtoroyeChislo);
//            }   
//          else if (tretyeChislo > pervoyeChislo && tretyeChislo > vtoroyeChislo)
//            {
//                 Console.Write("Из чисел " + pervoyeChislo  + ", " + vtoroyeChislo + ", " +  tretyeChislo + ", " + " максимальным является " + tretyeChislo);
//            }   // "конец условия"

// // задача 4 завершена. ------------------------------------------------------------------------


// // Начало задачи 6

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// int vvedennoyeChislo = 0; // Obyavlayem peremenniye 
// int rezultatDeleniya = 0;

// Console.Write("Задача 6: \n Напишите программу, которая на вход принимает число \n и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

// Console.Write("\n"); // "для создание оступов между строками"
// Console.Write("\n");

// Console.Write("Решение:");

// Console.Write("\n");// "для создание оступов между строками"
// Console.Write("\n");

// Console.Write("Задайте любое число ");
// vvedennoyeChislo = Convert.ToInt32(Console.ReadLine()); // "Принимаем данные от пользователя"

// rezultatDeleniya =  vvedennoyeChislo % 2 ;


//       if (rezultatDeleniya == 0) // "начало условия"
//             {
//                 Console.Write("Вы ввели чётное чмсло");
//             }
//           else
//             {
//                  Console.Write("Вы ввели нечётное чмсло");
//             }   // "конец условия"



// // задача 6 завершена. ------------------------------------------------------------------------


// // Начало задачи 8

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// int chisloN = 0; // Obyavlayem peremenniye 
// int i = 0; // Peremennaya schetchik cikla
// int rezultatDeleniya = 0;
// string rezultatZadachi = "";

// Console.Write("Задача 6: \n Напишите программу, которая на вход принимает число (N) \n а на выходе показывает все чётные числа от 1 до N.");

// Console.Write("\n"); // "для создание оступов между строками"
// Console.Write("\n");

// Console.Write("Решение:");

// Console.Write("\n");// "для создание оступов между строками"
// Console.Write("\n");

// Console.Write("Задайте любое число ");
// chisloN = Convert.ToInt32(Console.ReadLine()); // "Принимаем данные от пользователя"

// for (i = 1; i < chisloN + 1; i++) // "начало цикла"
// {
//     rezultatDeleniya =  i % 2 ;
//     if( rezultatDeleniya == 0) // "начало условия"  / здесь проверяем чётное ли число
//     {
//         rezultatZadachi = rezultatZadachi + i.ToString() + ", " ; // здесь присваиваем значение переменной в случае четности числа
//     }
//     else
//     {
        
//     }                                         // "конец условия"


// }                                            // "конец цикла"

// Console.Write(rezultatZadachi);

// // задача 8 завершена. ------------------------------------------------------------------------