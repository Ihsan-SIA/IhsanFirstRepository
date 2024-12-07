using Methods_practice;

internal class Program
{
    int aSpeed;
    private static void Main(string[] args)
    {
        //static void
        JobMethod("Ihsan", "Google");
        //void but not static
        Program theFreshher = new Program();
        //void but not static
        theFreshher.MatricNews("Mr", "Ajanlekoko");
        //static but not void
        //Console.Write("Enter Garnacho new age here: ");
        //string garnaBirthday = BirthdayWish("Garnacho", "Man U", int.Parse(Console.ReadLine()!));
        //Console.WriteLine(garnaBirthday);

        //static but not void
        BirthdayWish("Amad", "Man Utd", 18);
        //not static not void
        Program someoneSalary = new Program();
        someoneSalary.aSpeed = 50;
        string taxPerson = someoneSalary.ASalary(600000, 57000);
        Console.WriteLine(taxPerson);
        //not static void with field
        Program personInCountry = new Program();
        personInCountry.noPeople = 13;
        personInCountry.theirCountry = "Austria";
        personInCountry.ACountry("Nigeria");
        //not static void
        Program myInstitution = new Program();
        myInstitution.ASchool("University of Lagos", "Marine biology");
        //static void
        CongratsMessage("Man", "Club");
        //static not void
        Console.Write("The area of the size of the class is = ");
        double theClass = RectangleArea(3, 2.5);
        Console.WriteLine(theClass);
        Program pyramid = new Program();
        pyramid.triBase = 3;
        pyramid.triHeight = 4;
        pyramid.TriangleArea();
        CircleArea(21);
        string greeting = "Hello world, hello once again!";
        //Console.WriteLine(greeting.IndexOf("h".ToUpper()));
        //GetVowelPositions.VowelPosition("abeyi");
        Console.WriteLine("Get vowel position method\n");
        GetVowelPositions.VowelPosition("Sheriffdeen Saula");
         Console.WriteLine(']');

        GetVowelPositions.VowelPosition2("Sheriffdeen Saula");
    }
    int triBase;
    int triHeight;
    int radiusCircle;
    static void CircleArea(int radiusCirc)
    {
        Console.WriteLine(2 * Math.PI * radiusCirc);
    }
    void TriangleArea()
    {
        Console.WriteLine((double)1 / 2 * triBase * triHeight);
    }
    static void JobMethod(string personName, string companyName)
    {
        Console.WriteLine($"{personName} just got a job at {companyName}");
    }
    string ASalary(int grossIncome, int netIncome)
    {
        return $"The taxes on my salary in total are {(grossIncome - netIncome)}. I am at {aSpeed} rn";
    }
    int noPeople;
    string? theirCountry;
    void ACountry(string country = "South Africa")
    {
        Console.WriteLine($"I am from {country}, not {theirCountry} and I do not know any {noPeople} people in {theirCountry}. I am just from {country}");
        static void sOs(string amountGot)
        {
            Console.WriteLine($"I gat {amountGot} they could last me the next 2 weeks");
        }
    }
    void ASchool(string schoolName, string courseName)
    {
        Console.WriteLine($"The name of my school is {schoolName}, and I am studying {courseName}");
    }
    static string GetVowelPosition(string aStringS)
    {
        return aStringS;
    }
    void MatricNews(string initials, string fresherName)
    {
        Console.WriteLine($"Congrats on your matric {initials}. {fresherName}");
    }
    static string BirthdayWish(string celebrantName, string clubName, int currentAge)
    {
        return $"Happy birthday to {celebrantName}, who has just clocked {currentAge}. From all of us at {clubName}";
    }
    static void CongratsMessage(string playerName, string playerClub)
    {
        Console.WriteLine($"Congratulations to {playerName} and {playerClub} on winning the balon D'or!");
    }
    static double RectangleArea(double theBase, double height)
    {
        double areaOfRec = theBase * height;
        return areaOfRec;
    }
}