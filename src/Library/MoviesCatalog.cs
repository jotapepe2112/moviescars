//------------------------------------------------------------------------------
// <copyright file="MoviesCatalog.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Repositories
{
    public class MoviesCatalog
    {
        private Repository<Movie> repository = new Repository<Movie>();

        public void Add(Movie movie)
        {
            this.repository.Add(movie);
        }

        public void Remove(Movie movie)
        {
            this.repository.Remove(movie);
        }

        public Movie Find(Predicate<Movie> criteria)
        {
            return this.repository.Find(criteria);
        }
    }
}
