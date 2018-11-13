using System;
using System.Drawing;
using System.Windows.Forms;

namespace KotorTool_2._0.Utils
{
  public class UtilWindowRelativePositioner
  {
    private readonly Form _pForm;
    private readonly Form _cForm;

    public UtilWindowRelativePositioner()
    {
    }

    public UtilWindowRelativePositioner(Form parentForm, Form childForm)
    {
      _pForm = parentForm;
      _cForm = childForm;
    }

    public Point GetConcentric()
    {
      Point point = new Point();
      Size size = _cForm.Size;
      Rectangle screen = _pForm.RectangleToScreen(_pForm.ClientRectangle);
      Rectangle workingArea = Screen.GetWorkingArea(_pForm);
      point.X = checked ((int) Math.Round(checked (screen.Left + screen.Right - size.Width) / 2.0));
      if (point.X < workingArea.X)
        point.X = workingArea.X;
      else if (checked (point.X + size.Width) > checked (workingArea.X + workingArea.Width))
        point.X = checked (workingArea.X + workingArea.Width - size.Width);
      point.Y = checked ((int) Math.Round(checked (screen.Top + screen.Bottom - size.Height) / 2.0));
      if (point.Y < workingArea.Y)
        point.Y = workingArea.Y;
      else if (checked (point.Y + size.Height) > checked (workingArea.Y + workingArea.Height))
        point.Y = checked (workingArea.Y + workingArea.Height - size.Height);
      return point;
    }

    public void SetLocationConcentric()
    {
      ((Control) _cForm).Location = GetConcentric();
    }
  }
}
