using System.Collections.Generic;
using UnityEngine;

namespace Bytecode
{
    public class MagicalAPI
    {
        private Dictionary<int, Wizard> _data = new Dictionary<int, Wizard>();

        public void SetHealth(int wizard, int amount) 
        { 
            if(_data.ContainsKey(wizard))
            {
                _data[wizard].Health = amount;
            }
            else
            {
                Wizard newWizard = new Wizard(wizard);
                newWizard.Health = amount;

                _data.Add(wizard, newWizard);
            }

            Debug.Log($"Wizard: {wizard}, Set Health: {amount}");
        }
        public void SetWisdom(int wizard, int amount) 
        {
            if (_data.ContainsKey(wizard))
            {
                _data[wizard].Wisdom = amount;
            }
            else
            {
                Wizard newWizard = new Wizard(wizard);
                newWizard.Wisdom = amount;

                _data.Add(wizard, newWizard);
            }

            Debug.Log($"Wizard: {wizard}, Set Wisdom: {amount}"); 
        }
        public void SetAgility(int wizard, int amount) 
        {
            if (_data.ContainsKey(wizard))
            {
                _data[wizard].Agility = amount;
            }
            else
            {
                Wizard newWizard = new Wizard(wizard);
                newWizard.Agility = amount;

                _data.Add(wizard, newWizard);
            }

            Debug.Log($"Wizard: {wizard}, Set Agility: {amount}"); 
        }

        public int GetHealth(int wizard)
        {
            if (_data.ContainsKey(wizard))
            {
                int health = _data[wizard].Health;
                Debug.Log($"Wizard: {wizard}, Get Health: {health}");

                return health;
            }
            else
            {
                Wizard newWizard = new Wizard(wizard);
                _data.Add(wizard, newWizard);
                Debug.Log($"Wizard: {wizard}, Get Health: {newWizard.Health}");

                return newWizard.Health;
            }
        }
        public int GetWisdom(int wizard)
        {
            if (_data.ContainsKey(wizard))
            {
                int wisdom = _data[wizard].Wisdom;
                Debug.Log($"Wizard: {wizard}, Get Wisdom: {wisdom}");

                return wisdom;
            }
            else
            {
                Wizard newWizard = new Wizard(wizard);
                _data.Add(wizard, newWizard);
                Debug.Log($"Wizard: {wizard}, Get Health: {newWizard.Wisdom}");

                return newWizard.Wisdom;
            }
        }
        public int GetAgility(int wizard)
        {
            if (_data.ContainsKey(wizard))
            {
                int agility = _data[wizard].Agility;
                Debug.Log($"Wizard: {wizard}, Get Agility: {agility}");

                return agility;
            }
            else
            {
                Wizard newWizard = new Wizard(wizard);
                _data.Add(wizard, newWizard);
                Debug.Log($"Wizard: {wizard}, Get Health: {newWizard.Agility}");

                return newWizard.Agility;
            }
        }

        public void PlaySound(int soundId) { Debug.Log($"Play Sound: {soundId}"); }
        public void SpawnParticles(int particleType) { Debug.Log($"Spawn Particles: {particleType}"); }

        private class Wizard
        {
            public int Health;
            public int Wisdom;
            public int Agility;

            private int _id;

            public Wizard(int id)
            {   
                _id = id;

                Health = 45; 
                Wisdom = 11;
                Agility = 7;
            }

            public int ID => _id;
        }
    }
}
