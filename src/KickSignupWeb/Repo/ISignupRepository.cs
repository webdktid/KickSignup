using System.Threading.Tasks;
using KickSignupWeb.Models;

namespace KickSignupWeb.Repo
{
    public interface ISignupRepository
    {
        void Insert(SignMeUpModel signMeUpModel);
    }
}
