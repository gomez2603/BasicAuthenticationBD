namespace AuthBasicwithDB.Repositories.IRepositories
{
    public interface IUnidadTrabajo:IDisposable
    {
        IUserRepository User { get; }
        IBeerRepository Beer { get; }
        IStockRepository Stock { get; }

        void Guardar();
    }
}
