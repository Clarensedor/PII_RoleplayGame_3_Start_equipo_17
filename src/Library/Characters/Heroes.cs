using RoleplayGame;
using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Heroes : Character
    {
        private int vp;
        public Heroes(string name) : base(name)
        {
            this.vp=0;
        }
        public void ReceiveAttack(Enemies whoAttack)
        {
            if (this.DefenseValue < whoAttack.AttackValue)
            {
                this.Health -= whoAttack.AttackValue - this.DefenseValue;

            }
        }
        public int Vp
        {
            get
            {
                return this.vp;
            }
            set
            {
                this.vp = value;
            }
        }
    }
}
