// Домашнее задание к второму семинару.

//_________________________________________Задание  2.1 _________________________________
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int BackSecond (int inputN)
//     {
//     int output = inputN % 100 ;  // отсекаем сотни
//     output = output/ 10;        // отсекаем единицы
//     return output;
//     }
// Console.Write ("Введите обрабатываемое трехзначное целое число - " );
// int num=Convert.ToInt32(Console.ReadLine());
// num = BackSecond (num);
// Console.WriteLine ($"Результат обработки - {num}");


//_________________________________________Задание  2.2 _________________________________
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int BackThree (int inputN)
//     {
//        int del=100;
//        if (inputN/del!=0)  // проверяем минимальную разрядность введенного числа
//             {   
//                 int razr = 2;
//                 while (inputN/Convert.ToInt32(Math.Pow(10,(razr)))!=0)  // определяем разрядность числа
//                     {
//                         razr++;
//                     }
//                 return Convert.ToInt32(inputN % Convert.ToInt32(Math.Pow(10,(razr-2)))/Convert.ToInt32(Math.Pow(10,(razr-3)))); 
//                 // выделяем нужный разряд
//             }
//         else return -1;     // возвращяем -1 при отсутствии нужной разрядности
//     }
// Console.Write ("Введите обрабатываемое  число - " );
// int num=Convert.ToInt32(Console.ReadLine());
// num = BackThree (num);
// if (num!=-1) Console.WriteLine ($"Результат обработки - {num}");
// else Console.WriteLine($"Число не удовлетворяет параметрам обработки");




//_________________________________________Задание  2.2 _________________________________
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Ввожим в функцию доп параметр для вывода нужного разряд

int BackThree (int inputN, int numPP)
    {
       int del=Convert.ToInt32(Math.Pow(10,(numPP-1)));

       if (inputN/del!=0)  // проверяем минимальную разрядность введенного числа
            {   
                int razr = numPP;
                while (inputN/Convert.ToInt32(Math.Pow(10,(razr)))!=0)  // определяем разрядность числа
                    {
                        razr++;
                    }
                return Convert.ToInt32(inputN % Convert.ToInt32(Math.Pow(10,(razr-(numPP-1))))/Convert.ToInt32(Math.Pow(10,(razr-numPP)))); 
                // выделяем нужный разряд
            }
        else return -1;     // возвращяем -1 при отсутствии нужной разрядности
    }
Console.Write ("Введите обрабатываемое  число - " );
int num=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите номер выводимого разряда  число - " );
int numR=Convert.ToInt32(Console.ReadLine());
num = BackThree (num,numR);
if (num!=-1) Console.WriteLine ($"Обработка вывода разряда {numR}  осуществлена- {num}");
else Console.WriteLine($"Число не удовлетворяет параметрам обработки");

//_________________________________________Задание  2.3 _________________________________
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool CheckDay (int day)
//     {
//         if (day<6) return true;
//         else return false;
//     }
// Console.Write ("Введите день недли от 1 до 7 - ");
// int nday = Convert.ToInt32 (Console.ReadLine());
// if (nday>0 && nday<8)                       // Проверка корректности ввода
//     {
//         bool flag = CheckDay(nday);
//         if (flag) Console.WriteLine ("Введенный день рабочий ");
//         else Console.WriteLine ("Введенный день выходной");
//     }
// else Console.WriteLine ("Введеные данные не соответствуют обраатываемым параметрам");