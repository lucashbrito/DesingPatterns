using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FabricaFlyweight
    {
        private Dictionary<string, Tartaruga> _dictionaryTartaruga = new Dictionary<string, Tartaruga>();

        public Tartaruga GeTartaruga(string cor)
        {
            Tartaruga tartaruga = null;

            if (_dictionaryTartaruga.ContainsKey(cor))
            {
                return tartaruga = _dictionaryTartaruga[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul":
                        tartaruga = new TartarugaAzul();
                        break;
                    case "verde":
                        tartaruga = new TartarugaVerde();
                        break;
                    case "vermelha":
                        tartaruga = new TartarugaVermelha();
                        break;
                    case "laranja":
                        tartaruga = new TartarugaLaranja();
                        break;
                }

                _dictionaryTartaruga.Add(cor, tartaruga);
            }

            return tartaruga;
        }
    }
}
