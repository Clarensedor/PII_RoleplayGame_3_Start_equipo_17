using RoleplayGame;

namespace RoleplayGame
{
    public abstract class Enemies : Character
    {
        private int vp;
        public Enemies(string name, int vp) : base(name)
        {
            this.Vp= vp;
        }
        public int Vp
        {

            get
            {
                return this.vp;
            }
            set
            {
                if(this.Health < 0)
                {
                    this.vp = 0;
                }
                this.vp = value;
            }
        }

        public int ReceiveAttack(Heroes whoAttack)
        {
            if (this.DefenseValue < whoAttack.AttackValue)
            {
                this.Health -= whoAttack.AttackValue - this.DefenseValue;
                
                if (this.CurrentHealth()<0)
                {
                    whoAttack.Vp+=this.Vp;
                    this.Vp = 0;
                }
                return 0;
            }
            else
            {
                return Vp;
            }
        }
    }

}