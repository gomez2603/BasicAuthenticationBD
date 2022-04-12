using AuthBasicwithDB.Models;
using AuthBasicwithDB.Repositories.IRepositories;
using System.Text.Json;

namespace AuthBasicwithDB.Services
{
    public class BeerService : IBeerServices
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public BeerService(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IEnumerable<Beer> Get()
        {
            return _unidadTrabajo.Beer.ObtenerTodos();
        }

        public Beer GetbyId(int id)
        {
            return _unidadTrabajo.Beer.Obtener(id);
        }

        public void Insert(Beer beer)
        {

            _unidadTrabajo.Beer.Agregar(beer);
            _unidadTrabajo.Guardar();
        }

        public void Update(Beer beer)
        {
            _unidadTrabajo.Beer.Actualizar(beer);
            _unidadTrabajo.Guardar();
        }
        public void Delete(int id)
        {
            _unidadTrabajo.Beer.Remover(id);
            _unidadTrabajo.Guardar();
        }
    }
}
