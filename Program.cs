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
/*public enum OrderStatus
{
    Paid,
    Pending,
    Cancelled
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine(ParseOrderStatus("paid"));
        Console.WriteLine(ParseOrderStatus("PAID"));
        Console.WriteLine(ParseOrderStatus("foo"));
    }
    public static OrderStatus? ParseOrderStatus(string input)
    {
        if (Enum.TryParse<OrderStatus>(input, ignoreCase: true, out var status))
        {
            return status;
        }
        return null;
    }
}*/
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
//Task17------------------------------------------------------------
/*class Program
{
    static void Main()
    {
        List<string> list = new List<string> { "apple", "banana", "Apricot", "avocado", "apple", "Almond", "fig" };

        var result = list
            .Distinct()
            .Where(x => x.Length >= 4)
            .Where(x => x.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            .OrderBy(x => x)
            .Select(x => x.ToUpper())
            .ToList();

        result.ForEach(Console.WriteLine);
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

//Task20--------------------------------------------------------
/*string[] gunler = { "Bazarertesi", "Cersenbeaxsami", "Cersenbe", "Cumeaxsami", "Cume", "Senbe", "Bazar" };
double[] temperatur = new double[7];
for (int i = 0; i < 7; i++)
{
    Console.Write($"{gunler[i]} ucun temperaturu daxil edin:");
    temperatur[i] = Convert.ToDouble(Console.ReadLine());
}
double toplam = 0;
for (int i = 0; i < 7; i++)
{
    toplam += temperatur[i];
}
double orta = toplam / 7;
double maxTemp = temperatur[0];
double minTemp = temperatur[0];
int maxIndex = 0;
int minIndex = 0;
for (int i = 1; i < 7; i++)
{
    if (temperatur[i] > maxTemp) { maxTemp = temperatur[i]; maxIndex = i; }
    if (temperatur[i] < minTemp) { minTemp = temperatur[i]; minIndex = i; }
}
Console.WriteLine($"\nHefte erzinde orta temperatur:{orta:F2}°C");
Console.WriteLine($"En isti gun:{gunler[maxIndex]},{maxTemp}°C");
Console.WriteLine($"En soyuq gun:{gunler[minIndex]},{minTemp}°C");
*/

