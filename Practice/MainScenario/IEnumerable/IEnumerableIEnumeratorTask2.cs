using System.Collections;

namespace Practice.MainScenario.IEnumerable;

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

public class RectanglesCollection : IEnumerable<Rectangle>
{
    private Rectangle[] _rectangle;

    public RectanglesCollection(Rectangle[] rectangles) => _rectangle = rectangles;

    IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<Rectangle> GetEnumerator() => new RectangleEnumirator(_rectangle);

    public class RectangleEnumirator : IEnumerator<Rectangle>
    {
        private Rectangle[] _rectangles;
        private int _position;

        public RectangleEnumirator(Rectangle[] rectangles)
        {
            _rectangles = rectangles;
            _position = -1;
        }

        public bool MoveNext() => ++_position < _rectangles.Length;

        public void Reset() => _position = -1;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public Rectangle Current
        {
            get
            {
                if (_position < 0 || _position >= _rectangles.Length)
                    throw new ArgumentException();
                return _rectangles[_position];
            }
        }
    }
}

/*Тестовое данные*/
/*Rectangle[] rectangles = new Rectangle[]
{
    new Rectangle(5, 10),
    new Rectangle(3, 8),
    new Rectangle(4, 6)
};

RectanglesCollection collection = new RectanglesCollection(rectangles);

foreach (Rectangle rectangle in collection)
{
    Console.WriteLine(rectangle.Width + " x " + rectangle.Height);
}*/