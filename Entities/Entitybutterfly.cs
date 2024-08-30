namespace FlyingButterfly.Entities;
public class Entitybutterfly : Entitysimplebutterfly
{
    public Color SecondarylColor { get; private set; }

    public bool Pattern { get; private set; }

    public bool Antennae { get; private set; }

    public void Init(int speed, double weight, Color mainColor, Color secondaryColor, bool pattern, bool antennae)
    {
        SecondarylColor = secondaryColor;
        Pattern = pattern;
        Antennae = antennae;
    }
}
