using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
  public int BorderRadius { get; set; } = 5;

  protected override void OnPaint(PaintEventArgs e)
  {
    base.OnPaint(e);

    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

    using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, BorderRadius))
    {
      this.Region = new Region(path);

      // Opcional: desenhar borda personalizada se desejar
      using (Pen pen = new Pen(Color.Gray, 1))
      {
        e.Graphics.DrawPath(pen, path);
      }
    }
  }

  private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
  {
    GraphicsPath path = new GraphicsPath();
    int curve = radius * 2;

    path.StartFigure();
    path.AddArc(rect.X, rect.Y, curve, curve, 180, 90);
    path.AddArc(rect.Right - curve, rect.Y, curve, curve, 270, 90);
    path.AddArc(rect.Right - curve, rect.Bottom - curve, curve, curve, 0, 90);
    path.AddArc(rect.X, rect.Bottom - curve, curve, curve, 90, 90);
    path.CloseFigure();

    return path;
  }
}
