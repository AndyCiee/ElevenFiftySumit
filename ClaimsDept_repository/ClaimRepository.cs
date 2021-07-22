using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDept_repository
{
    public class ClaimRepository
    {
        private readonly Queue<ClaimContent> _claimDirectory = new Queue<ClaimContent>();

        public bool AddClaimToDirectory(ClaimContent claim)
        {
            //Enqueue will add to the queue
            int claimDirectoryCount = _claimDirectory.Count();
            _claimDirectory.Enqueue(claim);

            if (_claimDirectory.Count() == claimDirectoryCount ++)
            {
                return true;
            }
            return false;
        }

        public Queue<ClaimContent> GetAllClaims()
        {
            return _claimDirectory;
        }

        //Fix This
        public ClaimRepository GetClaimById(int id)
        {
            foreach (var claim in _claimDirectory)
            {
                if (claim.Id == id)
                {
                    return claim;

                }

            }
            return null;

        }
        //Fix This
        public bool DeleteClaimByID(int id)
        {
            ClaimContent claim = GetClaimById(id);

            if (claim != null)
            {
                return DeleteExistingClaim(claim);
            }
            return false;
        }
        //Fix This
        private bool DeleteExistingClaim(ClaimContent claim)
        {
            throw new NotImplementedException();
        }

        public bool DeleteExisitingClaim(ClaimContent claim)
        {
            //Use Dequeue to remove from queue
            return _claimDirectory.Remove(claim);
        }

    }
}
