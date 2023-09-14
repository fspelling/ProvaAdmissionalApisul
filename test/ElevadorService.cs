using System;
using System.Collections.Generic;
using System.IO.Pipes;
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
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Elevador into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            var quantidadeElevadorA = (decimal)elevadores.Where(e => e.elevador == 'A').First().quantidade;
            var quantidadeElevadores = (decimal)elevadores.Sum(s => s.quantidade);

            return (float)Math.Round((quantidadeElevadorA / quantidadeElevadores * 100), 2);
        }

        public float percentualDeUsoElevadorB()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Elevador into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            var quantidadeElevadorA = (decimal)elevadores.Where(e => e.elevador == 'B').First().quantidade;
            var quantidadeElevadores = (decimal)elevadores.Sum(s => s.quantidade);

            return (float)Math.Round((quantidadeElevadorA / quantidadeElevadores * 100), 2);
        }

        public float percentualDeUsoElevadorC()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Elevador into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            var quantidadeElevadorA = (decimal)elevadores.Where(e => e.elevador == 'C').First().quantidade;
            var quantidadeElevadores = (decimal)elevadores.Sum(s => s.quantidade);

            return (float)Math.Round((quantidadeElevadorA / quantidadeElevadores * 100), 2);
        }

        public float percentualDeUsoElevadorD()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Elevador into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            var quantidadeElevadorA = (decimal)elevadores.Where(e => e.elevador == 'D').First().quantidade;
            var quantidadeElevadores = (decimal)elevadores.Sum(s => s.quantidade);

            return (float)Math.Round((quantidadeElevadorA / quantidadeElevadores * 100), 2);
        }

        public float percentualDeUsoElevadorE()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Elevador into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            var quantidadeElevadorA = (decimal)elevadores.Where(e => e.elevador == 'E').First().quantidade;
            var quantidadeElevadores = (decimal)elevadores.Sum(s => s.quantidade);

            return (float)Math.Round((quantidadeElevadorA / quantidadeElevadores * 100), 2);
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

        #region METODOS_AUXILIARES

        //public List<T> AgruparElevadoresNome(T a)
        //{
        //    return from elevador in ElevadorData.Elevadores
        //                     group elevador by elevador.Elevador into elevadorGroup
        //                     orderby elevadorGroup.Key ascending
        //                     select new
        //                     {
        //                         elevador = elevadorGroup.Key,
        //                         quantidade = elevadorGroup.Count()
        //                     };
        //}

        #endregion
    }
}
