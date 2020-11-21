using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();


            /*
             * +5 Dexterity Vest, -20, 0
Aged Brie, -20, 30
Elixir of the Mongoose, -25, 0
Sulfuras, 0, 80
Backstage passes, -5, 0
Backstage passes, -20, 0
Backstage passes, -25, 0
Conjured, -25, 0
             * */
            Assert.IsTrue(output.Contains("+5 Dexterity Vest, -20, 0"));
            Assert.IsTrue(output.Contains("Aged Brie, -20, 50"));
            Assert.IsTrue(output.Contains("Sulfuras, 0, 80"));
            Assert.IsTrue(output.Contains("Backstage passes, -5, 0"));
            Assert.IsTrue(output.Contains("Backstage passes, -25, 0"));
            Assert.IsTrue(output.Contains("Backstage passes, -20, 0"));
            Assert.IsTrue(output.Contains("Conjured, -25, 6"));

            //Approvals.Verify(output);
        }
    }
}
