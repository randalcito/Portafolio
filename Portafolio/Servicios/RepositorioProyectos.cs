using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                    new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/Imagenes/amazon.png",
                },
                    new Proyecto
                {
                    Titulo = "New York Times",
                    Descripcion = "Páginas de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "/Imagenes/nyt.png",
                },
                    new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/Imagenes/reddit.png",
                },
                    new Proyecto
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en línea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/Imagenes/steam.png",
                }
            };
        }
    }
}
