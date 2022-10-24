using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Heroes, ICharacter
    {
        public Archer(string name) : base(name)
        {
            this.Name = name;
        }
    }
}