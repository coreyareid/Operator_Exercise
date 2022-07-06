// Exercise 1

static  void Mathmatics()
{
    Console.WriteLine("Put in two numbers to get equations for math operators: " +
        "addition, " +
        "subtraction, " +
        "multiplication, " +
        "division, " +
        "and the remainder.");
    int x = Convert.ToInt32(Console.ReadLine());
     int y = Convert.ToInt32(Console.ReadLine());
    int remainder = x % y;
    int division = x / y;
    int addition = x + y;
    int subtraction = x - y;
    int multiplication = x * y;

    Console.WriteLine($" {x} + {y} is {addition}");
    Console.WriteLine($" {x} - {y} is {subtraction}");
    Console.WriteLine($" {x} * {y} is {multiplication}");
    Console.WriteLine($" {x} / {y} is {division} with a remainder of {remainder}");
}

Mathmatics();

//Exercise 2

static void AreaOfCircle()
{
    Console.WriteLine("\n\n Input the radius of a circle to get the area.");
    double radius = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine($"The area of a circle with a radius of: {radius}" + " is " + area);
}

AreaOfCircle();