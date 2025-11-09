using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Token.Services.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateJwtToken(string username);
    }
}
