/*
    Refactorizar la clase aplicando buenas prácticas.
    Implementar una nueva figura Rectangulo.
    Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 */
namespace AlborChallenge
{
    public class Shapes
    {
        public string Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Shapes(string type, int witdh, int height = 0)
        {
            Type = type;
            Width = witdh;
            Height = height;
        }

        public static string PrintInformation(List<Shapes> shapes)
        {
            var result = "";
            if (shapes.Any())
            {
                for (var i = 0; i < shapes.Count; i++)
                {
                    var (area, perimeter) = shapes[i].Calc();
                    result += string.Format(Const.Shapes, shapes[i].Type, area, perimeter);
                }
            }
            else
                result = Const.NoShapes;
            return result;
        }

        public (decimal, decimal) Calc()
        {
            decimal area = 0;
            decimal perimeter = 0;
            switch (Type)
            {                 
                case Const.Square:
                    area = Width * Width;
                    perimeter = Width * 4;
                    break;
                case Const.Circle:
                    area = (decimal)Math.PI * (Width / 2m) * (Width / 2m);
                    perimeter = (decimal)Math.PI * (Width);
                    break;
                case Const.EquilateralTriangle:
                    area = ((decimal)Math.Sqrt(3) * Width * Width) / 4;
                    perimeter = Width * 3;
                    break;
                case Const.Rectangle: 
                    area = Width * Height;
                    perimeter = (Width * 2) + (Height * 2);
                    break;

            }
            return (Math.Round(area, 2), Math.Round(perimeter, 2));
        }
    }
}