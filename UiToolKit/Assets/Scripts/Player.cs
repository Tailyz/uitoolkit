using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using CombatSystem.Scripts.Runtime.Core;

namespace DefaultNameSpace
{
    public class Player : MonoBehaviour, IDamageable
    {
        [SerializeField] private int m_Health = 5;
        [SerializeField] private int m_MaxHealth = 5;


        private void Update() 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                health--;
            }
        }

        public int health 
        {
            get => m_Health;
            set
            {
                m_Health = Mathf.Clamp(value, 0, maxHealth);
                healthChanged?.Invoke();
            }
        }
        public int maxHealth
        {
            get => m_MaxHealth;
            set
            {
                m_MaxHealth = value;
                maxHealthChanged?.Invoke();
            }
        }
        public event UnityAction healthChanged;
        public event UnityAction maxHealthChanged;
    }
}
