// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("Task1 !");
    Console.Write("s= ");
    string? str = Console.ReadLine();
    double s = 0;
    if (str != null) s = float.Parse(str);
    double r = Math.Sqrt(s / double.Pi);
    Console.WriteLine("r=" + r);
}

static void task2()
{
    Console.WriteLine("Task2 !");
    Console.Write("Введiть тризначне число: ");
    int number = int.Parse(Console.ReadLine());

    if (number >= 100 && number <= 999)
    {
        int first = number / 100;
        int second = (number / 10) % 10;

        if (first > second)
        {
            Console.WriteLine($"Перша цифра {first} бiльша за другу цифру {second}.");
        }
        else if (second > first)
        {
            Console.WriteLine($"Друга цифра {second} бiльша за першу цифру {first}.");
        }
        else
        {
            Console.WriteLine("Перша  i друга цифри рiвнi.");
        }
    }
    else
    {
        Console.WriteLine("Введене число не є тризначним.");
    }
}

static void task3() { 

    Console.WriteLine("Task3 !");
    Console.Write("x = ");
    float x = float.Parse(Console.ReadLine());
    Console.Write("y = ");
    float y = float.Parse(Console.ReadLine());

    if (y > -23 && x < 0 && y < x)
    {
        Console.WriteLine("Так"); // Всередині
    }
    else if (y < -23 || x > 0 || y > x)
    {
        Console.WriteLine("Нi"); // Поза
    }
    else
    {
        Console.WriteLine("На межi"); 
    }

}

static void task4()
{
    Console.WriteLine("Task4 !");

    Console.Write("Введiть рiк: ");
    int year = int.Parse(Console.ReadLine());

    // Визначте номер циклу
    int Number = (year - 4) % 12;

    string Animal = "";
    switch (Number)
    {
        case 0:
            Animal = "Щур";
            break;
        case 1:
            Animal = "Бик";
            break;
        case 2:
            Animal = "Тигр";
            break;
        case 3:
            Animal = "Кролик";
            break;
        case 4:
            Animal  = "Дракон";
            break;
        case 5:
            Animal = "Змiя";
            break;
        case 6:
            Animal = "Кiнь";
            break;
        case 7:
            Animal = "Вiвця";
            break;
        case 8:
            Animal = "Мавпа";
            break;
        case 9:
            Animal = "Пiвень";
            break;
        case 10:
            Animal = "Собака";
            break;
        case 11:
            Animal = "Свиня";
            break;
    }

    Console.WriteLine($"Тварина, що символiзує {year} рiк за схiдним календарем: {Animal}");
}

static void task5()
{
    Console.WriteLine("Task5 !");
    Console.Write("x = ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("y = ");
    double y = double.Parse(Console.ReadLine());

    double difference=x-y;
    double sdifference=difference*difference;
    Console.WriteLine($"Рiзниця двох дiйсних чиселу квадратi: {sdifference}");
}

static void task6()
{
    Console.WriteLine("Task6 !");
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());

    double x = (1 / (a * a) + a * b + 1) - (1 / (b * b) + a * b + 1);
    Console.WriteLine($"Значення виразу: {x}") ;
}

task1();
task2();
task3();
task4();
task5();
task6();

