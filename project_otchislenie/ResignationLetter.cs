using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_otchislenie
{
    public class ResignationLetter
    {
        public int Id {  get; set; }
        public int ReasonId { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public int StudentId { get; set; }
    }
}
