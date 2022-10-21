using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Saruman alberto = new Saruman("Alberto"); 
            Console.WriteLine($"Alberto has ❤️ {alberto.Health}");

            Console.WriteLine($"Gandalf has {alberto.Vp}");

            alberto.ReceiveAttack(gandalf.AttackValue);
            Console.WriteLine($"Alberto has ❤️ {alberto.Health}");

            Console.WriteLine($"Gandalf has {alberto.Vp}");

            Console.WriteLine($"Gandalf has {gandalf.Vp}");

        }
    }
}
