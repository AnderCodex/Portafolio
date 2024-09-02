using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyecto
    {

        //Creo un metodo para poder listar en el Index
         public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo =" Un Titulo",
                    Descripcion = "Descripcion de el Proyecto",
                    Link = "https://ejemplo.com",
                    ImagenURL = "Directorio de la imagen"
                },

                 new Proyecto
                {
                    Titulo =" Un Titulo2",
                    Descripcion = "Descripcion de el Proyecto",
                    Link = "https://ejemplo2.com",
                    ImagenURL = "Directorio de la imagen"
                },

                  new Proyecto
                {
                    Titulo =" Un Titulo3",
                    Descripcion = "Descripcion de el Proyecto",
                    Link = "https://ejemplo3.com",
                    ImagenURL = "Directorio de la imagen"
                },

                   new Proyecto
                {
                    Titulo =" Un Titulo4",
                    Descripcion = "Descripcion de el Proyecto",
                    Link = "https://ejemplo4.com",
                    ImagenURL = "Directorio de la imagen"
                },
            };
        }
    }
}
