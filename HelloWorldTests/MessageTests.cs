using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod()]
        public void GetUserNameTest()
        {
            Message target = new Message(); // Etant donné l'instanciation d'un nouveau message
            String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
            Assert.IsTrue(result.Contains("veronique.rouault"));// Alors le nom de l'utilistaur de l'ordinateur s'affiche
        }

        [TestMethod()]
        public void GetBonjourTest()
        {
           
            Message target = new Message(new FakeDateTime()); // Etant donné l'instanciation d'un nouveau message
            String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
            Assert.IsTrue(result.Contains("Bonjour"));// Alors le nom de l'utilistaur de l'ordinateur s'affiche
        }
    }
}