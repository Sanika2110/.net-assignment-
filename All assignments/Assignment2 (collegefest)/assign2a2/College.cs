using System;

namespace CollegeFestEventHandling
{
    public class College
    {
        public event EventHandler<int> OnFestEvent;

        public void RaiseFestEvent(int numPeople)
        {
            OnFestEvent?.Invoke(this, numPeople);
        }
    }
}
