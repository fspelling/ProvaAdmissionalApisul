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
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Andar into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 andar = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            return elevadores.Where(e => e.quantidade == elevadores.Min(m => m.quantidade)).Select(s => s.andar).ToList();
        }

        public List<char> elevadorMaisFrequentado()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Elevador into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            return elevadores.Where(e => e.quantidade == elevadores.Max(m => m.quantidade)).Select(s => s.elevador).ToList();
        }

        public List<char> elevadorMenosFrequentado()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Elevador into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            return elevadores.Where(e => e.quantidade == elevadores.Min(m => m.quantidade)).Select(s => s.elevador).ToList();
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
