using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Character character = new Character("Bella","MeowMeow",50,5);
            character.LevelIncrease();
            character.HealthUpdate();
            string potion = "health";
            character.RestoreStaminaAndHealth(potion);
            character.PowerScore();
            character.ToString();

        }
    }
    public class Character 
    {
        public string name;
        public int level;
        public int healthPoints;
        public int attackPower;
        public int defensePower;
        public int experiencePoints;
        public int stamina;
        public string specialAbility;

        public Character() 
        {
            level = 1;
            healthPoints = 100;
            attackPower = 50;
            defensePower = 50;
        }
        public Character( string name , string specialAbility , int stamina , int experiencePoints) 
        {
            this.name = name;
            this.specialAbility = specialAbility;
            this.stamina = stamina;
            this.experiencePoints = experiencePoints;
        }
        public void LevelIncrease() 
        {
            if ( healthPoints >= 70 && experiencePoints >= 10) 
            {
                level += 1;
            }
        }
        public void HealthUpdate() 
        {
            healthPoints -= 10;
        }
        public void RestoreStaminaAndHealth(string potion) 
        {
            if (potion == "health") 
            {
                if (healthPoints < 100) 
                {
                    healthPoints = 100;
                }
            }
            if (potion == "stamina")
            {
                if (stamina < 100)
                {
                    stamina = 100;
                }
            }
        }
        public float PowerScore() 
        {
            float powerscore = attackPower + defensePower;
            return powerscore;
        }
        public void ToString()
        {
            Console.WriteLine("Name : " + name + " Level : " + level + " Health : " + healthPoints + " Attack Power : " + attackPower + " Defense Power : " + defensePower + " Experience : " + experiencePoints + " Stamina : " + stamina + " Special Ability : " + specialAbility );
        }
    }
}