using Newtonsoft.Json;

namespace test
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
