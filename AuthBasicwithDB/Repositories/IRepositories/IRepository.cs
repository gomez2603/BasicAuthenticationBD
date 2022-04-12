using System.Linq.Expressions;

namespace AuthBasicwithDB.Repositories.IRepositories
{
    public interface IRepository<T> where T : class
    {
        T Obtener(int id);
        IEnumerable<T> ObtenerTodos(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> OrderBy = null,
            string incluirPropiedades = null
            );

        T ObtenerPrimero(
           Expression<Func<T, bool>> filter = null,
             string incluirPropiedades = null
           );

        void Agregar(T entidad);

        void Remover(int id);
        void Remover(T entidad);
        void RemoverRange(IEnumerable<T> entidad);
    }
}
