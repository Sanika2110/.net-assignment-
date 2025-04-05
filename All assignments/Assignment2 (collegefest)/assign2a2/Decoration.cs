using System;

namespace CollegeFestEventHandling
{
    public class Decoration
    {
        public void OnFestEventHandler(object sender, int numPeople)
        {
            int decorationCharge = 10000 + (numPeople * 10);
            Console.WriteLine($"Decoration charge for {numPeople} people: Rs {decorationCharge}");
        }
    }
}
