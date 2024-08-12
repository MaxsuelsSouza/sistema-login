using AutoMapper;
using SistemaLogin.Api.Dominio.Usuarios;

namespace SistemaLogin.Api.Dominio.DTOs;
[AutoMap(typeof(Usuario), ReverseMap = true)]
public class UsuarioNovoDto
{
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? NomeUsuario { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
}

