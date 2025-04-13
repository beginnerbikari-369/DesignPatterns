
using System.Reflection.Metadata;


// lets say oldfashioned printer don't use fax and scan functions we should throw some exceptions saying this won't be used valid scenario.
// it's not good to have unnecesary functions declared in implemented interface in this case we have to segregate the prime interface into smaller ones.

//public interface IMachine
//{
//    public void Print(Document d);
//    public void Scan(Document d);
//    public void Fax(Document d);
//}
//public class MultiFunctionalPrinter : IMachine
//{
//    public void Fax(Document d)
//    {
//        throw new NotImplementedException();
//    }

//    public void Print(Document d)
//    {
//        throw new NotImplementedException();
//    }

//    public void Scan(Document d)
//    {
//        throw new NotImplementedException();
//    }
//}

//public class OldFashionedPrinter : IMachine
//{
//    public void Fax(Document d)
//    {
//        throw new NotImplementedException();
//    }

//    public void Print(Document d)
//    {
//        throw new NotImplementedException();
//    }

//    public void Scan(Document d)
//    {
//        throw new NotImplementedException();
//    }
//}

//class Program
//{
//    public class Document
//    {

//    }
//    public static void Main(String[] args)
//    {

//    }
//}

public interface IPrinter
{
    void Print(Document d);
}

public interface IScanner
{
    void Scan(Document d);
}

public class PhotoCopier: IPrinter, IScanner
{
    public void Print(Document d)
    {
        throw new NotImplementedException();
    }

    public void Scan(Document d)
    {
        throw new NotImplementedException();
    }
}

public interface IMultiFunctionDevice : IScanner, IPrinter
{

}
public class MultiFunctionMachine : IMultiFunctionDevice
{
    private IPrinter printer;
    private IScanner scanner;
    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
        if (printer == null) throw new ArgumentNullException(paramName: nameof(printer));
        if (printer == null) throw new ArgumentNullException(paramName: nameof(printer));
        this.printer = printer;
        this.scanner = scanner;
    }

    public void Print(Document d)
    {
        printer.Print(d);
    }

    public void Scan(Document d)
    {
        scanner.Scan(d);
    }
}
public interface IMachine
{
    public void Print(Document d);
    public void Scan(Document d);
    public void Fax(Document d);
}
public class MultiFunctionalPrinter : IMachine
{
    public void Fax(Document d)
    {
        throw new NotImplementedException();
    }

    public void Print(Document d)
    {
        throw new NotImplementedException();
    }

    public void Scan(Document d)
    {
        throw new NotImplementedException();
    }
}

public class OldFashionedPrinter : IMachine
{
    public void Fax(Document d)
    {
        throw new NotImplementedException();
    }

    public void Print(Document d)
    {
        throw new NotImplementedException();
    }

    public void Scan(Document d)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    public class Document
    {

    }
    public static void Main(String[] args)
    {

    }
}