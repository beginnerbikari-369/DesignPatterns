using static DesignPatterns.Product;

namespace DesignPatterns
{
    public enum Color
    {
        Red, Green, Blue
    }
    public enum Size
    {
        Small, Medium, Large, Huge
    }
    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Product(string Name, Color color, Size size)
        {
            this.Name = Name;
            Color = color;
            Size = size;
        }
        public class ProductFilter
        {
            public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
            {
                foreach (var product in products)
                {
                    if (product.Size == size) yield return product;
                }
            }

            public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
            {
                foreach (var product in products)
                {
                    if (product.Color == color) yield return product;
                }
            }

            public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
            {
                foreach (var product in products)
                {
                    if (product.Color.Equals(color) && product.Size.Equals(size)) yield return product;
                }
            }
        }
    }
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }

    public class ColorSpecification : ISpecification<Product>
    {
        public Color color;
        public ColorSpecification(Color colorSpecification)
        {
            color = colorSpecification;
        }
        public bool IsSatisfied(Product product)
        {
            return product.Color.Equals(color);
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        public Size size;
        public SizeSpecification(Size sizeSpecification)
        {
            this.size = sizeSpecification;
        }
        public bool IsSatisfied(Product product)
        {
            return product.Size.Equals(size);
        }
    }

    public class AndSpecification : ISpecification<Product>
    {
        public Size size;
        public Color color;
        public AndSpecification(Size sizeSpecification, Color colorSpecification)
        {
            this.size = sizeSpecification;
            this.color = colorSpecification;
        }
        public bool IsSatisfied(Product product)
        {
            return product.Size.Equals(size) && product.Color.Equals(color);
        }
    }
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach (Product product in items)
            {
                if (specification.IsSatisfied(product)) yield return product;
            }
        }
    }
    //public class Demo
    //{
    //    static void Main(string[] args)
    //    {
    //        var apple = new Product("Apple", Color.Red, Size.Small);
    //        var tree = new Product("Tree", Color.Green, Size.Large);
    //        var house = new Product("House", Color.Blue, Size.Huge);
    //        Product[] products = { apple, tree, house };
    //        var pf = new ProductFilter();
    //        Console.WriteLine("Green Products (old):");
    //        foreach (var product in pf.FilterBySize(products, Size.Small))
    //        {
    //            Console.WriteLine(product.Name);
    //        }
    //        var bf = new BetterFilter();
    //        foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
    //        {
    //            Console.WriteLine(p.Name);
    //        }
    //        Console.WriteLine("Both");
    //        foreach (var p in bf.Filter(products, new AndSpecification(Size.Large, Color.Green)))
    //        {
    //            Console.WriteLine(p.Name);
    //        }
    //    }
    //}
}
