using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EscolaTest.Services
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

          var notasMateriaService = new notasMateriaService(notasMateriasRepositoryMock.Object);

            var notasMateria = new NotasMateria() { Nota = -1 };

            var expectedMessage = "Nota deve ser maior que 0";

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => { notasMateriaService.Cadastrar(notasMateria); });

            

            Assert.AreEqual(expectedMessage, ex.ParamName );
        }


    }
}
