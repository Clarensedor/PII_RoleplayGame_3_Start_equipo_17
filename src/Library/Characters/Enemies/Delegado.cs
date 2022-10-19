using System.Collections.Generic;
namespace RoleplayGame
{
    public class Delegado:Enemies
    {
        public int vp{get; set;}
        public int health {get; set;}

        public Delegado(string name) : base(name)
        {
            this.vp = 50;
            this.health=100;
            this.AddItem(new Armor());
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}