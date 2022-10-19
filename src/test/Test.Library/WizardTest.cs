using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class WizardTests
    {
   
        [Test]
        public void Valor_ataque1()
        {
            const int expected = 25; //porque el Wizard ya viene con un axe 
            Wizard elBicho = new Wizard ("Siiiuungerson");
            Assert.AreEqual(expected, elBicho.AttackValue);
        }

        [Test]
        public void Valor_defensa1()
        {
            const int expected = 18;
            Wizard elBicho = new Wizard ("Siiiuungerson");
            Assert.AreEqual(expected, elBicho.DefenseValue);
        }

        [Test]
        public void Vida_inicial1()
        {
            const int expected = 100;
            Wizard elBicho = new Wizard ("Siiiuungerson");
            Assert.AreEqual(expected, elBicho.Health);
        }

        [Test]
        public void DefenseValue_Modified_By_AddingItem1()      //Prueba que el metodo AddItem modifica el valor de defensa
        {
            Wizard elBicho = new Wizard ("Siiiuungerson");      //Tiene 18 de defensa 
            Staff staff = new Staff(); //100
            elBicho.AddItem(staff);  
            int expectedDefenseValue = 118; //Pues Wizard ya viene con Helmet que le da 18 de defenseValue
            Assert.AreEqual(expectedDefenseValue, elBicho.DefenseValue);
        }

        [Test]
        public void AttackValue_Modified_By_AddingItem1()      //Prueba que el metodo AddItem modifica el valor de ataque
        {
            Wizard lego = new Wizard ("Siiiuungerson");      // viene con 25 de ataque por el axe
            Staff staff = new Staff(); //le agrega 100 de ataque
            lego.AddItem(staff);
            int expectedAttackValue = 125;      
            Assert.AreEqual(expectedAttackValue, lego.AttackValue);
        }
        

    }
}