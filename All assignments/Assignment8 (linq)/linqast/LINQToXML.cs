using System;
using System.Linq;
using System.Xml.Linq;

public class LINQToXML
{
    public void Run()
    {
        string xmlData = @"
            <Books>
                <Book>
                    <Title>Programming C#</Title>
                    <Author>John Doe</Author>
                    <Price>39.99</Price>
                </Book>
                <Book>
                    <Title>Mastering LINQ</Title>
                    <Author>Jane Smith</Author>
                    <Price>29.99</Price>
                </Book>
            </Books>";

        XElement books = XElement.Parse(xmlData);

        var bookTitles = from book in books.Elements("Book")
                         where (double)book.Element("Price") > 30
                         select book.Element("Title").Value;

        Console.WriteLine("Books with Price greater than 30:");
        foreach (var title in bookTitles)
        {
            Console.WriteLine(title);
        }
    }
}
