using FlyingButterfly.Entities;

namespace FlyingButterfly.Drawings;

public class Drawingbutterfly
{
    public Entitybutterfly? Entitybutterfly { get; private set; }
    private int? _picturewidth;
    private int? _pictureheight;
    private int? _startposX;
    private int? _startposY;
    private readonly int _drawbutterflywidth = 100;
    private readonly int _drawbutterflyheight = 100;

    public Drawingbutterfly(int v1, int v2, Color color1, Color color2, bool v3, bool v4, bool v5)
    {
    }

    public Drawingbutterfly()
    {
    }

    public void Init(int speed, double weight, Color mainColor, Color secondaryColor, bool pattern, bool antennae, bool v)
    {
        Entitybutterfly = new Entitybutterfly();
        Entitybutterfly.Init(speed, weight, mainColor, secondaryColor, pattern, antennae);
        _picturewidth = null;
        _pictureheight = null;
        _startposX = null;
        _startposY = null;
    }

    public bool SetPictureSize(int width, int height)
    {
        _picturewidth = width;
        _pictureheight = height;
        return true;
    }

    public void SetPosition(int x, int y)
    {
        if (!_pictureheight.HasValue || !_picturewidth.HasValue)
        {
            return;
        }
        _startposX = x;
        _startposY = y;
    }
    public bool MoveButterfly(Directionbutterfly direction)
    {
        if (Entitybutterfly == null || !_pictureheight.HasValue || !_picturewidth.HasValue)
        {
            return false;
        }
        switch (direction)
        {
            case Directionbutterfly.Left:
                if (_startposX.Value - Entitybutterfly.Step > 0)
                {
                    _startposX -= (int)Entitybutterfly.Step;
                }
                return true;

            case Directionbutterfly.Up:
                if (_startposY.Value - Entitybutterfly.Step > 0)
                {
                    _startposY -= (int)Entitybutterfly.Step;
                }
                return true;

            case Directionbutterfly.Right:
                if (_startposX.Value - Entitybutterfly.Step > 0)
                {
                    _startposX += (int)Entitybutterfly.Step;
                }
                return true;
            case Directionbutterfly.Down:
                if (_startposY.Value - Entitybutterfly.Step > 0)
                {
                    _startposY += (int)Entitybutterfly.Step;
                }
                return true;
            default:
                return false;
        }
    }

    public void DrawButterfly(Graphics g)
    {
        if (Entitybutterfly == null || !_pictureheight.HasValue || !_picturewidth.HasValue)
        {
            return;
        }
        Pen pen = new(Color.Black);
        Brush mainbrush = new SolidBrush(Entitybutterfly.MainColor);
        Brush secondarybrush = new SolidBrush(Entitybutterfly.SecondarylColor);

        //крылья
        g.DrawEllipse(pen, _startposX.Value + 20, _startposY.Value + 35, 25, 30);
        g.FillEllipse(mainbrush, _startposX.Value + 20, _startposY.Value + 35, 25, 30);
        g.DrawEllipse(pen, _startposX.Value + 40, _startposY.Value + 35, 25, 30);
        g.FillEllipse(mainbrush, _startposX.Value + 40, _startposY.Value + 35, 25, 30);

        g.DrawEllipse(pen, _startposX.Value, _startposY.Value, 40, 40);
        g.FillEllipse(mainbrush, _startposX.Value, _startposY.Value, 40, 40);
        g.DrawEllipse(pen, _startposX.Value + 45, _startposY.Value, 40, 40);
        g.FillEllipse(mainbrush, _startposX.Value + 45, _startposY.Value, 40, 40);
        g.DrawEllipse(pen, _startposX.Value + 15, _startposY.Value + 15, 30, 30);
        g.FillEllipse(mainbrush, _startposX.Value + 15, _startposY.Value + 15, 30, 30);
        g.DrawEllipse(pen, _startposX.Value + 40, _startposY.Value + 15, 30, 30);
        g.FillEllipse(mainbrush, _startposX.Value + 40, _startposY.Value + 15, 30, 30);

        // узор
        Pen blue = new(Color.Blue);
        if (Entitybutterfly.Pattern)
        {
            g.DrawEllipse(blue, _startposX.Value + 25, _startposY.Value + 35, 15, 25);
            g.FillEllipse(secondarybrush, _startposX.Value + 25, _startposY.Value + 35, 15, 25);
            g.DrawEllipse(blue, _startposX.Value + 45, _startposY.Value + 35, 15, 25);
            g.FillEllipse(secondarybrush, _startposX.Value + 45, _startposY.Value + 35, 15, 25);

            g.DrawEllipse(blue, _startposX.Value + 15, _startposY.Value + 15, 30, 30);
            g.FillEllipse(secondarybrush, _startposX.Value + 15, _startposY.Value + 15, 30, 30);
            g.DrawEllipse(blue, _startposX.Value + 40, _startposY.Value + 15, 30, 30);
            g.FillEllipse(secondarybrush, _startposX.Value + 40, _startposY.Value + 15, 30, 30);
        }

        //тело
        Brush black = new SolidBrush(Color.Black);
        g.FillEllipse(black, _startposX.Value + 37, _startposY.Value + 18, 10, 10);
        g.FillEllipse(black, _startposX.Value + 37, _startposY.Value + 25, 10, 20);
        g.FillEllipse(black, _startposX.Value + 36, _startposY.Value + 43, 12, 30);

        //aнтенны
        if (Entitybutterfly.Antennae)
        {
            g.DrawLine(pen, _startposX.Value + 33, _startposY.Value - 10, _startposX.Value + 40, _startposY.Value + 25);
            g.DrawLine(pen, _startposX.Value + 52, _startposY.Value - 10, _startposX.Value + 45, _startposY.Value + 25);
        }
    }

    internal void DrawButterfly(object g)
    {
        throw new NotImplementedException();
    }
}
