namespace TestSzuperhosProjekt
{
    public class KepregenyTest
    {
        
        public KepregenyTest()
        {
            Kepregeny.szuperhosok = new List<ISzuperhos>();
        }


        [Fact]
        public void Szereplok()
        {
            Kepregeny.Szereplok("szuperhos.txt");
            Assert.Equal(6, Kepregeny.szuperhosok.Count);
        }

        [Fact]
        public void Szuperhosok()
        {
            Kepregeny.szuperhosok = new List<ISzuperhos>
            {
                new Vasember(),
                new Batman()
            };
            string expected = "Vasember: Szupererő: 150; van gyengesége"
                + Environment.NewLine + "Batman: leleményesség: 100"
                + Environment.NewLine;
            var sw = new StringWriter();
            Console.SetOut(sw);
            Kepregeny.Szuperhosok();
            string output = sw.ToString();
            Assert.Equal(expected, output);
        }
    }
}