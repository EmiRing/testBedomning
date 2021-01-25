using System;
using System.Collections.Generic;
using System.Text;

namespace TestBedomningEmil
{
    public class Character
    {
        private string name;
        private int health;
        private int strength;
        private int luck;
        Random rnd = new Random();

        public Character(string characterName)
        {
            name = characterName;
            health = rollDice();
            strength = rollDice();
            luck = rollDice();
        }

        public string getName()
        {
            return name;
        }

        public int getHealth() 
        {
            return health; 
        }

        public int getStrength()
        {
            return strength;
        }

        public int getluck()
        {
            return luck;
        }

        private int rollDice()
        {
            int value = rnd.Next(3, 19);
            return value;
        }
    }
}
