using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishfirmtask4
{
    public class Catch
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Kind { get; set; }
        public int Weight { get; set; }
        public int VisitFishPlaceId { get; set; }
        public VisitFishPlace? VisitFishPlace { get; set; }
    }
}
