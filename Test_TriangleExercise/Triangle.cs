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
            SetTriangleType();
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

        void SetTriangleType()
        {
            if(IsTriangleEquilateral())
            {
                type = TriangleType.Equilateral;
            }
            else if(IsTriangleIsosceles())
            {
                type = TriangleType.Isosceles;
            }
            else if(IsTriangleScalene())
            {
                type = TriangleType.Scalene;
            }
        }

        bool IsTriangleEquilateral()
        {
            if (a == b && b == c)
                return true;
            return false;
        }

        bool IsTriangleIsosceles()
        {
            if (a == b && b != c || b == c && c != a || a == c && c != b)
                return true;
            return false;
        }

        bool IsTriangleScalene()
        {
            if (a != b && a != c && b != c)
                return true;
            return false;
        }
    }


}
