using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Game.Scripts
{
    public class Wallet : MonoBehaviour
    {
        private PickupSystem _pickupSystem;
        
        private int _value;

        public int Value => _value;

        private void Awake()
        {
            _pickupSystem = GetComponent<PickupSystem>();
        }

        private void Update()
        {
            if (_pickupSystem.TryGet(out int money))
            {
                Add(money);
            }
        }

        private void Add(int value)
        {
            if (value > 0)
            {
                _value += value;
            }
        }

        public void Reset()
        {
            _value = 0;
        }
    }
}