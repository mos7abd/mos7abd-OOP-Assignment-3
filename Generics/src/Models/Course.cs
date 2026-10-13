using GenericsLab.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab.Models
{

    public class Course : IHasId
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }

}
