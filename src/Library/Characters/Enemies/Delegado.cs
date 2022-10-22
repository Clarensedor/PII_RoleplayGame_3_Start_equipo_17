using System.Collections.Generic;
namespace RoleplayGame
{
    public class Delegado:Enemies
    {
        public int Vp{get; set;}
        public int health {get; set;}

        public Delegado(string name, int vp) : base(name,vp)
        {
            this.Vp = vp;
        }
    }
}