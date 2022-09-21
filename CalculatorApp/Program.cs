float x, y, z;
string num1, num2;
string menu;
int menuUI;

do
{
    Console.WriteLine("=======================================");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить 2 числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент из числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    Console.WriteLine("=======================================");

    menu = Console.ReadLine();
    menuUI = Convert.ToInt32(menu);

    if (menuUI == 1)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        x = Convert.ToSingle(num1);
        y = Convert.ToSingle(num2);

        Console.WriteLine("Сумма равна " + (x + y));
    }
    if (menuUI == 2)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        x = Convert.ToSingle(num1);
        y = Convert.ToSingle(num2);

        Console.WriteLine("Разность равна " + (x - y));
    }
    if (menuUI == 3)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        x = Convert.ToSingle(num1);
        y = Convert.ToSingle(num2);

        Console.WriteLine("Произведение равно " + (x * y));
    }
    if (menuUI == 4)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        x = Convert.ToSingle(num1);
        y = Convert.ToSingle(num2);

        Console.WriteLine("Частное равно " + (x / y));
    }
    if (menuUI == 5)
    {
        Console.WriteLine("Введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        x = Convert.ToSingle(num1);
        y = Convert.ToSingle(num2);

        Console.WriteLine("X в степени y равен " + (Math.Pow(x, y)));
    }
    if (menuUI == 6)
    {
        Console.WriteLine("Введите число");

        num1 = Console.ReadLine();
        x = Convert.ToSingle(num1);

        Console.WriteLine("Квадратный корень от числа - " + Math.Sqrt(x));

    }
    if (menuUI == 7)
    {
        Console.WriteLine("Введите число");

        num1 = Console.ReadLine();
        x = Convert.ToSingle(num1);

        Console.WriteLine("1% От числа - " + (x / 100));

    }
    if (menuUI == 8)
    {
        Console.WriteLine("Введите целое число");
        num1 = Console.ReadLine();
        x = Convert.ToInt32(num1);
        z = 1;

        for (int i = 1; i < x + 1; i++)
        {
            z = z * i;
        }
        Console.WriteLine("Факториал равен" + z);
    }
    Console.ReadKey();
    Console.Clear();
} while (menuUI != 9);