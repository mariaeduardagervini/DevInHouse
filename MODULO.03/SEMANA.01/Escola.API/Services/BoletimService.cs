using DocumentFormat.OpenXml.Office2010.Excel;
using Escola.API.Interfaces.Repositories;
using Escola.API.Interfaces.Services;
using Escola.API.Model;

namespace Escola.API.Services
{
    public class BoletimService : IBoletimServices
    {
        private readonly IBoletimRepository _boletimRepository;
        private readonly IAlunoService _alunoService;

        public BoletimService(IBoletimRepository boletimRepository, IAlunoService alunoService)
        {
            _boletimRepository = boletimRepository;
            _alunoService = alunoService;
        }
        
        public Boletim ObterPorId(int id)
        {
            return ObterPorId(id);
        }

        public Boletim Atualizar(Boletim boletim, int id)
        {
            var boletimDb = _boletimRepository.ObterPorId(id);

            if (boletimDb == null)
            {
                throw new NotImplementedException("");
            }
                boletimDb.Update(boletim);

                _boletimRepository.Atualizar(boletim);
                return boletimDb;
        }

        public Boletim Cadastrar(Boletim boletim)
        {
            if (_alunoService.ObterPorId(boletim.AlunoId) == null)
            {
                throw new NotImplementedException("Aluno não cadastrado");
            }
            _boletimRepository.Inserir(boletim);
            return boletim;
        }

        public void Excluir(int id)

        {
            var boletim = _boletimRepository.ObterPorId(id);

            if(boletim == null)
            {
                throw new NotImplementedException("Boletim não cadastrado!");

            }

            _boletimRepository.Excluir(boletim);
            
        }

        public List<Boletim> ObterPorAluno(int alunoId)
        {
            return ObterPorAluno(alunoId);
        }

        public Boletim Atualizar(Boletim boletim)
        {
            throw new NotImplementedException();
        }
    }
}
