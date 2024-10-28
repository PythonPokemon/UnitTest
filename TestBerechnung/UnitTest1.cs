using Calculator;
using Xunit;

namespace TestBerechnung
{
    public class UnitTest1
    {
        [Fact]
        public void Additiondergebnis()
        {
            // Arrange | Parameter vorgabe
            int a = 5;
            int b = 10;

            // Act | Handlung
            int ergebnis1 = Program.PlusBerechnung(a, b);

            // Assert | Erwartetes ergebnis1
            Assert.Equal(15, ergebnis1);  // Überprüft, ob das ergebnis1 15 ist
        }

        // Unittest 2
        [Fact]
        public void Subtraktionsergebnis()
        {
            // Arrange | Parametervorgabe
            int c = 30;
            int d = 20;


            // Act | Handlung
            int ergebnsi2 = Program.MinusBerechnung(c, d);

            // Assert | Erwartetes ergebnis2
            Assert.Equal(10, ergebnsi2);
        }

    }
}
