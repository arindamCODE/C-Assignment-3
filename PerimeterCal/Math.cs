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
        s1 = tp.Side1;
        b = tp.Bas;
        s2 = tp.Side2;
        return s1+b+s2;
    } 

    public int CalculatePerimeter(int l, int w)
    {
        l = rp.Length;
        w = rp.Width;
        return 2*(l+w);
    }
    public int CalculatePerimeter(int s)
    {
        s = sp.Side;
        return 4*s;
    }
}