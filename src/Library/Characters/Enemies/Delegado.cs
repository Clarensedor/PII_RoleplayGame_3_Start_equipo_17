using System.Collections.Generic;
namespace RoleplayGame
{
    public class Delegado:Enemies
    {
        public Delegado(string name, int vp) : base(name,vp)
        {
            this.Vp = vp;
        }
    }
}