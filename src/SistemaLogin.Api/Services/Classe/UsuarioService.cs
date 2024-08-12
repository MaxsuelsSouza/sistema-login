using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using SistemaLogin.Api.AutoMapper;
using SistemaLogin.Api.Dominio.DTOs;
using SistemaLogin.Api.Dominio.Usuarios;
using SistemaLogin.Api.Repositorios.Interfaces;
using SistemaLogin.Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SistemaLogin.Api.Services.Classe;
public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepositorio _repositorioUsuario;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepositorio repositorioUsuario, IMapper mapper)
    {
        _repositorioUsuario = repositorioUsuario;
        _mapper = mapper;
    }
    public async Task<Guid> Adicionar(UsuarioNovoDto entity)
    {
        Usuario usuario = new()
        {
            UsuarioId = Guid.NewGuid(),
            Nome = entity.Nome,
            Sobrenome = entity.Sobrenome,
            NomeUsuario = entity.NomeUsuario,
            Email = entity.Email,
            Senha = GeraHashSenha(entity.Senha!)
        };

        await _repositorioUsuario.Adicionar(usuario);

        return usuario.UsuarioId;
    }

    public Task<UsuarioNovoDto> Atualizar(UsuarioNovoDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioNovoDto> Autenticar(string email, string senha)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioNovoDto> ObterPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<UsuarioNovoDto>> ObterTodos()
    {
        var usuarios = await _repositorioUsuario.ObterTodos();

        return usuarios.Select(usuario => _mapper.Map<UsuarioNovoDto>(usuario));
    }

    public Task<OkResult> Remover(Guid id)
    {
        throw new NotImplementedException();
    }

    private static string GeraHashSenha(string senha)
    {
        string hashSenha;
        byte[] bytesSenha = Encoding.UTF8.GetBytes(senha);
        byte[] bytesHashSenha = SHA256.HashData(bytesSenha);
        hashSenha = BitConverter.ToString(bytesHashSenha).Replace("-", "").Replace("-", "").ToLower();
        return hashSenha;
    }
}
