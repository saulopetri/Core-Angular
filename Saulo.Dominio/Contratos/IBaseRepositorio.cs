using System;
using System.Collections.Generic;

namespace Saulo.Dominio
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
        TEntity Obter(int Id);
        IEnumerable<TEntity> ObterTodos();
    }
}
