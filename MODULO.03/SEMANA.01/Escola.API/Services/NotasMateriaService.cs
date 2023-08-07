using Escola.API.Exceptions;
using Escola.API.Interfaces.Repositories;
using Escola.API.Interfaces.Services;
using Escola.API.Model;

namespace Escola.API.Services
{
    public class NotasMateriaService : INotasMateriaService
    {
        private readonly INotasMateriaRepository _notasMateriaRepository;

        public NotasMateriaService(INotasMateriaService notasMateriaRepository)
        {
            _notasMateriaRepository = notasMateriaRepository;
        }

        public NotasMateria Atualizar(NotasMateria notasMateria)
        {
            var notasMateriaDb = _notasMateriaRepository.ObterPorId(notasMateria.Id);

            notasMateriaDb.Update(notasMateria);

            _notasMateriaRepository.Atualizar(notasMateriaDb);

            return notasMateriaDb;
        }

        public NotasMateria Cadastrar (NotasMateria notasMateria)
        {
            ValidarNotas(notasMateria);

            _notasMateriaRepository.Inserir(notasMateria);

            return notasMateria;
        }

        private void ValidarNotas(NotasMateria notasMateria)
        {
            if (notasMateria.Nota < 0)
            {
                throw new ArgumentOutOfRangeException("Nota", notasMateria.Nota, "Nota deve ser maior ou igual a 0");
            }
            else if (notasMateria.Nota > 10)
            {
                throw new ArgumentOutOfRangeException("Nota", notasMateria.Nota, "Nota deve ser menor ou igual a 10");
            }
        }

        public NotasMateria Excluir(int id)
        {
            var notasMateria = _notasMateriaRepository.ObterPorId(id) ?? throw new ArgumentException();

            _notasMateriaRepository.Excluir(notasMateria);
        }

        public List<NotasMateria> ObterNotasMaterias(int id)
        {
            throw new NotImplementedException();
        }

        public List<NotasMateria> ObterNotasMaterias() => _notasMateriaRepository;

        public List<NotasMateria> ObterPorBoletimId(int boletimId)
        {
            var notasMateria = _notasMateriaRepository.ObterPorBoletimId(boletimId);

            return notasMateria ?? throw new NotFoundException("Relação No");
        }

        public NotasMateria ObterPorId(int id)
        {
            var notasMateria = _notasMateriaRepository.ObterPorId(id) ?? throw new ArgumentException();

            return notasMateria;
        }
    }
}
