using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioDT
    {
        public DirectorTecnico AgregarDT(DirectorTecnico directorTecnico);
        public IEnumerable<DirectorTecnico> GetAllDTs();
    }
}