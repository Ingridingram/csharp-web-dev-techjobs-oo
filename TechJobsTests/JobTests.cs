using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job Job1 = new Job();
            Job Job2 = new Job();
            //Assert.AreEqual(Job1.Id, 1);
            //Assert.AreEqual(Job2.Id, 2);
            Assert.IsFalse(Job1.Id == Job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job Job3 = new Job("Product Tester", "ACME", "Desert", "Quality Control", "Persistence");

            Assert.IsTrue(Job3.Name == "Product Tester");
            Assert.IsTrue(Job3.EmployerName.Value == "ACME");
            Assert.IsTrue(Job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(Job3.JobCoreCompetency.ToString() == "Persistence");

        }

        [TestMethod]
        public void TestJobForEquality()
        {
            Job Job4 = new Job("Product Tester", "ACME", "Desert", "Quality Control", "Persistence");
            Job Job5 = new Job("Product Tester", "ACME", "Desert", "Quality Control", "Persistence");
            Assert.IsFalse(Job.Equals(Job4.Id, Job5.Id));
        }
    }
}
