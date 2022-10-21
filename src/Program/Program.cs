using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);

            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");

            */
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);
            Saruman alberto = new Saruman("Alberto", 10); 
            
            Console.WriteLine($"Alberto has this health {alberto.Health}");

            Console.WriteLine($"Alberto has this VP points {alberto.Vp}");

            alberto.ReceiveAttack(gandalf.AttackValue);
            Console.WriteLine($"Alberto has this health {alberto.Health}");

            Console.WriteLine($"Alberto has this VP {alberto.Vp}");

            Console.WriteLine($"Gandalf has this VP {gandalf.Vp}");

        }
    }
}
