namespace Strings;

class Program
{
    static void Main(string[] args)
    {
        //Intro();
        string sentence = "My name is Engin Demiroğ";
        var result = sentence.Length;
        Console.WriteLine(result);

        var result2 = sentence.Clone();
        sentence = "My name is Derin Demiroğ";
        Console.WriteLine(result2);

        bool result3 =  sentence.EndsWith("ğ");
        bool result4 = sentence.StartsWith("ğ");

        var result5 = sentence.IndexOf("namee");
        Console.WriteLine(result5);

        var result6 = sentence.IndexOf(" ");
        Console.WriteLine(result6);

        var result7 = sentence.LastIndexOf(" ");
        Console.WriteLine(result7);

        var result8 = sentence.Insert(0, "Hello ");
        Console.WriteLine(result8);

        var result9 = sentence.Substring(3,4);
        Console.WriteLine(result9);

        var result10 = sentence.ToLower();
        Console.WriteLine(result10);

        var result11 = sentence.ToUpper();
        Console.WriteLine(result11);

        var result12 = sentence.Replace(" ", "-");
        Console.WriteLine(result12);

        var result13 = sentence.Remove(2, 5);
        Console.WriteLine(result13);

        Console.ReadLine();
    }
    private static void Intro()
    {
        string city = "Ankara";
        //Console.WriteLine(city[0]);
        foreach (var i in city)
        {
            Console.WriteLine(i);
        }

        string city2 = "İstanbul";
        string result = city + city2;
        Console.WriteLine(result);

        Console.WriteLine(String.Format("{0} {1}", city, city2));
    }
}

