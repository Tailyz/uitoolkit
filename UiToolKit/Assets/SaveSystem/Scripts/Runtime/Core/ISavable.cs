using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveSystem.Scripts.Runtime.Core
{
    public interface ISavable<T> 
    {
        T data { get;}
        void Load (T data);
    }
}
