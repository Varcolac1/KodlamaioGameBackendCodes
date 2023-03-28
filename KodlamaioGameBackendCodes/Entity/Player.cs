using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaioGameBackendCodes.Abstract;

namespace KodlamaioGameBackendCodes.Entity
{
    public class Player : IEntitiy
    {
        public Player(string nationalityId, string firtsName, string lastName, DateTime dateOfBirth)
        {
            NationalityId = nationalityId;
            FirstName = firtsName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
