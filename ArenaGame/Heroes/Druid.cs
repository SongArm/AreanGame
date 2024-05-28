using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Druid : Hero
    {
        private double healProbability;
        private double healAmount;

        public Druid(string name, double armor, double strength, IWeapon weapon) : base(name, armor, strength, weapon)
        {
            healProbability = 0.15;
            healAmount = 10;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            return damage;
        }

        public override double Defend(double damage)
        {
            double probability = random.NextDouble();
            if (probability < healProbability)
            {
                Armor += healAmount;
                
            }
            return base.Defend(damage);
        }
    }
}


