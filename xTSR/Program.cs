internal class Program
{

    /***
     *                                              
     *     (  (        )     )  (           )       
     *     )\))(   '( /(  ( /(( )\     ) ( /( (     
     *    ((_)()\ ) )\()) )\())((_) ( /( )\()))\ )  
     *    _(())\_)(|(_)\ ((_)((_)_  )(_)|(_)\(()/(  
     *    \ \((_)/ / |(_)__ (_) _ )((_)_| |(_))(_)) 
     *     \ \/\/ /| ' \ |_ \ | _ \/ _` | '_ \ || | 
     *      \_/\_/ |_||_|___/ |___/\__,_|_.__/\_, | 
     *                                        |__/  
     * GH: https://github.com/Wh3Baby
     * TG: https://t.me/WH3BABY
     */

    /*              Условия задания 
     *            +  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
                    a = 5; b = 7 -> max = 7
                    a = 2 b = 10 -> max = 10
                    a = -9 b = -3 -> max = -3

                  +  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
                    2, 3, 7 -> 7
                    44 5 78 -> 78
                    22 3 9 -> 22

                  +  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
                    4 -> да
                    -3 -> нет
                    7 -> нет

                    Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
                    5 -> 2, 4
                    8 -> 2, 4, 6, 8
    

    
     */
    static void Task1()
    {
        // -> User input
        Console.WriteLine("Введите два числа\nВторое число с новой строки: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        // -> Check user input staf
        if (x > y)
        {
            // -> Output stuff
            Console.WriteLine("Число: " + x + " больше числа: " + y);
        }
        else { Console.WriteLine("Число: " + y + " больше числа: " + x); }

    }
    static void Task2()
    {
        // Можно было бы через switch case.... 
        // -> User input
        Console.WriteLine("Введите 3 числа\nВторое и следующие число с новой строки: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());
        // -> Check user input
        if (x > y & x > z)
        {
            // -> Output stuff
            Console.WriteLine("Число: " + x + " больше числа: " + y + " и больше числа: " + z);
        }
        else if (y > x & y > z)
        {
            // -> Output stuff
            Console.WriteLine("Число: " + y + " больше числа: " + x + " и больше числа: " + z);
        }
        else if (z > x & z > y)
        {
            // -> Output stuff
            Console.WriteLine("Число: " + z + " больше числа: " + x + " и больше числа: " + y);
        }
        else { Console.WriteLine("У нас технические шоколадки..."); }
    }
    static void Task3()
    {
        // -> User input
        Console.WriteLine("Введите число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        // validate ..
        if (x % 2 == 0)
        {
            Console.WriteLine("Число: " + x + " ЧЕТНОЕ");
        }
        else { Console.WriteLine("Число: " + x + " НЕ ЧЕТНОЕ"); }

    }
    static void Task4()
    {
        // -> User input
        Console.WriteLine("Введите число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        // magic.
        for (int i = 0; i <= x; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    private static void Main(string[] args)
    {
        Console.Write("Hello Dear Teacher! This my homework on C[#]!\nEnjoy");
        Console.WriteLine("Chouse task [1-4]: ");
        string chouse = Console.ReadLine();
        switch (chouse)
        {
            case "1":
                Task1();
                break;
            case "2":
                Task2();
                break;
            case "3":
                Task3();
                break;
            case "4":
                Task4();
                break;

        }
    }
}