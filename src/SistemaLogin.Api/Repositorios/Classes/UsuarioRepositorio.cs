using SistemaLogin.Api.Data;
using SistemaLogin.Api.Dominio.DTOs;
using SistemaLogin.Api.Dominio.Usuarios;
using SistemaLogin.Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SistemaLogin.Api.Repositorios.Classes;
public class UsuarioRepositorio(AplicacaoContexto context) : IUsuarioRepositorio
{
    private readonly AplicacaoContexto _context = context;

    public async Task<Usuario> Adicionar(Usuario entidade)
    {
        await _context.Usuarios.AddAsync(entidade);
        await _context.SaveChangesAsync();

        return entidade;
    }

    public Task<Usuario> Atualizar(Usuario entidade)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> ObterPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Usuario>> ObterTodos()
    {
        return await _context.Usuarios.AsNoTracking().OrderBy(x => x.UsuarioId).ToListAsync();
    }

    public Task<OkResult> Remover(Guid id)
    {
        throw new NotImplementedException();
    }
}