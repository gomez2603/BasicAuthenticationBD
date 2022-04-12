using AuthBasicwithDB.Models;
using AuthBasicwithDB.Repositories.IRepositories;

namespace AuthBasicwithDB.Services
{
    public class StockService : IStockService
    {
        private readonly IUnidadTrabajo _unidadTrabajo;
        public StockService(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }
        public void Delete(int id)
        {
          _unidadTrabajo.Stock.Remover(id);
        }

        public IEnumerable<Stock> Get()
        {
            return _unidadTrabajo.Stock.ObtenerTodos(incluirPropiedades: "Beer");
        }

        public Stock GetbyId(int id)
        {
            return _unidadTrabajo.Stock.Obtener(id);
        }

        public void Insert(Stock stock)
        {
            _unidadTrabajo.Stock.Agregar(stock);
            _unidadTrabajo.Guardar();
        }

        public void Update(Stock stock)
        {
            _unidadTrabajo.Stock.Actualizar(stock);
            _unidadTrabajo.Guardar();
        }
    }
}
