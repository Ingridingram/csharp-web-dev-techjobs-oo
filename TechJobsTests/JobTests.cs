using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Job Job3 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(Job3.Name == "Product Tester");
            Assert.IsTrue(Job3.EmployerName.Value == "ACME");
            Assert.IsTrue(Job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(Job3.JobCoreCompetency.Value == "Persistence");

        }

        [TestMethod]
        public void TestJobForEquality()
        {
            Job Job4 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job Job5 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(Job.Equals(Job4.Id, Job5.Id));
        }

        [TestMethod]
        public void TestToString()
        {
            Job Job6 = new Job("", new Employer(""), new Location("Kansas City"), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual(Job6.ToString(), $"ID: {Job6.Id} \n Name: {Job6.Name} \n Employer: {Job6.EmployerName.Value} \n Location: {Job6.EmployerLocation.Value} \n Position Type: {Job6.JobType.Value} \n Core Competency: {Job6.JobCoreCompetency.Value}");
        }
    }
}

