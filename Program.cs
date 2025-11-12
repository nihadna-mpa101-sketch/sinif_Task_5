//Task12------------------------------------------------------------
/*Point2D p1 = new Point2D(0, 0);
Point2D p2 = p1.Move(3, 4);
Console.WriteLine(p1);
Console.WriteLine(p2);
readonly struct Point2D
{
    public double X { get; }
    public double Y { get; }
    public Point2D(double x, double y)
    {
        X = x; Y = y;
    }
    public Point2D Move(double dx, double dy)
    {
        return new Point2D(X + dx, Y + dy);
    }
    public override string ToString() => $"({X}, {Y})";
}
*/
//Task13------------------------------------------------------------
/*interface IShape
{
    double Area();
    double Perimeter();
}

class Circle : IShape
{
    double radius;
    public Circle(double r) => radius = r;

    public double Area() => 3.14 * radius * radius;
    public double Perimeter() => 2 * 3.14 * radius;
}
class Rectangle : IShape
{
    double width;
    double height;
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double Area() => width * height;
    public double Perimeter() => 2 * (width + height);
}
*/
//Task14------------------------------------------------------------
//Task15------------------------------------------------------------
/*{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product(1, "Nihad", 70),
            new Product(2, "Seyid", 10),
            new Product(3, "Gulmirze", 100)
        };
        Product maxProduct = products[0];
        foreach (var product in products)
        {
            if (product.Price > maxProduct.Price)
            {
                maxProduct = product;
            }
        }
        Console.WriteLine( maxProduct.Name);
    }
}
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}*/

//Task18------------------------------------------------------------
/*class Product
{
    public string Name { get; set; }
    public int[] Grade { get; set; }

    public Product(string name, int[] grade)
    {
        Name = name;
        Grade = grade;
    }
    public double Average()
    {
        int sum = 0;
        foreach (var item in Grade)
        {
            sum += item;
        }
        return (double)sum / Grade.Length;
    }
}
class Program
{
    static void Main()
    {
        Product[] telebeler = new Product[]
        {
            new Product("Ali", new int[]{70, 80, 90}),
            new Product("Veli", new int[]{50, 60, 55}),
            new Product("Sara", new int[]{65, 75, 70})
        };

        Console.WriteLine("Ortalamasi 60-dan yuxari olan telebeler:");

        foreach (var telebe in telebeler)
        {
            if (telebe.Average() > 60)
            {
                Console.WriteLine($"{telebe.Name} - Ortalamasi: {telebe.Average():F2}");
            }
        }
    }
}*/

