using System.Collections.Generic;

namespace Basics
{
    class Map<TKey, TValue> : Dictionary<TKey, TValue>
    {
        ///<summery>
        /// Gets Value by key
        ///</summery>
       public TValue get(TKey key)
       {
           return this[key];
       } 
    }
}