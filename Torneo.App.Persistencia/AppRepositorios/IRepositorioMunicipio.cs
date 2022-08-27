using Torneo.App.Dominio;
using System.Collections.Generic;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        IEnumerable<Municipio> AgregarTodosMunicipio();

        Municipio AgreagarMunicipio(Municipio municipio);
        Municipio ActualizarMunicipio(Municipio municipio);
        void BorrarMunicipio(int idmunicipio);
        Municipio BuscarMunicipio(int idmunicipio);

    }
}