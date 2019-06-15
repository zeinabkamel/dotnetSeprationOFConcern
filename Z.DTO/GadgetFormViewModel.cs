using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Z.DTO
{
    public class GadgetFormViewModel
    {
         public string GadgetTitle { get; set; }
        public string GadgetDescription { get; set; }
        public decimal GadgetPrice { get; set; }
        public int GadgetCategory { get; set; }
    }
}