using AutoMapper;
using SistemaLogin.Api.Dominio.DTOs;
using SistemaLogin.Api.Dominio.Usuarios;

namespace SistemaLogin.Api.AutoMapper;
public class UsuarioMapper : Profile
{
    public UsuarioMapper()
    {
        CreateMap<Usuario, UsuarioNovoDto>().ReverseMap();
        CreateMap<UsuarioNovoDto, Usuario>().ReverseMap();
    }
}
