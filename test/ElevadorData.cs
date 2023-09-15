using Newtonsoft.Json;

namespace ProvaAdmissionalApisul.Console
{
    public class ElevadorData
    {
        public List<ElevadorEntity> Elevadores { get; private set; }

        public ElevadorData()
        {
            string json = File.ReadAllText("input.json");
            Elevadores = JsonConvert.DeserializeObject<List<ElevadorEntity>>(json) ?? new List<ElevadorEntity>();
        }
    }
}
