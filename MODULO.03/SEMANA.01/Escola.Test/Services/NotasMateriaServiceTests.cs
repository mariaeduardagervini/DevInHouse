using Escola.API.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.API.Interfaces.Repositories;
using Escola.API.Services;
using Newtonsoft.Json;

namespace Escola.Test.Services
{
    
        public class NotasMateriaServiceTests
        {
            [Test]
            public void Cadastrar_NotaMenorQueZero_returnError()
            {
                var notasMateriasRepositoryMock = new Mock<INotasMateriaRepository>();

                notasMateriasRepositoryMock.Setup(x => x.Inserir(It.IsAny<NotasMateria>()))
                                                        .Returns<NotasMateria>(x =>
                                                        {
                                                            x.Id = 10;
                                                            return x;
                                                        });

                var notasMateriaService = new NotasMateriaService((API.Interfaces.Services.INotasMateriaService)notasMateriasRepositoryMock.Object);

                var notasMateria = new NotasMateria() { Nota = 12 };

                var expectedParam = "Nota";
                var expectedMessage = "Nota deve ser maior que 0";
                var expectedActualValue = 12;

                var ex = Assert.Throws<ArgumentOutOfRangeException>(() => { notasMateriaService.Cadastrar(notasMateria); });


            Assert.AreEqual(expectedParam, ex.ParamName);
            Assert.AreEqual(expectedMessage, ex.Message);
            Assert.AreEqual(expectedActualValue, ex.ActualValue);
        }


        [Test]
        public void Cadastrar_NotaMaiorQueZeroeMenorqueDez_returnSucess()
        {
            var notasMateriasRepositoryMock = new Mock<INotasMateriaRepository>();

            notasMateriasRepositoryMock.Setup(x => x.Inserir(It.IsAny<NotasMateria>()))
                                                    .Returns<NotasMateria>(x =>
                                                    {
                                                        x.Id = 10;
                                                        return x;
                                                    });

            var notasMateriaService = new NotasMateriaService((API.Interfaces.Services.INotasMateriaService)notasMateriasRepositoryMock.Object);

            var notasMateria = new NotasMateria() { Nota = 8 };

            var expectedNotasMateria = new NotasMateria() { Nota = 8, Id = 10 };
            

             var result = notasMateriaService.Cadastrar(notasMateria);


            Assert.AreEqual(JsonConvert.SerializeObject(expectedNotasMateria), JsonConvert.SerializeObject(result));
        }



    }
}

