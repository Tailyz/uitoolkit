using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CombatSystem.Scripts.Runtime.Core
{
    public interface IDamageable
    {
        int health { get; }
        int maxHealth { get; }
        public event UnityAction healthChanged;
        public event UnityAction maxHealthChanged;
    }
}