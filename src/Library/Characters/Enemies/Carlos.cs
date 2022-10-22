using RoleplayGame;

namespace RoleplayGame
{
    public class Carlos : Enemies
    {
        private int Vp;

        public Carlos(string name,int vp) : base(name,vp)
        {
            this.Vp = vp;
        }
    }
}

