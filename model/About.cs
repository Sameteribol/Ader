using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class About: BaseModel
    {
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public string explanation { get; set; }
        public string imageUrlTwo { get; set; }
    }
}

