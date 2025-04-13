using System;
using System.Collections.Generic;
namespace DIP
{
    public enum RelationShip
    {
        Parent,
        Child,
        Sibling
    }
    public class Person
    {
        public string Name { get; set; }
    }

    public interface IRelationShipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    public class RelationShips : IRelationShipBrowser
    {
        public List<(Person, RelationShip, Person)> relations = new List<(Person, RelationShip, Person)>();
        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, RelationShip.Parent, child));
            relations.Add((child, RelationShip.Parent, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            //foreach (var rel in relations.Where(x => x.Item1.Name == "John" && x.Item2 == RelationShip.Parent))
            //{
            //    Console.WriteLine($"John has a child called {rel.Item3.Name}");
            //}
            return relations.Where(x => x.Item1.Name == name && x.Item2 == RelationShip.Parent).Select(r=>r.Item3);
        }
    }

    public class Research
    {

    }
    public class DependencyInversionPrinciple
    {
        //public DependencyInversionPrinciple(RelationShips relationships)
        //{
        //    var relations = relationships.relations;
        //    foreach (var rel in relations.Where(x=>x.Item1.Name == "John" && x.Item2 == RelationShip.Parent))
        //    {
        //        Console.WriteLine($"John has a child called {rel.Item3.Name}");
        //    }
        //}
        public static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            var parent = new Person() { Name = "John" };
            var child1 = new Person() { Name = "Abhraham" };
            var child2 = new Person() { Name = "Lincoln" };

            var relationShips = new RelationShips();
            relationShips.AddParentAndChild(parent, child1);
            relationShips.AddParentAndChild(parent, child2);
        }
    }

}
