using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void valor_ataque()
        {
            const int expected = 15;
            Archer guillermo = new Archer ("Guillermo");
            Assert.AreEqual(expected, guillermo.AttackValue);
        }

        [Test]
        public void valor_defensa()
        {
            const int expected = 18;
            Archer guillermo = new Archer ("Guillermo");
            Assert.AreEqual(expected, guillermo.DefenseValue);
        }

        [Test]
        public void vida_inicial()
        {
            const int expected = 100;
            Archer guillermo = new Archer ("Guillermo");
            Assert.AreEqual(expected, guillermo.Health);
        }

        [Test]
        public void DefenseValue_Modified_By_AddingItem()      //Prueba que el metodo AddItem modifica el valor de defensa
        {
            Archer guillermo = new Archer ("Guillermo");      //Tiene 18 de defensa 
            Staff staff = new Staff(); //100
            guillermo.AddItem(staff);  
            int expectedDefenseValue = 118; //Pues Archer ya viene con Helmet que le da 18 de defenseValue
            Assert.AreEqual(expectedDefenseValue, guillermo.DefenseValue);
        }

                [Test]
        public void AttackValue_Modified_By_AddingItem()      //Prueba que el metodo AddItem modifica el valor de defensa
        {
            Archer lego = new Archer ("Lego");      
            Staff staff = new Staff();
            lego.AddItem(staff);
            int expectedAttackValue = 115;
            Assert.AreEqual(expectedAttackValue, lego.AttackValue);
        }
        

    }
}