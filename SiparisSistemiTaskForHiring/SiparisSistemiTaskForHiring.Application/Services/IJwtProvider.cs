using SiparisSistemiTaskForHiring.Application.Features.Auth.Login;
using SiparisSistemiTaskForHiring.Domain.Entities;

namespace SiparisSistemiTaskForHiring.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
