using System.Collections.Generic;
using MoviesNetCore.Model;

namespace MoviesNetCore.Repository
{
    public interface IGenreRepository
    {
        Genre Get(int id);

        IEnumerable<Genre> List();

        void Update(Genre genre);

        void Delete(int id);
        Genre GetById(string id);
    }
}