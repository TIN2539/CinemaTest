using Cinema.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Presentation.Wpf.ViewModels
{
    class MovieViewModel
    {
        private readonly Movie movie;

        public MovieViewModel(Movie movie)
        {
            this.movie = movie;
        }

        public string Title => movie.Title.Name;
    }
}
