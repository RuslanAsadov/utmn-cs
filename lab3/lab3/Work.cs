using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Work
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string UdcId { get; set; }
        public DateTime Dates { get; set; }
        public string PublicationHouseId { get; set; }
        public string Doi { get; set; }
        public List<string> AuthorsIds { get; set; }
    }
}
