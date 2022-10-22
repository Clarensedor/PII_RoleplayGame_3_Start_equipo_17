using RoleplayGame;

namespace RoleplayGame
{
    public class Saruman : Enemies
    {
        private int Vp;

        public Saruman(string name, int vp) : base(name,vp)
        {                                       
            this.Vp = vp;

            // Esto esta mal, hay que editarlo para que le aparezca los VP
        }
    }
}
