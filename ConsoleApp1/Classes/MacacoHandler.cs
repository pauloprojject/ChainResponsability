using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class MacacoHandler : AbstractHandler
    {
        private const string BANANA = "Banana";

        public override object Handle(object request)
        {
            if (((string)request).Equals(BANANA))
            {
                return $"Twelves: Eu vou comer a {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
