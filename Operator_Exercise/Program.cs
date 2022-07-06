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
    Console.WriteLine("Your answer for addition is: " + "{0} + {1} = {2}", x, y, x + y);
    Console.WriteLine("Your answer for subtraction is: " + "{0} - {1} = {2}", x, y, x - y);
    Console.WriteLine("Your answer for multiplication is: " + "{0} * {1} = {2}", x, y, x * y);
    Console.WriteLine("Your answer for division is: " + "{0} / {1} = {2}", x, y, x / y);
    Console.WriteLine("Your answer for the remainder of: " + "{0} devided by {1} is {2}", x, y, x % y);
    Console.WriteLine($" {x} / {y} is {division} with a remainder of {remainder}");
}

Mathmatics();

//Exercise 2

static void AreaOfCircle()
{
    Console.WriteLine("Input the radius of a circle to get the area.");
    double radius = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * radius * radius;
    Console.WriteLine($"The area of a circle with a radius of: {radius}" + " is " + area);
}

AreaOfCircle();