using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class MovieListModel
    {
        public MovieListModel()
        {
            lst = new List<MovieCardModel>();
        }
        public List<MovieCardModel> lst { get; set; }
    }
}
