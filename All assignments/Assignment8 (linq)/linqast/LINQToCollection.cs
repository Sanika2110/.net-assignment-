using System;
using System.Collections.Generic;
using System.Linq;

public class LINQToCollection
{
    public void Run()
    {
        List<string> names = new List<string>
        {
            "John", "Jane", "James", "Jill", "Jack"
        };

        var filteredNames = from name in names
                            where name.StartsWith("J")
                            orderby name
                            select name;

        Console.WriteLine("Names starting with 'J':");
        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }
    }
}
