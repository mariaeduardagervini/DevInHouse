﻿using Escola.API.Model;

namespace Escola.API.Interfaces.Repositories
{
    public interface IBoletimRepository : IBaseRepository<Boletim, int>
    {
        List<Boletim> ObterPorAlunoId(int alunoId);
    }
}
