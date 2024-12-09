using Exercise602;

Vector2D v1 = new Vector2D();
Vector2D v2 = new Vector2D();
v1.x = 1.1;
v1.y = 1.2;
v2.x = 1.7;
v2.y = 1.8;

v1.Add(v2);

double a = v1.DotProduct(v2);

Console.WriteLine(v1.y);
Console.WriteLine(a);

Console.ReadLine();
