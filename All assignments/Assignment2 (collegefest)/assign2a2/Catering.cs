using System;

namespace CollegeFestEventHandling
{
    public class Catering
    {
        public void OnFestEventHandler(object sender, int numPeople)
        {
            int cateringCharge = numPeople * 200;
            Console.WriteLine($"Catering charge for {numPeople} people: Rs {cateringCharge}");
        }
    }
}
