using System;

namespace Basics
{
    interface IInterfaceTest<T>
    {
        T name {set; get;}
        string lastName {get;}
    }
}