using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAiProject3_RapidApi.ViewModel
{
    public class ApiSeriesViewModel
    {
        //json verisin yapıştırmak için : edit-> paste special-> paste json as classes
        public int rank { get; set; }
        public string title { get; set; }       
        public float rating { get; set; }
        public string year { get; set; }     
    }
}
