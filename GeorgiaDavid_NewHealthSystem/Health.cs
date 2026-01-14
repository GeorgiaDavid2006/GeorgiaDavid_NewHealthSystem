using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_NewHealthSystem
{
    class Health
    {
       int _currentHealth;
       int _maxHealth;

        public Health(int maxHealth)
        {
            _currentHealth = maxHealth;
            _maxHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                Console.WriteLine("Invalid damage");
            }
            else
            {
                _currentHealth -= damage;

                _currentHealth = Math.Max(0, _currentHealth);
            }
        }

        public void Restore()
        {
            _currentHealth = _maxHealth;
        }

        public void Heal(int health)
        {
            if(health < 0)
            {
                Console.WriteLine("Invalid health");
            }
            else
            {
                _currentHealth += health;

                _currentHealth = Math.Min(_maxHealth, _currentHealth);
            }
        }
    }
}
