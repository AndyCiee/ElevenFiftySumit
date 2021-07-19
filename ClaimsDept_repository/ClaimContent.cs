using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDept_repository
{
 //POCO
    public class ClaimContent
    {
        public ClaimContent() { }

        public ClaimContent(string claim)
        {
            Claim = claim;
        }

        public ClaimContent(int claimId, ClaimType claim, string description,double claimAmount, DateTime DateOfIncident, DateTime dateOfClaim, bool valid)
        {
            ClaimID = claimId;
            Claim = claim;
            Description = description;
            ClaimAmount = claimAmount;
            IncidentDate = DateOfIncident;
            ClaimDate = dateOfClaim;
            IsValid = valid;
        }
        public int ClaimID { get; set; }
        public ClaimType Claim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime IncidentDate { get; set; }
        public DateTime ClaimDate { get; set; }
        public bool IsValid { get; set; }
        
    }
        public enum ClaimType
        {
            Home,
            Car,
            Theift
        }
    public bool IsValid
    {
        if (true)
         {
            Console.WriteLine("Valid");
        }
        else (false)
        {
            Console.WriteLine("InValid");
        }
    }
}
