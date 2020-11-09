using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public string Value { get; set; }
        public int Id { get; }
        private static int nextId = 1;

        public JobField(string value)
        {
           Value = value;
        }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }
        public string ToString(string value)
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField ThisJob &&
                ThisJob.Value == Value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
