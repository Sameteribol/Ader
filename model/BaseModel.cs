using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class BaseModel
    {
        public int ıd { get; set; }
        public string? name { get; set; }

        public DateTime dataCreated { get; set; } = DateTime.Now;

        public DateTime? dataModified { get; set; }

        public bool isActive { get; set; } = true;
        public bool isDelete { get; set; } = false;



    }
}
