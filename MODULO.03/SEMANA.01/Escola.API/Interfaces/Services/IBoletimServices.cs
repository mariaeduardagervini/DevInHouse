﻿using Escola.API.Model;

namespace Escola.API.Interfaces.Services
{
    public interface IBoletimServices
    {
        public Boletim ObterPorId(int id);
        public List<Boletim> ObterPorAluno(int alunoId);
        Boletim Cadastrar(Boletim boletim);
        Boletim Atualizar(Boletim boletim);
        void Excluir(int id);
       
       
    }
}
