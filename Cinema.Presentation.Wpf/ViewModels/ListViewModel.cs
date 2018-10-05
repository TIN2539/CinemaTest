using Cinema.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Presentation.Wpf.ViewModels
{
    class ListViewModel
    {
        
        private ICollection<MovieViewModel> movies = new ObservableCollection<MovieViewModel>();

        public ListViewModel()
        {
            movies.Add(new MovieViewModel
                        (
                            new Movie
                            (
                                new MovieTitle("Star Wars. The Last Jedi."),
                                new DateTime(2017, 12, 15),
                                new Language("English"),
                                new[]
                                {
                                    new Actor("Mark", "Hamill"),
                                    new Actor("Harrison", "Ford"),
                                    new Actor("Ewan", "McGregor")
                                },
                                new Producer("Rian", "Johnson")
                            )
                       )
               );
        }

        public IEnumerable<MovieViewModel> Movies => movies;
    }
}
