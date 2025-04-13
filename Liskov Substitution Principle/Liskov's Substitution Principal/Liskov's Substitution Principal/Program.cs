public class Rectangle
{
    public virtual int Height { get; set; }
    public virtual int Width {  get; set; }
    public int Area()
    {
        return this.Width * this.Height;
    }
}

public class Square : Rectangle
{
    public override int Height { set { base.Height = base.Width = value; } }
    public override int Width { set { base.Height = base.Width = value; } }
    public int Area()
    {
        return this.Width * this.Height;
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        Rectangle rect = new Square();
        rect.Height = 20;
        Console.WriteLine(rect.Area());
    }
}