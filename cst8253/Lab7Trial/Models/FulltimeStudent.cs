using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7Trial.Models
{
    public class FulltimeStudent : Student
    {
        // property
        public int MaxWeeklyHours { get; set; }

        // constructor taking one parameter of string type to pass to the base class's constructor to initialize the base classes Name property
        public FulltimeStudent (string name) : base (name) { }
    }
}
