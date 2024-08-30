namespace FlyingButterfly.Entities;

public class Entitysimplebutterfly
{
    public int Speed { get; private set; }

    public double Weight { get; private set; }

    public Color MainColor { get; private set; }

    public double Step => Speed * 100 / Weight;

    public void Init(int speed, double weight, Color mainColor)
    {
        Speed = speed;
        Weight = weight;
        MainColor = mainColor;
    }
}
