using System.Drawing;
using System.Windows.Forms;

namespace Backup.APP.Views.Forms
{
    public class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        protected new void MouseMove()
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        protected new void MouseDown()
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        protected new void MouseUp()
        {
            dragging = false;
        }
    }
}
