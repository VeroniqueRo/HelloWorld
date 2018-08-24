using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class MessageTests
    {
        //[TestMethod()]
        //public void GetUserNameTest()
        //{
        //    Message target = new Message(); // Etant donné l'instanciation d'un nouveau message
        //    String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
        //    Assert.AreEqual("Bon après-midi veronique.rouault !", result);// Alors le nom de l'utilistaur de l'ordinateur s'affiche
        //}

        [TestMethod()]
        public void GetBonjourTest()
        {

            DateTime dateToTest = new DateTime(2018, 8, 21, 10, 0, 0);

            Message target = new Message(new FakeDateTime(dateToTest)); // Etant donné l'instanciation d'un nouveau message
            String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
            Assert.IsTrue(result.Contains("Bonjour"));// Alors le message "Bonjour" s'affiche
        }

        [TestMethod()]
        public void GetBonApremTest()
        {

            DateTime dateToTest = new DateTime(2018, 8, 21, 15, 0, 0);

            Message target = new Message(new FakeDateTime(dateToTest)); // Etant donné l'instanciation d'un nouveau message
            String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
            Assert.IsTrue(result.Contains("Bon après-midi"));// Alors le message "Bon après-midi" s'affiche
        }

        [TestMethod()]
        public void GetBonsoirTest()
        {

            DateTime dateToTest = new DateTime(2018, 8, 21, 18, 0, 0);

            Message target = new Message(new FakeDateTime(dateToTest)); // Etant donné l'instanciation d'un nouveau message
            String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
            Assert.IsTrue(result.Contains("Bonsoir"));// Alors le message "Bonsoir" s'affiche
        }

        [TestMethod()]
        public void GetBonWeekEndVendrediSoirTest()
        {

            DateTime dateToTest = new DateTime(2018, 8, 24, 18, 0, 0);

            Message target = new Message(new FakeDateTime(dateToTest)); // Etant donné l'instanciation d'un nouveau message
            String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
            Assert.IsTrue(result.Contains("Bon week-end"));// Alors le message "Bon week-end" s'affiche
        }

        [TestMethod()]
        public void GetBonWeekEndSamediTest()
        {

            DateTime dateToTest = new DateTime(2018, 8, 25, 18, 0, 0);

            Message target = new Message(new FakeDateTime(dateToTest)); // Etant donné l'instanciation d'un nouveau message
            String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
            Assert.IsTrue(result.Contains("Bon week-end"));// Alors le message "Bon week-end" s'affiche
        }

        [TestMethod()]
        public void GetBonWeekEndLundiMatinTest()
        {

            DateTime dateToTest = new DateTime(2018, 8, 27, 8, 59, 59);

            Message target = new Message(new FakeDateTime(dateToTest)); // Etant donné l'instanciation d'un nouveau message
            String result = target.GetHelloMessage();// Lorsque on appelle la méthode GetHelloMessage
            Assert.IsTrue(result.Contains("Bon week-end"));// Alors le message "Bon week-end" s'affiche
        }

    }
}