using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this ()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {
            if (Name == "" || Name == null)
            {
                Name = "Data Not Available";
            }
            
            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data Not Available";
            }

            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data Not Available";
            }
            
            if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data Not Available";
            }

            if (JobCoreCompetency.Value == "" || JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data Not Available";
            }

            return $"ID: {Id} \n Name: {Name} \n Employer: {EmployerName.Value} \n Location: {EmployerLocation.Value} \n Position Type: {JobType.Value} \n Core Competency: {JobCoreCompetency.Value}";
        }
    }
}
