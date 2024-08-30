using FlyingButterfly.Drawings;

namespace FlyingButterfly;

public partial class Form1 : Form
{
    private Drawingbutterfly? _drawingbutterfly;
    private Graphics g;

    public Form1()
    {
        InitializeComponent();
    }

    private void CreateObject(string type)
    {
        Random random = new();
        switch (type)
        {
            case nameof(Drawingbutterfly):
                _drawingbutterfly = new Drawingbutterfly(random.Next(100, 300), random.Next(1200, 3600), Color.FromArgb(random.Next(0, 128), random.Next(0, 128), random.Next(0, 128)),
                    Color.FromArgb(random.Next(127, 256), random.Next(127, 256), random.Next(127, 256)),
                    Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)),
                    Convert.ToBoolean(random.Next(0, 2)));
                break;

            case nameof(Drawingsimplebutterfly):

                break;
            default:
                return;
        }
        _drawingbutterfly.SetPictureSize(pictureBox.Width, pictureBox.Height);
        _drawingbutterfly.SetPosition(random.Next(10, 100), random.Next(10, 100));
        Bitmap bmp = new(pictureBox.Width, pictureBox.Height);
        Graphics g = Graphics.FromImage(bmp);
        _drawingbutterfly.DrawButterfly(g);
        pictureBox.Image = bmp;
    }

    private void buttoncreate_Click(object sender, EventArgs e) => CreateObject(nameof(Drawingbutterfly));
  
    private void buttonmove_Click(object sender, EventArgs e)
    {
        if (_drawingbutterfly == null)
        {
            return;
        }
        string name = ((Button)sender)?.Name ?? string.Empty;
        bool result = false;
        switch (name)
        {
            case "buttonup":
                result = _drawingbutterfly.MoveButterfly(Directionbutterfly.Up);
                break;
            case "buttondown":
                result = _drawingbutterfly.MoveButterfly(Directionbutterfly.Down);
                break;
            case "buttonleft":
                result = _drawingbutterfly.MoveButterfly(Directionbutterfly.Left);
                break;
            case "buttonright":
                result = _drawingbutterfly.MoveButterfly(Directionbutterfly.Right);
                break;
        }

        if (result)
        {
            Bitmap bmp = new(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            _drawingbutterfly.DrawButterfly(g);
            pictureBox.Image = bmp;
        }
    }
}
