using System.Collections.Generic;
using System.Linq;
using MoviesNetCore.Model;

namespace MoviesNetCore.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly DatabaseContext db;

        

        public GenreRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Delete(int id)
        {
            Genre genre = this.GetById(id);
            this.db.Genres.Remove(genre);
            this.db.SaveChanges();
        }

        public Genre Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Genre GetById(string id)
        {
            return this.db.Genres.Find(id);
        }

        public IEnumerable<Genre> List()
        {
            return this
                .db
                .Genres
                .AsEnumerable();
        }

        public void Update(Genre genre)
        {
            this.db.Genres.Update(genre);
            this.db.SaveChanges();
        }
    }
}