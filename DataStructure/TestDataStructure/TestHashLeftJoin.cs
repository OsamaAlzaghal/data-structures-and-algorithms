using DataStructure.DSA.HashLeftJoin;
using System.Collections.Generic;
using Xunit;

namespace TestDataStructure
{
    public class TestHashLeftJoin
    {
        [Fact]
        public void TestLeftHashtable()
        {
            HashtableLeftJoin leftHashtable = new HashtableLeftJoin(10);
            leftHashtable.Set("diligent", "employed");
            leftHashtable.Set("fond", "enamored");
            leftHashtable.Set("guide", "usher");
            leftHashtable.Set("outfit", "garb");
            leftHashtable.Set("wrath", "anger");

            HashtableLeftJoin rightHashtable = new HashtableLeftJoin(10);
            rightHashtable.Set("diligent", "idle");
            rightHashtable.Set("fond", "averse");
            rightHashtable.Set("guide", "follow");
            rightHashtable.Set("flow", "jam");
            rightHashtable.Set("wrath", "delight");

            var leftJoin = HashtableLeftJoin.LEFTJOINs(leftHashtable, rightHashtable);

            List<string[]> expectedList = new List<string[]> { new string[] { "font", "enamored", "averse" },
                                                       new string[] {"wrath", "anger", "delight"},
                                                       new string[] {"diligent", "employed", "idle"},
                                                       new string[] {"outfit", "garb", null},
                                                       new string[] {"guide", "usher", "follow" }
            };

            Assert.Contains(expectedList.ToString(), leftJoin.ToString());
        }

        [Fact]
        public void TestEmptyLeftHashtable()
        {
            HashtableLeftJoin leftHashtable = null;
            HashtableLeftJoin rightHashtable = new HashtableLeftJoin(10);
            var list = HashtableLeftJoin.LEFTJOINs(leftHashtable, rightHashtable);
            Assert.Null(list);
        }

        [Fact]
        public void TestEmptyRightHashtable()
        {
            HashtableLeftJoin leftHashtable = new HashtableLeftJoin(10);
            HashtableLeftJoin rightHashtable = null;
            leftHashtable.Set("diligent", "employed");
            leftHashtable.Set("fond", "enamored");

            var returnedList = HashtableLeftJoin.LEFTJOINs(leftHashtable, rightHashtable);
            List<string[]> leftList = new List<string[]> { new string[] { "diligent", "employed" }, new string[] { "fond", "enamored" } };
            Assert.Equal(returnedList, leftList);
        }

        [Fact]
        public void TestEmptyHashtables()
        {
            HashtableLeftJoin leftHashtable = null;
            HashtableLeftJoin rightHashtable = null;
            var result = HashtableLeftJoin.LEFTJOINs(leftHashtable, rightHashtable);
            Assert.Null(result);
        }
    }
}