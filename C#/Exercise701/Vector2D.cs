using System;
namespace Exercise701;

public class Vector2D
{
    // public double x, y;

    public double X { get; set; }
    public double Y { get; set; }

    public void Add(Vector2D v)
	{
		this.X += v.X;
		this.Y += v.Y;
	}
    public void Sub(Vector2D v)
    {
        this.X -= v.X;
        this.Y -= v.Y;
    }

	public void Mul(double k)
	{
        this.X *= k;
        this.Y *= k;
    }

    public double DotProduct(Vector2D v)
    {
        return this.X * v.X + this.Y * v.Y;
    }
}
