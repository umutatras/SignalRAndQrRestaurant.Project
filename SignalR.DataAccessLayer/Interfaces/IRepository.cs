﻿using SignalR.CommonLayer;
using SignalR.EntityLayer.Entities;
using System.Linq.Expressions;

namespace SignalR.DataAccessLayer.Abstraction;

public interface IRepository<T> where T : BaseEntity
{
    IQueryable<T> Query();
    IQueryable<T> Query(Expression<Func<T, bool>> predicate);
    IQueryable<T> Query<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.ASC);
    IQueryable<T> Query<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.ASC);
    Task<List<T>> GetAllAsync();
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);

    Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC);

    Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC);

    Task<T> FindAsync(object id);

    Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, bool asNoTracking = false);

    IQueryable<T> GetQuery();

    void Remove(T entity);

    Task CreateAsync(T entity);

    void Update(T entity, T unchanged);
}
