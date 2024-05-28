using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Paladin : Hero
    {
        private double smiteProbability;
        private double additionalDamageMin;
        private double additionalDamageMax;

        public Paladin(string name, double armor, double strength, IWeapon weapon) : base(name, armor, strength, weapon)
        {
            smiteProbability = 0.20;
            additionalDamageMin = 10;
            additionalDamageMax = 20;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double probability = random.NextDouble();
            if (probability < smiteProbability)
            {
                double additionalDamage = random.NextDouble() * (additionalDamageMax - additionalDamageMin) + additionalDamageMin;
                damage += additionalDamage;
                
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }
    }
}


