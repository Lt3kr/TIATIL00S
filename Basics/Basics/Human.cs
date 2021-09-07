using System;

namespace Basics
{
    interface IHuman
    {
        string firstName {set; get;}
        string lastName {get; set;}
        string fullName();
        bool isDead { get; set; }
        private bool isSecretAgent { get => false; }
    }

    class Human : IHuman
    {
        public string firstName {set; get;}
        public string lastName {get; set;}
        public string fullName()
        {
            return $"{this.firstName} {this.lastName}"; 
        }
        public bool isDead { get; set; }

        bool isSecretAgent = true;
    }
}