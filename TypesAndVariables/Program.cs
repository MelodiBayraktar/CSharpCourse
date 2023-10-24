namespace TypesAndVariables;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
    
        int number1 = 2147483647;
        Console.WriteLine("Number1 is {0}", number1);

        long number2 = 9223372036854775807;
        Console.WriteLine("Number2 is {0}", number2);

        short number3 = 32767;
        Console.WriteLine("Number3 is {0}", number3);

        byte number4 = 255;
        Console.WriteLine("Number4 is {0}", number4);

        double number5 = 10.4;
        Console.WriteLine("Number5 is {0}", number5);

        decimal number6 = 10.4m;
        Console.WriteLine("Number6 is {0}", number6);

        var number7 = 10;
        number7 = 'A';
        //number7= "A";
        Console.WriteLine("Number7 is {0}", number7);

        bool condition = false;

        char character = 'A';
        Console.WriteLine("Character is : {0}", (int)character);

        Console.WriteLine((int)Days.Friday);

        Console.ReadLine();
    }
}
enum Days
{
    Monday = 1, Tuesday, Wednesday, Friday, Saturday, Sunday
}

