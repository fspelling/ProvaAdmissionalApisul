namespace ControleElevadores.Console
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

        public float percentualDeUsoElevadorA() => PercentualDeUsoPorElevador('A');

        public float percentualDeUsoElevadorB() => PercentualDeUsoPorElevador('B');

        public float percentualDeUsoElevadorC() => PercentualDeUsoPorElevador('C');

        public float percentualDeUsoElevadorD() => PercentualDeUsoPorElevador('D');

        public float percentualDeUsoElevadorE() => PercentualDeUsoPorElevador('E');

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by new { elevador.Elevador, elevador.Turno } into elevadorGroup
                             orderby elevadorGroup.Key.Elevador ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key.Elevador,
                                 turno = elevadorGroup.Key.Turno,
                                 quantidade = elevadorGroup.Count()
                             };

            return elevadores.Where(e => e.quantidade == elevadores.Max(m => m.quantidade)).Select(s => s.turno).ToList();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Turno into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 turno = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            return elevadores.Where(e => e.quantidade == elevadores.Max(m => m.quantidade)).Select(s => s.turno).ToList();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by new { elevador.Elevador, elevador.Turno } into elevadorGroup
                             orderby elevadorGroup.Key.Elevador ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key.Elevador,
                                 turno = elevadorGroup.Key.Turno,
                                 quantidade = elevadorGroup.Count()
                             };

            return elevadores.Where(e => e.quantidade == elevadores.Min(m => m.quantidade)).Select(s => s.turno).ToList();
        }

        #region METODOS_AUXILIARES

        private float PercentualDeUsoPorElevador(char tipoElevador)
        {
            var elevadores = from elevador in ElevadorData.Elevadores
                             group elevador by elevador.Elevador into elevadorGroup
                             orderby elevadorGroup.Key ascending
                             select new
                             {
                                 elevador = elevadorGroup.Key,
                                 quantidade = elevadorGroup.Count()
                             };

            var quantidadeElevadorA = (decimal)elevadores.Where(e => e.elevador == tipoElevador).First().quantidade;
            var quantidadeElevadores = (decimal)elevadores.Sum(s => s.quantidade);

            return (float)Math.Round((quantidadeElevadorA / quantidadeElevadores * 100), 2);
        }

        #endregion
    }
}
