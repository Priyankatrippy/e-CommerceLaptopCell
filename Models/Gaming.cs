using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course_end_project2phase_3.Models
{
   
        public partial class Gaming
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Nullable<double> Price { get; set; }
        }
    
}