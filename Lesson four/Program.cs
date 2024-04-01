using System.Linq;

namespace Lesson_four
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //HomeWork

            //ОСНОВНОЕ ЗАДАНИЕ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //1. Создайте массив целых чисел.
            //Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
            //Пусть число для поисказадается с консоли.

            //Console.WriteLine("Введите число и узнайте входит ли оно в диапозон чисел массива");
            //int number = int.Parse(Console.ReadLine());
            //int[] massArray = { 1, 2, 3, 4, 5 };
            //int counter = 0;
            //foreach (int mass in massArray)
            //{
            //    if (mass == number)
            //    {
            //        Console.WriteLine("Число входит в массив");
            //        counter++;
            //        break;
            //    }

            //}
            //if (counter == 0)
            //{
            //    Console.WriteLine("Число не входит в массив");
            //}


            //2. Создайте массив целых чисел. Удалите все вхождения заданного числа измассива.
            //Пусть число задается с консоли.Если такого числа нет -выведите сообщения об этом.
            //В результате должен быть новый массив без указанного числа.


            //Console.WriteLine("Введите число");
            //int number = int.Parse(Console.ReadLine());
            //int[] massArray = { 1, 2, 3, 4, 5,5,5,5 };

            //if(massArray.Contains(number))
            //{
            //    massArray = massArray.Except(new int[] { number }).ToArray();
            //    Console.WriteLine("Это число было удалено из массива");
            //    Console.WriteLine(String.Join(",", massArray));
            //}
            //else
            //{
            //    Console.WriteLine("Такого элемента в коллекции нет");
            //}


            //3.Создайте и заполните массив случайным числами и выведете максимальное,минимальное и среднее значение.
            //Для генерации случайного числа используйте метод Random().
            //Пусть будетвозможность создавать массив произвольного размера. Пусть размер массивавводится с консоли.


            //Console.WriteLine("Какого размера массив вы хотите создать ?");
            //int countMass = int.Parse(Console.ReadLine());
            //Console.Clear();
            //int [] massArray = new int[countMass];
            //Random rand = new Random();
            //for (int i = 0; i < countMass; i++)
            //{
            //    massArray[i] = rand.Next(0,100);
            //    Console.WriteLine(massArray[i]);
            //}

            //Console.WriteLine($"Максимальное значение {massArray.Max()}"); 
            //Console.WriteLine($"Среднее значение {massArray.Average()}");
            //Console.WriteLine($"Минимальное значение {massArray.Min()}");

            //4. Создайте 2 массива из 5 чисел.
            //Выведите массивы на консоль в двух отдельных строках.
            //Посчитайте среднее арифметическое элементов каждого массива и сообщите,
            //для какого из массивов это значение оказалось больше(либо сообщите, что их средние арифметические равны).


            //int countMass = 5;

            //int[] massArrayOne = new int[countMass];
            //int[] massArrayTwo = new int[countMass];
            //Random rand = new Random();
            //for (int i = 0; i < countMass; i++)
            //{
            //    massArrayOne[i] = rand.Next(0, 100);
            //    massArrayTwo[i] = rand.Next(0, 100);
            //}

            //Console.WriteLine($" Массив первый - {String.Join(",", massArrayOne)}");
            //Console.WriteLine($" Массив первый - {String.Join(",", massArrayTwo)}");

            //if (massArrayOne.Average() > massArrayTwo.Average())
            //{
            //    Console.WriteLine($"Среднее значение первого массива больше {massArrayOne.Average()} > {massArrayTwo.Average()}");
            //}
            //else
            //{
            //    Console.WriteLine($"Среднее значение второго массива больше {massArrayTwo.Average()} > {massArrayOne.Average()}");
            //}

            //if (massArrayOne.Average() == massArrayTwo.Average())
            //{
            //    Console.WriteLine($"Среднее значение обоих массивов равны {massArrayTwo.Average()} == {massArrayOne.Average()}");
            //}


            //ДОПОЛНИТЕЛЬНОЕ ЗАДАНИЕ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            // 4.Создайте массив из n случайных целых чисел и выведите его на экран.
            //Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
            //Если n не удовлетворяет условию - выведите сообщение об этом.
            //Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
            //Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.


            //Console.WriteLine("Какого размера массив вы хотите создать ?");
            //int countMass = 0;
            //Random random = new Random();
            //while (true)
            //{
            //    countMass = int.Parse(Console.ReadLine());
            //    if (countMass > 5 && countMass <= 10)
            //    {
            //        break;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Массив должен быть больше 5 и меньше или равен 10");

            //    }
            //}

            //int[] massOne = new int[countMass];

            //for (int i = 0; i < countMass; i++)
            //{
            //    massOne[i] = random.Next(0, 10);
            //}
            //Console.WriteLine(String.Join(",", massOne));

            //int[] massTwo = new int[massOne.Count(q => (q % 2 == 0))];

            //massTwo = massOne.Where(q=>q % 2 == 0).ToArray();

            //Console.WriteLine(String.Join(",", massTwo));



            //5. Создайте массив и заполните массив.
            //Выведите массив на экран в строку.
            //Замените каждый элемент с нечётным индексом на ноль.
            //Снова выведете массив на экран на отдельной строке.


            //int[] mass = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };

            //Console.WriteLine(String.Join(",",mass));

            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    mass[i] = 0;
            //}

            //Console.WriteLine(String.Join(",",mass));

            // 6.Создайте массив строк. Заполните его произвольными именами людей.
            //Отсортируйте массив.
            //Результат выведите на консоль.

            //string[] mass = { "Саша","Маша", "Паша", "Даша", "Яша", "Рита", "Дима", "Генадий", };

            //Console.WriteLine(String.Join(",", mass.OrderByDescending(mass => mass.Length).ToList()));


            //7.Реализуйте алгоритм сортировки пузырьком.

            //int[] mass = { 1, 2, 3, 5, 7, 84, 5, 13 };
            //int number = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    for (int j = i + 1; j < mass.Length; j++)
            //    {
            //        if (mass[i] > mass[j])
            //        {
            //            number = mass[i];
            //            mass[i] = mass[j];
            //            mass[j] = number;
            //        }
            //    }
            //}
            //Console.WriteLine(String.Join(",", mass));

            //8.Умножение двух матриц
            //Создайте два массива целых чисел размером 3х3(две матрицы).
            //Напишите программу для умножения двух матриц.
            //Первый массив: { { 1,0,0,0},{ 0,1,0,0},{ 0,0,0,0} }
            //Второй массив: { { 1,2,3},{ 1,1,1},{ 0,0,0},{ 2,1,0} }
            //Ожидаемый результат: 1 2 3 1 1 1 0 0 0

            //9. Создайте двумерный массив целых чисел. Выведите на консоль сумму всех элементов массива.

            //int[,] a = new int[3, 3] { { 1, 2, 3 }, { 0, 1, 0 }, { 0, 0, 0 } };

            //int sum = 0;

            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        sum += a[i, j];
            //    }
            //}

            //Console.WriteLine(sum);


            //10 Создайте двумерный массив. Выведите на консоль диагонали массива.

            //int[,] mass = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //int a = 0;
            //int b = 0;

            //for (int i = 0; i < mass.GetLength(0); i++)
            //{

            //    for (int j = 0; j < mass.GetLength(1); j++)
            //    {
            //        Console.Write(mass[i, j] + " ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine();

            //for (int i = 0; i < mass.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mass.GetLength(1); j++)
            //    {
            //        if (i == j || i + j == 2)
            //        {
            //            Console.Write(mass[i, j] + " ");
            //        }
            //        else
            //        {
            //            Console.Write("  "); ;
            //        }
            //    }
            //    Console.WriteLine("");

            //}


            //11.Создайте двумерный массив целых чисел. Отсортируйте элементы в строках двумерного массива по возрастанию.

            //int[,] mass = new int[3, 3] { { 2, 3, 1 }, { 6, 5, 4 }, { 9, 8, 7 } };
            //int[] sortMass = new int[3];

            //for (int i = 0; i < mass.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mass.GetLength(1); j++)
            //    {

            //        sortMass[j] = mass[i, j];
            //    }
            //    sortMass = sortMass.OrderBy(q => q).ToArray();
            //    for (int j = 0; j < mass.GetLength(1); j++)
            //    {
            //        mass[i, j] = sortMass[j];

            //       Console.Write(mass[i, j]);
            //    }
            //    Console.WriteLine();
            //}











            //Работа НА ЗАНЯТИЕ

            //1) [1,2, 32113, -324, 0 ,4] - найти все четные элементы массива и вывести их на экран

            //int[] mass = new int[] { 1, 2, 32113, -324, 0, 4 };
            //for (int i = 0;i < mass.Length;i++)
            //{
            //    if (mass[i] % 2 == 0)
            //    {
            //        Console.WriteLine(mass[i]);
            //    }
            //}


            //2)[1,2, 32113, -324, 0 ,4] - найти все элементы больше нуля элементы массива и вывести их на экран

            //int[] massTwo = new int[] { 1, 2, 32113, -324, 0, 4 };
            //for (int i = 0; i < massTwo.Length; i++)
            //{
            //    if (massTwo[i] > 0)
            //    {
            //        Console.WriteLine(massTwo[i]);
            //    }
            //}

            //3)[1,2, 32113, -324, 0 ,4] - найти сумму всех элементов

            //int[] massTwo = new int[] { 1, 2, 3, -7 };
            //int sum = 0;
            //for (int i = 0; i < massTwo.Length; i++)
            //{
            //    sum += massTwo[i];
            //}
            //Console.WriteLine(sum);

            //4) Двумерный массив

            //int[,] array = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7, 8 } };

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //   for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(" ");
            //        Console.Write(array[i, j]);
            //    }
            //   Console.WriteLine(); 
            //}

            //int[] massOne = new int[] { 1, 2, 32113, -324, 0, 4 };
            //int[] massTwo = new int[] { 6, 7, 323, -324, 8,53 };

            //var truefolse = massOne.Contains(1);
            //var sadasd = massOne.Distinct().ToList();

            //var containsNumberFive = massTwo.Except(massOne);
            //foreach (int i in containsNumberFive)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
