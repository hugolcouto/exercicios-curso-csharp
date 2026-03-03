using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {
        // string a = "Lorem";
        // string b = "ipsum";
        // string c = "Lorem";
        // string d = a;

        // System.Console.WriteLine(a.Equals(b));
        // System.Console.WriteLine(a.Equals(c));
        // System.Console.WriteLine(a.GetHashCode());
        // System.Console.WriteLine(b.GetHashCode());
        // System.Console.WriteLine(c.GetHashCode());
        // System.Console.WriteLine(d.GetHashCode());

        System.Console.WriteLine("---------------");

        HashSet<string> set = new HashSet<string>();

        set.Add("Hello");
        set.Add("world");
        set.Add("from");
        set.Add("CSharp!");

        System.Console.WriteLine(set.Contains("CSharp!"));
        System.Console.WriteLine(set.Contains("Javascript!"));

        foreach (string item in set)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("---------------");

        SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 6, 8 };
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };


        SortedSet<int> ab = new SortedSet<int>(a);
        ab.UnionWith(b);

        PrintCollection(ab);

        System.Console.WriteLine("---------------");

        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);

        PrintCollection(d);

        System.Console.WriteLine("---------------");

        SortedSet<int> e = new SortedSet<int>(a);
        a.ExceptWith(b);
        PrintCollection(e);
    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            System.Console.WriteLine($"obj: {item}");
        }
    }
}