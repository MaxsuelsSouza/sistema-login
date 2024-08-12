using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaLogin.Api.Services.Interface
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(Guid id);
        Task<Guid> Adicionar(T entity);
        Task<T> Atualizar(T entity);
        Task<OkResult> Remover(Guid id);
    }
}