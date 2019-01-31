using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void GetHerdTestProgrammer()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("Programmer");
            Assert.AreEqual("unknown", result);

        }

        [TestMethod]
        public void GetHerdTestDog()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("dog");
            Assert.AreEqual("Pack", result);

        }

        [TestMethod]
        public void GetHerdTestCrocodile()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("crocodile");
            Assert.AreEqual("Float", result);

        }

        [TestMethod]
        public void GetHerdTestDeer()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("deer");
            Assert.AreEqual("Herd", result);

        }

        [TestMethod]
        public void GetHerdTestFlamingo()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("flamingo");
            Assert.AreEqual("Pat", result);

        }

        [TestMethod]
        public void GetHerdTestPigeon()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("pigeon");
            Assert.AreEqual("Kit", result);

        }

        [TestMethod]
        public void GetHerdTestCrow()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("crow");
            Assert.AreEqual("Murder", result);

        }

        [TestMethod]
        public void GetHerdTestLion()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("lion");
            Assert.AreEqual("Pride", result);

        }

        [TestMethod]
        public void GetHerdTestElephant()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("elephant");
            Assert.AreEqual("Herd", result);

        }

        [TestMethod]
        public void GetHerdTestGiraffe()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("giraffe");
            Assert.AreEqual("Tower", result);

        }

        [TestMethod]
        public void GetHerdTestRhino()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("rhino");
            Assert.AreEqual("Crash", result);

        }

        [TestMethod]
        public void GetHerdTestCaps()
        {
            AnimalGroupName animalGroupName = new AnimalGroupName();
            Assert.IsNotNull(animalGroupName);
            string result = animalGroupName.GetHerd("RhInO");
            Assert.AreEqual("Crash", result);

        }


        //{"rhino", "Crash" },
        //       {"giraffe", "Tower" },
        //       {"elephant", "Herd" },
        //       {"lion", "Pride" },
        //       {"crow", "Murder" },
        //       {"pigeon", "Kit" },
        //       {"flamingo", "Pat" },
        //       {"deer", "Herd" },
        //       {"dog", "Pack" },
        //       {"crocodile", "Float" },

    }
}