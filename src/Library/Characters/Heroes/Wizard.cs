using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: Heroes, IMagicCharacter 
    {

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name) : base(name)
        {
            this.Name = name;
        }

        // en este caso decido hacer un override para el attackValue
        // dado que es un metodo que justo solo afecta de forma distinta al mago
        // y es mas practico hacer polimorfismo (override)
        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

    }
}