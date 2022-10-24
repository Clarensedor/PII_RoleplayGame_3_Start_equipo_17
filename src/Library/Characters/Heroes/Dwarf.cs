using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: Heroes, ICharacter
    {

        
        public Dwarf(string name) : base(name)
        {
            this.Name = name;
            
        }
    }
}

