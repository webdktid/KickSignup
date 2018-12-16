using System.Collections.Generic;
using System.Threading.Tasks;
using KickSignupWeb.Models;

namespace KickSignupWeb.Repo
{
    public interface ISignupRepository
    {
        void Insert(SignMeUpModel signMeUpModel);

        List<SignMeUpModel> GetAll();
    }
}
