using Escola.API.Exceptions;
using Escola.API.Interfaces.Repositories;
using Escola.API.Interfaces.Services;
using Escola.API.Model;

namespace Escola.API.Services
{
    public class MateriaService : IMateriaService
    {
        private readonly IMateriaRepository _materiaRepository;

        public MateriaService(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        public MateriaService Atualizar(Materia materia)
        {
            var materiaDb = _materiaRepository.ObterPorId(materia.Id);

            if(materiaDb == null)
            {
                throw new NotFoundException("Matéria não cadastrada");
            }

            materiaDb.Update(materia);

            _materiaRepository.Atualizar(materiaDb);
            return materiaDb;

        }
        public Materia Cadastrar(Materia materia)
        {
            if (_materiaRepository.ObterPorNome(materia.Nome) != null)
            {
                throw new RegistroDuplicadoException("Matéria já cadastrada!");
            }

            _materiaRepository.Inserir(materia);
            return materia;
        }

        public void Excluir(int id)
        {
            var materia = _materiaRepository.ObterPorId(id) ?? throw new NotFoundException();

            _materiaRepository.Excluir(materia);
          
        }
    }
}
