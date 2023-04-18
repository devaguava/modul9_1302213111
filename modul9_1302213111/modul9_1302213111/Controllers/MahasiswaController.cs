using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302213111.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMhs = new List<Mahasiswa>
        {
            new Mahasiswa("Deva Angela Felisitas Toding", "1302213111", new List<string>{"KPL", "PBO", "BD"}, 2023),
            new Mahasiswa("Alif Taufiqurrahman", "1302213011", new List<string>{"KPL", "PBO", "BD"}, 2023),
            new Mahasiswa("Iqro Banyuanto", "1302213061", new List<string>{"KPL", "PBO", "BD"}, 2023),
            new Mahasiswa("Regy Renanda Rahman", "1302213117", new List<string>{"KPL", "PBO", "BD"}, 2023),
            new Mahasiswa("Rahma Sakti Rahardian", "1302210095", new List<string>{"KPL", "PBO", "BD"}, 2023)
        };

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMhs;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMhs[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMhs)
        {
            dataMhs.Add(newMhs);
        }

        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Mahasiswa updatedMhs)
        //{
        //    dataMhs[id] = updatedMhs;
        //}

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMhs.RemoveAt(id);
        }
    }
}
