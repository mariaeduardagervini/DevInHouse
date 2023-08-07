using Escola.API.Exceptions;
using Escola.API.Interfaces.Repositories;
using Escola.API.Model;
using Escola.API.Services;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Test.Services
{
    public class MateriaServiceTests
    {
        [Test]
        public void Materia_InserirNova_Sucesso()
        {
            //ARRANGE

            var materiaRepositoryMock = new Mock<IMateriaRepository>();
            materiaRepositoryMock.Setup(x => x.Inserir(It.IsAny<Materia>()))
                                .Returns<Materia>(x => x); 

            var materiaService = new MateriaService(materiaRepositoryMock.Object);


            var materia = new Materia() { Nome = "POO" };
            var expectedMateria = new Materia() { Nome = "POO" };
            //ACT

            var result = materiaService.Cadastrar(materia);

            //ASSERT

            Assert.AreEqual(JsonConvert.SerializeObject(expectedMateria), JsonConvert.SerializeObject(result));
        }

        [Test]
        public void Materia_InserirDuplicada_Falha()
        {
            //ARRANGE

    //        var materiaRepositoryMock = new Mock<IMateriaRepository>();
     //       materiaRepositoryMock.Setup(x => x.ObterPorNome(It.IsAny<string>()))
     //                            .Returns<string>(x =>
      //                           {
       //                              return new List<Materia>()
       //                              {
       //                                  new Materia()
        //                                 {
        //                                     Nome = x,
        //                                     Id = 1
        //                                 }
         //                            };
         //                        });

            var materiaRepositoryMock = new Mock<IMateriaRepository>();
            materiaRepositoryMock.Setup(x => x.ObterPorNome("POO"))
                                 .Returns(() =>
                                 {
                                     return new List<Materia>()
                                     {
                                         new Materia()
                                         {
                                             Nome = "POO",
                                             Id = 1
                                         }
                                     };
                                 });


            var materiaService = new MateriaService(materiaRepositoryMock.Object);


            var materia = new Materia() { Nome = "POO" };
            var expectedMessage = "Matéria já cadastrada!";
            //ACT



            //ASSERT

            var ex = Assert.Throws<RegistroDuplicadoException>(() =>
            {
                materiaService.Cadastrar(materia);

            });

            Assert.AreEqual(expectedMessage, ex.Message);
        }
    }
}
