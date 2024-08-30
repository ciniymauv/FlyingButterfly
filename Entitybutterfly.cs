namespace FlyingButterfly;
public class Entitybutterfly
{
    public int Speed { get; private set; }

    public double Weight { get; private set; }

    public Color MainColor { get; private set; }

    public Color SecondarylColor { get; private set; }

    public bool Pattern { get; private set; }

    public bool Antennae { get; private set; }

    public double Step => Speed * 100 / Weight;

    public void Init(int speed, double weight, Color mainColor, Color secondaryColor, bool pattern, bool antennae)
    {
        Speed = speed;
        Weight = weight;
        MainColor = mainColor;
        SecondarylColor = secondaryColor;
        Pattern = pattern;
        Antennae = antennae;
    }
}
