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
        public List<Type> Types { get; set; }
        public string Date { get; set; }
        public int Debts { get; set; }

    }
}
