using System.ComponentModel.DataAnnotations.Schema;

namespace Infoset.EntityLayer.Concrete
{
    public class Branch
    {
        public int id { get; set; }
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }

        [NotMapped]
        public double distance { get; set; }
    }
}
