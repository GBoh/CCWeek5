using System.Linq;
using ExclusiveCarDealership.Domain;
using System;
using System.Linq.Expressions;

namespace ExclusiveCarDealership.Infrastructure {
    public interface IRepository : IDisposable {
        void Add<T>(T entityToCreate) where T : class;
        void Delete<T>(params object[] keyValues) where T : class;
        T Find<T>(params object[] keyValues) where T : class;
        IQueryable<T> Query<T>() where T : class;
        IQueryable<Vehicle> QueryCar();
        IQueryable<T> QueryICar<T>() where T : class, IVehicle;
        void SaveChanges();
    }
    public static class GenericRepositoryExtensions {
        public static IQueryable<T> Include<T, TProperty>(this IQueryable<T> queryable, Expression<Func<T, TProperty>> relatedEntity) where T : class {
            return System.Data.Entity.QueryableExtensions.Include<T, TProperty>(queryable, relatedEntity);
        }
    }
}