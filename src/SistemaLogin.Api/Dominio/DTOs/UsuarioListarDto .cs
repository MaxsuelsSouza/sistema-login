using AutoMapper;
using SistemaLogin.Api.Dominio.Usuarios;

namespace SistemaLogin.Api.Dominio.DTOs;
[AutoMap(typeof(Usuario), ReverseMap = true)]
public class UsuarioListarDto
{
    public Guid UsuarioId { get; set; }
    public string? NomeUsuario { get; set; }
    public string? Email { get; set; }
}

