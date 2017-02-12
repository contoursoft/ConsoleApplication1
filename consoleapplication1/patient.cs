using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    // comments here 9

    public class Patient
    {
        public Guid PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class PatientInsert
    {
        public Guid entityId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public DateTime birthDate { get; set; }
    }

    public class QueryParams
    {
        public Guid EntityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
