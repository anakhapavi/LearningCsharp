using System.Drawing;
using System.Runtime.CompilerServices;

static void Main()
{
    int choice;
    do
    {
            System.Console.WriteLine("Enter your choice: ");
            System.Console.WriteLine("1. Circle");
            System.Console.WriteLine("2. Rectangle");
            System.Console.WriteLine("3. Exit");

            if(int.TryParse(Console.ReadLine(),out choice))
            {   
                 switch(choice)
                 {
                    case 1: HandleCircle();
                            break;
                    case 2: HandleRectangle();
                            break;
                    case 3: System.Console.WriteLine("GoodBye");
                            break;
                    default: System.Console.WriteLine("Invalid");
                            break;
                 }
            }
            else
            {
                System.Console.WriteLine("Invalid Choice");
            }
    }while(choice!=0);
}
static void HandleCircle()
{
    System.Console.WriteLine("Enter radius: ");
    if(double.TryParse(Console.ReadLine(),out double radius))
    {
        object shape = new Circle{Radius = radius};
        AreaPerimeter(shape);
    }
    else
    {
        System.Console.WriteLine("Invalid shape");
    }
}
static void HandleRectangle()
{
    System.Console.WriteLine("Enter Width: ");
    if(double.TryParse(Console.ReadLine(),out double width))
    {
        System.Console.WriteLine("Enter Height: ");
        if(double.TryParse(Console.ReadLine(),out double height))
        {
            object shape = new Rectangle{Width = (int)width,Height = (int)height };
            AreaPerimeter(shape);
        }
        else
        {
            System.Console.WriteLine("Invalid input for height");
        }
    }
    else
    {
        System.Console.WriteLine("Invalid input for width");
    }
}
static void AreaPerimeter(object shape)
{
    if(shape is Circle circle && circle!=null)
    {
        double circleArea = Math.PI * Math.Pow(circle.Radius,2);
        System.Console.WriteLine($"Area of circle: {circleArea}");

        double circlePerimeter = 2 * Math.PI * circle.Radius;
        System.Console.WriteLine($"Perimeter of circle: {circlePerimeter}");
    }
    else if(shape is Rectangle rectangle && rectangle!=null)
    {
        double rectArea =  rectangle.Width * rectangle.Height;
        System.Console.WriteLine($"Area of rectangle: {rectArea}");

        double rectPerimeter = 2 * (rectangle.Width + rectangle.Height);
        System.Console.WriteLine($"Perimeter of rectangle: {rectPerimeter}");
    }
    else
    {
        System.Console.WriteLine("unknown shape!");
    }
}