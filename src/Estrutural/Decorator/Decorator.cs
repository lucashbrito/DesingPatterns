using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca ItemBiblioteca;

        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            ItemBiblioteca = itemBiblioteca;
        }
        public override void Exibe()
        {
            ItemBiblioteca.Exibe();
        }
    }
}
