using System.Numerics;
using IndexICE1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Player player1 = new Player(10, 104, "DianaMagus22", "Warlock", "Half Elf", "Astrid");


            int levle = 10;

            Assert.AreEqual(player1[0], levle);
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            Player player1 = new Player(10, 104, "DianaMagus22", "Warlock", "Half Elf", "Astrid");


            int health = 104;

            Assert.AreEqual(player1[1], health);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Player player1 = new Player(10, 104, "DianaMagus22", "Warlock", "Half Elf", "Astrid");


            string playerTag = "DianaMagus22";

            Assert.AreEqual(player1[2], playerTag);

        }


        [TestMethod]
        public void TestMethod4()
        {
            Player player1 = new Player(10, 104, "DianaMagus22", "Warlock", "Half Elf", "Astrid");


            string characterClass = "Warlock";

            Assert.AreEqual(player1[3], characterClass);

        }

        [TestMethod]
        public void TestMethod5()
        {
            Player player1 = new Player(10, 104, "DianaMagus22", "Warlock", "Half Elf", "Astrid");


            string characterRace = "Half Elf";

            Assert.AreEqual(player1[4], characterRace);

        }
    }
}