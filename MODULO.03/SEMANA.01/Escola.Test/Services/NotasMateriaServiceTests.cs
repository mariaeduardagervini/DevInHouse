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

                var notasMateria = new NotasMateria() { Nota = -1 };

                var expectedParam = "Nota";
                var expectedMessage = "Nota deve ser maior que 0";
                var expectedActualValue = -1;

                var ex = Assert.Throws<ArgumentOutOfRangeException>(() => { notasMateriaService.Cadastrar(notasMateria); });


            Assert.AreEqual(expectedParam, ex.ParamName);
            Assert.AreEqual(expectedMessage, ex.Message);
            Assert.AreEqual(expectedActualValue, ex.ActualValue);
        }


        }
    }

