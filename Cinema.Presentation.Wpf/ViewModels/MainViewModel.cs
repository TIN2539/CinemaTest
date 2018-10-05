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
        public MainViewModel()
        {
            Current = new ListViewModel();
        }

        public object Current { get; set; }
    }
}
