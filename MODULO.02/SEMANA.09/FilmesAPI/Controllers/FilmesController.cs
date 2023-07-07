using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace FilmesApi.Controllers
{
    [Route("api/v{version:apiVersion}/filmes")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        /// <summary> 
        /// Requisição de lista mocada de filmes
        /// </summary>
        /// <returns> Retorna uma lista mocada de filmes </returns>
        /// <response code="200">Sucesso no retorno da lista mocada de filmes </response> 

        [ProducesResponseType(StatusCodes.Status200OK)] //Data Anot. para Controller
        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            return MockFilmes.Filmes;
        }

        /// <summary> 
        /// Requisição do item de uma lista mocada de filmes
        /// </summary>
        /// <param name="id"> Id do filme </param>
        /// <returns> Retorno do objeto Filme </returns>
        /// <response code="404">Filme não encontrado </response>
        /// <response code="200">Sucesso no retorno do objeto Filme </response>

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

        /// <summary> 
        /// Criaçãp de um filme
        /// </summary>
        /// <param name="filme">Objeto filme </param>
        /// <returns> Criação do Filme </returns>
        /// <response code="201">Objeto Filme criado com sucesso </response>


        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            MockFilmes.Filmes.Add(filme);
            return CreatedAtAction(nameof(Get), new { Id = filme.Id }, filme);
        }

        /// <summary> 
        /// Atualização do filme
        /// </summary>
        /// <param name="id"> Id do filme </param>
        /// <param name="filme"> Objeto filme </param>
        /// <returns> Atualização do Filme </returns>
        /// <response code="404">Filme não encontrado </response>
        /// <response code="204">Atualização do filme realizada com sucesso </response>

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

        /// <summary> 
        /// Remoção do filme
        /// </summary>
        /// <param name="id"> Id do filme </param>
        /// <returns> Remoção do Filme </returns>
        /// <response code="404">Filme não encontrado </response>
        /// <response code="204">Remoção do filme realizada com sucesso </response>

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
