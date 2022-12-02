using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class VacaHandler : AbstractHandler
    {
        private const string GRAMA = "Grama";

        public override object Handle(object request)
        {
            if (request.ToString().Equals(GRAMA))
            {
                return $"Vaca: hmmm {request.ToString()} boa.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
