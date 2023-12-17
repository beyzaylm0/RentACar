using Application.Services.Repositories;
using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;

public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>, IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context)
    {
    }

    public Brand Add(Brand entity)
    {
        throw new NotImplementedException();
    }

    public ICollection<Brand> AddRange(ICollection<Brand> entities)
    {
        throw new NotImplementedException();
    }

    public bool Any(Expression<Func<Brand, bool>>? predicate = null, bool withDeleted = false, bool enableTracking = true)
    {
        throw new NotImplementedException();
    }

    public Brand Delete(Brand entity, bool permanent = false)
    {
        throw new NotImplementedException();
    }

    public ICollection<Brand> DeleteRange(ICollection<Brand> entity, bool permanent = false)
    {
        throw new NotImplementedException();
    }

    public Brand? Get(Expression<Func<Brand, bool>> predicate, Func<IQueryable<Brand>, IIncludableQueryable<Brand, object>>? include = null, bool withDeleted = false, bool enableTracking = true)
    {
        throw new NotImplementedException();
    }

    public Paginate<Brand> GetList(Expression<Func<Brand, bool>>? predicate = null, Func<IQueryable<Brand>, IOrderedQueryable<Brand>>? orderBy = null, Func<IQueryable<Brand>, IIncludableQueryable<Brand, object>>? include = null, int index = 0, int size = 10, bool withDeleted = false, bool enableTracking = true)
    {
        throw new NotImplementedException();
    }

    public Paginate<Brand> GetListByDynamic(DynamicQuery dynamic, Expression<Func<Brand, bool>>? predicate = null, Func<IQueryable<Brand>, IIncludableQueryable<Brand, object>>? include = null, int index = 0, int size = 10, bool withDeleted = false, bool enableTracking = true)
    {
        throw new NotImplementedException();
    }

    public Brand Update(Brand entity)
    {
        throw new NotImplementedException();
    }

    public ICollection<Brand> UpdateRange(ICollection<Brand> entities)
    {
        throw new NotImplementedException();
    }
}