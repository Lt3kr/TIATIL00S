using System;
using System.Collections.Generic;

namespace Zoo
{
    class zoo
    {
        public int AmountOfAnimals { get; set; } = 0;
        public int AmountOfEmployees { get; set; } = 0;
        public int AmountOfVisitors { get; set; } = 0;
        public bool isClosed { get; set; } = true;
        public Dictionary<int, int> locationsIds { get; set; } = new Dictionary<int, int>();

        public void Open()
        {
            isClosed = false;
        }

        public void Close()
        {
            isClosed = true;
        }

        public int addVisitor()
        {
            this.AmountOfVisitors++;
            return this.AmountOfVisitors;
        }

        public int removeVisitor()
        {
            this.AmountOfVisitors--;
            return this.AmountOfVisitors;
        }
    }   
}
