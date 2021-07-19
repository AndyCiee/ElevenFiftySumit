using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDept_repository
{
    public interface IClaimRepository
    {
        bool AddClaimToDirectory(Claim claim);
        List<Claim> GetAllClaims();
        Claim GetClaimByID(int id);
        bool DeleteClaimByID(int id);
        bool DeleteExisitingClaim(Claim claim);

    }
}
