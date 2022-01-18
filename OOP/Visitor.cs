using System;

namespace Zoo
{
    class Visitor
    {
        public string Namn { get; set; }
        public bool isInside { get; set; }
        public int id { get; set; }
        public DateTime lastVisited { get; set; }

        public void Leave()
        {
            isInside = false;
        }

        public void Join()
        {
            isInside = true;
        }
    }
}