using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab01
{
    public class Person
    {
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //            throw new ArgumentException("Username is required.");
        //        name = value;
        //    }
        //}
        public string Name { get; set; }
        public int Age { get; set; }
        public string Filename { get; set; }
    }
}
