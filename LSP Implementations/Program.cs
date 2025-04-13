using System;

namespace LSP_Implementations
{
	class Program
	{
		static void Main(string[] args)
		{
			Vegetables vegetables = new Vegetables();
			Groceries groceries = new Groceries();
			Service service = new Service();
			Onion onion = new Onion();
			ServiceSub serviceSub = new ServiceSub();
			service.doSomething(vegetables);
			serviceSub.doSomething(vegetables);

			
		}
	}
}