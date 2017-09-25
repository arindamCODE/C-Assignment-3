using System;

class Math
{
    TrianglePerimeter tp = new TrianglePerimeter();
    RectanglePerimeter rp = new RectanglePerimeter();
    SquarePerimeter sp = new SquarePerimeter();

    public Math(int s1, int b, int s2)
    {
        tp.Side1 = s1;
        tp.Bas = b;
        tp.Side2 = s2;
    }

    public Math(int l, int w)
    {
        rp.Length = l;
        rp.Width = w;
    }

    public Math(int s)
    {
        sp.Side = s;
    }  

    public int CalculatePerimeter(int s1, int b, int s2)
    {
        return s1+b+s2;
    } 

    public int CalculatePerimeter(int l, int w)
    {
        return 2*(l+w);
    }
    public int CalculatePerimeter(int s)
    {
        return 4*s;
    }
}