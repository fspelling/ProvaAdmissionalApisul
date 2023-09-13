using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ElevadorService : IElevadorService
    {
        public ElevadorData ElevadorData { get; set; }

        public ElevadorService() => ElevadorData = new ElevadorData();

        public List<int> andarMenosUtilizado()
        {
            var test = ElevadorData.Elevadores.OrderBy(o => o.Andar).GroupBy(e => e.Andar).ToList();

            test.Select(e => new {
                e.Key,
                e.Count()
            });

            throw new NotImplementedException();
        }

        public List<char> elevadorMaisFrequentado()
        {
            throw new NotImplementedException();
        }

        public List<char> elevadorMenosFrequentado()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorA()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorB()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorC()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorD()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorE()
        {
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            throw new NotImplementedException();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            throw new NotImplementedException();
        }
    }
}
