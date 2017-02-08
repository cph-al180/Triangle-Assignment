namespace Test_TriangleExercise {

    class Triangle {
        private int a { get; set; }
        private int b { get; set; }
        private int c { get; set; }
        private TriangleType type;

        public Triangle() {
        }

        public Triangle(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public TriangleType GetTriangleType() {
            return type;
        }

        public int GetA()
        {
            return a;
        }

        public int GetB()
        {
            return b;
        }

        public int GetC()
        {
            return c;
        }

        public void SetTriangleType()
        {
            if(a == b && b == c)
            {
                type = TriangleType.Equilateral;
            }
            else if(a == b && b != c || b == c && c != a || a == c && c != b)
            {
                type = TriangleType.Isosceles;
            }
            else if(a != b && a != c && b != c)
            {
                type = TriangleType.Scalene;
            }
        }
    }


}
