using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using KickSignupWeb.Models;
using Microsoft.Extensions.Configuration;

namespace KickSignupWeb.Repo
{
    public class SignupRepository : ISignupRepository
    {
        private readonly IConfiguration _configuration;

        public SignupRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

      

        public void Insert(SignMeUpModel signMeUpModel)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = "INSERT INTO Signups (Name, Email,SignupDateTime,PreferredClub,ZipCode,Phone)"
                                + " VALUES(@Name, @Email,@SignupDateTime,@PreferredClub,@ZipCode,@Phone)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, signMeUpModel);
            }
        }

        public IDbConnection Connection => new SqlConnection(_configuration.GetConnectionString("SignUpDatebase"));
    }
}