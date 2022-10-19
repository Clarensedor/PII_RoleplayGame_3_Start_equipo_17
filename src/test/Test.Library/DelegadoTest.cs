using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests_Delegado
    {
        [SetUp]
        public void Setup_D()
        {
        }

        [Test]
        public void VPD()
        {
            const int expected=50;
            Delegado Amadeo=new Delegado("Amadeo ");
            Assert.AreEqual(expected, Amadeo.vp);
        }
        
        [Test]
        public void health_D()
        {
            const int expected=100;
            Delegado Amadeo=new Delegado("Amadeo ");
            Assert.AreEqual(expected, Amadeo.health);
        }
        /*
        [Test]
        public void valor_defensa_D()
        {
            const int expected = 39;
            Delegado Quijote  = new Delegado ("Amadeo ");
            Assert.AreEqual(expected, Delegado.DefenseValue);
        }*/
    }   
}