using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDept_repository
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly List<Claim> _actorDirectory = new List<Claim>();

        public bool AddClaimToDirectory(Claim claim)
        {
            int claimDirectoryCount = _claimDirectory.Count();
            _claimDirectory.Add(claim);

            if (_claimDirectory.Count()) == claimDirectoryCount + 1)
            {
                return true; 
            }
            return false;
        }

        public List<Claim> GetAllClaims()
        {
            return _claimDirectory;
        }

        public ClaimRepository GetClaimById(int id)
        {
            foreach(var claim in _claimDirectory)
            {
                if(claim.Id == id)
                {
                    return claim;

                }

            }
            return null;

        }

        public bool DeleteClaimByID(int id)
        {
            Claim claim = GetClaimById(id);

            if (claim != null)
            {
                return DeleteExistingClaim(claim);
            }
            return false;
        }

        public bool DeleteExisitingClaim(Claim claim)
        {
            return _claimDirectory.Remove(claim);
        }
    }

    
       
    
}
