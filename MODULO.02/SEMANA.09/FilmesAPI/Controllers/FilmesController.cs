using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace FilmesApi.Controllers
{
    [Route("api/filmes")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)] //Data Anot. para Controller
        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            return MockFilmes.Filmes;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Filme filme = MockFilmes.Filmes.FirstOrDefault(x => x.Id == id);
            if (filme is null)
            {
                return NotFound();
            }

            return Ok(filme);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            MockFilmes.Filmes.Add(filme);
            return CreatedAtAction(nameof(Get), new { Id = filme.Id }, filme);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Filme filme)
        {
            Filme filmeUpdate = MockFilmes.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filmeUpdate != null)
            {
                var index = MockFilmes.Filmes.IndexOf(filmeUpdate);

                if (index != -1)
                    MockFilmes.Filmes[index] = filme;

                return NoContent();
            }

            return NotFound();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Filme filme = MockFilmes.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme != null)
            {
                MockFilmes.Filmes.Remove(filme);

                return NoContent();
            }

            return NotFound();
        }
    }
}