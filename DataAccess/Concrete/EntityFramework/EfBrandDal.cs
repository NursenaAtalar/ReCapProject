using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal

    {
        public void Add(Brand entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Brand entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            };
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            };
        }
    }
}
