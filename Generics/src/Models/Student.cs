using GenericsLab.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLab.Models
{

    public class Student : IHasId
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }

}
