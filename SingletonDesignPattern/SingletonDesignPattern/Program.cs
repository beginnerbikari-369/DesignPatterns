// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Singleton
{
    private static Singleton _singletonInstance;
    private static readonly object _singletonLock = new object();
    private Singleton()
    {
    }
    public static Singleton Instance
    {
        get
        {
            if(_singletonInstance == null)
            {
                if(_singletonLock == null)
                {
                    if(_singletonInstance == null) return _singletonInstance =  new Singleton();
                }
            }
            return _singletonInstance;
        }
    }
    public void Dispose()
    {
        _singletonInstance = null;
    }

}