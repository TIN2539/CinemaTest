using Cinema.Domain.Models;
using Cinema.Presentation.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Presentation.Wpf.ViewModels
{
    public class MainViewModel
    {
        private IEnumerable<Movie> movies = new List<Movie> {  new Movie(
                    new MovieTitle("Star Wars. The Last Jedi"),
                    new DateTime(2017, 12, 15),
                    new Language("English"),
                    new[]
                    {
                        new Actor("Mark", "Hamill"),
                        new Actor("Harrison", "Ford"),
                        new Actor("Ewan", "McGregor")
                    },
                    new Producer("Rian", "Johnson")
               )};
        public MainViewModel()
        {

            Current = new MainControl();
        }

        public object Current { get; set; }
        public IEnumerable<Movie> Movies => movies;
    }
}
