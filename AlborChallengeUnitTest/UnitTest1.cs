using AlborChallenge;

namespace AlborChallengeUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestNoShape()
        {
            Assert.Equal(Const.NoShapes, Shapes.PrintInformation(new List<Shapes>()));
        }

        [Fact]
        public void TestSquare()
        {
            List<Shapes> shapes = new List<Shapes>()
            {
                new Shapes(Const.Square, 4)
            };
            string result = string.Format(Const.Shapes, Const.Square, 16, 16);
            Assert.Equal(result, Shapes.PrintInformation(shapes));
        }

        [Fact]
        public void TestTwoSquare()
        {
            List<Shapes> shapes = new List<Shapes>()
            {
                new Shapes(Const.Square, 4),
                new Shapes(Const.Square, 5)
            };
            string result = string.Format(Const.Shapes, Const.Square, 16, 16) +
                            string.Format(Const.Shapes, Const.Square, 25, 20);
            Assert.Equal(result, Shapes.PrintInformation(shapes));
        }

        [Fact]
        public void TestManyForms()
        {
            List<Shapes> shapes = new List<Shapes>()
            {
                new Shapes(Const.Square, 4),
                new Shapes(Const.Circle, 2),
                new Shapes(Const.Square, 5),
                new Shapes(Const.EquilateralTriangle, 5),
                new Shapes(Const.Circle, 3),
                new Shapes(Const.Circle, 2),
                new Shapes(Const.Rectangle, 5,6)
            };
            string result = string.Format(Const.Shapes, Const.Square, 16, 16) +
                            string.Format(Const.Shapes, Const.Circle, 3.14, 6.28) +
                            string.Format(Const.Shapes, Const.Square, 25, 20) +
                            string.Format(Const.Shapes, Const.EquilateralTriangle, 10.83, 15) +
                            string.Format(Const.Shapes, Const.Circle, 7.07, 9.42) +
                            string.Format(Const.Shapes, Const.Circle, 3.14, 6.28) +
                            string.Format(Const.Shapes, Const.Rectangle, 30, 22);
            Assert.Equal(result.Replace(".", ","), Shapes.PrintInformation(shapes));
        }

        [Fact]
        public void TestRectangle()
        {
            List<Shapes> shapes = new List<Shapes>()
            {
                new Shapes(Const.Rectangle, 4,2)
            };
            string result = string.Format(Const.Shapes, Const.Rectangle, 8, 12);
            Assert.Equal(result, Shapes.PrintInformation(shapes));
        }
    }
}