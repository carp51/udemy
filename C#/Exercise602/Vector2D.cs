using System;
namespace Exercise602;

public class Vector2D
{
	public double x, y;

	public void Add(Vector2D v)
	{
		this.x += v.x;
		this.y += v.y;
	}
    public void Sub(Vector2D v)
    {
        this.x -= v.x;
        this.y -= v.y;
    }

	public void Mul(double k)
	{
        this.x *= k;
        this.y *= k;
    }

    public double DotProduct(Vector2D v)
    {
        return this.x * v.x + this.y * v.y;
    }
}
