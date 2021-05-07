using System;

namespace BuckleUpApi.Core.Models
{
    public abstract class Details : BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}