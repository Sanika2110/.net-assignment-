using System;

class Program
{
    static void Main()
    {
        // Instantiate and run each LINQ demonstration
        LINQToArray linqArray = new LINQToArray();
        linqArray.Run();

        Console.WriteLine("\n-----------------------------\n");

        LINQToXML linqXML = new LINQToXML();
        linqXML.Run();

        Console.WriteLine("\n-----------------------------\n");

        LINQToSQL linqSQL = new LINQToSQL();
        linqSQL.Run();

        Console.WriteLine("\n-----------------------------\n");

        LINQToCollection linqCollection = new LINQToCollection();
        linqCollection.Run();
    }
}
