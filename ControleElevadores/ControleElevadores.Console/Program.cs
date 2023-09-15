using ControleElevadores.Console;

var service = new ElevadorService();

Console.WriteLine($"a - Andar menos utilizado pelos usuários : {string.Join(',', service.andarMenosUtilizado())}");
Console.WriteLine($"b - Elevador mais frequentado e o período que se encontra maior fluxo : {string.Join(',', service.elevadorMaisFrequentado())} - {string.Join(',', service.periodoMaiorFluxoElevadorMaisFrequentado())}");
Console.WriteLine($"c - Elevador menos frequentado e o período que se encontra menor fluxo : {string.Join(',', service.elevadorMenosFrequentado())} - {string.Join(',', service.periodoMenorFluxoElevadorMenosFrequentado())}");
Console.WriteLine($"d - Período de maior utilização do conjunto de elevadores : {string.Join(',', service.periodoMaiorUtilizacaoConjuntoElevadores())}");
Console.WriteLine($"e - Percentual de uso de cada elevador com relação a todos os serviços prestados: ");
Console.WriteLine($"\t -> Elevador A = {service.percentualDeUsoElevadorA()}");
Console.WriteLine($"\t -> Elevador B = {service.percentualDeUsoElevadorB()}");
Console.WriteLine($"\t -> Elevador C = {service.percentualDeUsoElevadorC()}");
Console.WriteLine($"\t -> Elevador D = {service.percentualDeUsoElevadorD()}");
Console.WriteLine($"\t -> Elevador E = {service.percentualDeUsoElevadorE()}");

Console.Read();