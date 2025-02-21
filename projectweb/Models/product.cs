using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace projectweb.Models
{
    public class product
    {
      public int productid { get; set; }
      public string productname { get; set; }

        public string? Location { get; set; }

        public string? Company { get; set; }

        public string? Description { get; set; }
        public double Price { get; set; }
      public user user { get; set; }
        public int  userid { get; set; }
        



    }
}
