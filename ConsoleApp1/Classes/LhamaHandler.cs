using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class LhamaHandler : AbstractHandler
    {
        private const string PALHA = "Palha";

        public override object Handle(object request)
        {
            if (request.ToString().Equals(PALHA))
            {
                return $"Lhama: {request.ToString()}... Pfft!\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
