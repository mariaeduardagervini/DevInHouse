﻿using Escola.API.Model;

namespace Escola.API.Interfaces.Repositories
{
    public interface INotasMateriaRepository : IBaseRepository<NotasMateria, int>
    {
        List<NotasMateria> ObterPorBoletimId(int boletimId);
    }
}