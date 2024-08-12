using SistemaLogin.Api.Dominio.DTOs;
using SistemaLogin.Api.Dominio.Usuarios;

namespace SistemaLogin.Api.Services.Interface;
public interface IUsuarioService : IService<UsuarioNovoDto>
{
    Task<UsuarioNovoDto> Autenticar(string email, string senha);
}