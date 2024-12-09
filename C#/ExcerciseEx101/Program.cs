using ExerciseEX101;

Vector2D v1 = new Vector2D(1.1, 1.2);
Vector2D v2 = new Vector2D();
//v1.X = 1.1;
//v1.Y = 1.2;
v2.X = 1.7;
v2.Y = 1.8;

v1.Add(v2);

double a = v1.DotProduct(v2);

Console.WriteLine(v1.Y);
Console.WriteLine(a);

Console.ReadLine();
