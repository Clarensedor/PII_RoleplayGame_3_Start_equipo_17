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

            Knight facundo = new Knight("facundo");
            Axe hacha = new Axe();
            facundo.AddItem(hacha);
            Console.WriteLine($"Ataque de facu{facundo.AttackValue}");


            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);

            Saruman alberto = new Saruman("Alberto", 10); 

            
            alberto.ReceiveAttack(gandalf);

            Console.WriteLine($"Alberto has this health {alberto.Health}");

            Console.WriteLine($"Alberto has this VP {alberto.Vp}");

            Console.WriteLine($"Gandalf has this VP {gandalf.Vp}");

        }
    }
}
