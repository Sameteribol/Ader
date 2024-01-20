using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Testimonials:BaseModel
    {
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public string title { get; set; }
    }
}
