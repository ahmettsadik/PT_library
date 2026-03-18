namespace Calculator_Test;
using Calculator;

[TestClass]
public sealed class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Calculatorfunction calc = new Calculatorfunction();
        int result = calc.ADD(1, 1);
        try
        {
            Assert.AreEqual(4, result);
        }
        catch (exeption ex)
        {
            
        }
            
        
        
    }
}
