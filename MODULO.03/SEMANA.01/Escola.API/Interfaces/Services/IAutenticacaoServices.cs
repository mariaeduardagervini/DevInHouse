using Escola.API.DTO;

namespace Escola.API.Interfaces.Services
{
    public interface IAutenticacaoServices
    {
        bool Autenticar(LoginDTO login);
        string GerarToken(LoginDTO loginDTO);
    }
}
