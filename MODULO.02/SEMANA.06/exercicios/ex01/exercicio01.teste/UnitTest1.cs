using exercicio01;
namespace exercicio01.teste;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestandoSoma()
    {
        List<double> valores = new List<double>() {2, -5, 2.1, 3};
        double resultado = Soma.SomarAll(valores);
        double resultadoF = 2 + (-5) + 2.1 + 3;

        Assert.AreEqual(resultadoF, resultado);
    }
}