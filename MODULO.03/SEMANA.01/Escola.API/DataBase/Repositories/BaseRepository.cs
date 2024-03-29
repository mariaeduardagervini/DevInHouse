﻿using Escola.API.Model;
using System.Collections.Generic;
using System.Linq;

namespace Escola.API.DataBase.Repositories;

    public class BaseRepository<TEntity, TKey>
            where TEntity : class 
    {

        protected readonly EscolaDbContexto _context;
        public BaseRepository(EscolaDbContexto contexto)
        {
            _context = contexto;
        }

    protected readonly DbContexto _contextDb = new DbContexto();
    public BaseRepository(DbContexto contextoDb)
    {
        _contextDb = contextoDb;
    }


    public virtual TEntity Atualizar(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual void Excluir(TEntity entity)
        {

            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual TEntity Inserir(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual TEntity ObterPorId(TKey id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual List<TEntity> ObterTodos()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
