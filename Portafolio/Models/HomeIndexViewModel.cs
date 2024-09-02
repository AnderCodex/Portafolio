namespace Portafolio.Models
{
    public class HomeIndexViewModel
    {
        //creo el Listado para listar los Projectos
        //encapsula la informacion para cargar en la vista INDEX

        public IEnumerable<Proyecto>  Projectos { get; set; }
    }
}
