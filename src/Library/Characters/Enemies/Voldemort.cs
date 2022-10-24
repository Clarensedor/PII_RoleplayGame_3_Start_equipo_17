using RoleplayGame;

namespace RoleplayGame
{
    public class Voldemort : Enemies
    {
        public Voldemort(string name,int vp) : base(name,vp)
        {
            this.Vp = vp;
        }
    }
}