using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundo.Services
{
    public class PeliculasService
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Jack el destripador",
                Duracion = 123,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 3)
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Jack el destripador",
                Duracion = 123,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 3)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "El Trauco",
                Duracion = 163,
                Pais = "Chile",
                Publicacion = new DateTime(2016, 04, 5)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }
    }
}