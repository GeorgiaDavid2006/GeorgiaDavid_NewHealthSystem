using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_NewHealthSystem
{
    class Player
    {
        public string Name { get; set; }

        static int _maxHealth;
        static int _maxSheild;

        public Health _Health { get; private set; } = new Health(_maxHealth);
        public Health _Sheild { get; private set; } = new Health(_maxSheild);

        private string _healthStatus1;
        private string _healthStatus2;
        private string _healthStatus3;
        private string _healthStatus4;

        public Player(string name, int maxHealth, int maxSheild)
        {
            Name = name;

            _maxHealth = maxHealth;
            _maxSheild = maxSheild;

            _healthStatus1 = "Stable";
            _healthStatus2 = "Critical";
            _healthStatus3 = "Danger";
            _healthStatus4 = "Dead";
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
            {
                Console.WriteLine("Invalid Damage");
            }
            else
            {
                if (_Sheild.CurrentHealth < 0)
                {
                    
                    if (damage > _Sheild.CurrentHealth)
                    {
                        int newDamage = damage - _Sheild.CurrentHealth;
                        _Health.TakeDamage(newDamage);
                        _Sheild.TakeDamage(_Sheild.CurrentHealth);
                    }
                    else
                    {
                        _Sheild.TakeDamage(damage);
                    }
                }
                else
                {
                    _Health.TakeDamage(damage);
                }
            }
        }

        public string GetStatusString()
        {
            if (_Health.CurrentHealth >= 51)
            {
                string status1 = _healthStatus1;
                return status1;
            }
            else if (_Health.CurrentHealth <= 50 && _Health.CurrentHealth > 25)
            {
                string status2 = _healthStatus2;
                return status2;
            }
            else if(_Health.CurrentHealth <= 25 && _Health.CurrentHealth > 0)
            {
                 string status3 = _healthStatus3;
                 return status3;
            }
            else
            {
                string status4 = _healthStatus4;
                return status4;
            }
        }

    }
}
