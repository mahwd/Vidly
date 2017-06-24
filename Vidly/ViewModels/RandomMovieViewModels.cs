using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModels
    {
        public Movie movie { get; set; }
        public List<Customers> customers { get; set; }

    }
}