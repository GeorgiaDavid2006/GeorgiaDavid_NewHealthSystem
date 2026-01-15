using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_NewHealthSystem
{
    class Health
    {
       public int CurrentHealth { get; private set; }
       public int MaxHealth { get; private set; }

        public Health(int maxHealth)
        {
            CurrentHealth = maxHealth;
            MaxHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                Console.WriteLine("Invalid damage");
            }
            else
            {
                CurrentHealth -= damage;

                CurrentHealth = Math.Max(0, CurrentHealth);
            }
        }

        public void Restore()
        {
            CurrentHealth = MaxHealth;
        }

        public void Heal(int health)
        {
            if(health < 0)
            {
                Console.WriteLine("Invalid health");
            }
            else
            {
                CurrentHealth += health;

                CurrentHealth = Math.Min(MaxHealth, CurrentHealth);
            }
        }
    }
}
