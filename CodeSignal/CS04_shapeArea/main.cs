int shapeArea(int n) => (int)Math.Pow(n + n - 1, 2) - ((n - 1) * (n * 2));
//Уменьшаемое - площадь всего квадрата, вычитаемое - боковые треугольники. 