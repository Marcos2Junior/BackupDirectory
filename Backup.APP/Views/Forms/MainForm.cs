using Backup.APP.Classes;
using Backup.APP.Classes.Themes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Backup.APP.Views.Forms
{
    public class MainForm : Form
    {
        #region ctor
        public MainForm()
        {
            Load += new EventHandler(EventLoad);
        }
        #endregion
        #region fields
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        #endregion

        /// <summary>
        /// add event to control move form
        /// </summary>
        /// <param name="controls"></param>
        protected void AddMoveFormControl(Control[] controls)
        {
            foreach (var control in controls)
            {
                control.MouseUp += new MouseEventHandler(MouseMoveEvent);
                control.MouseDown += new MouseEventHandler(MouseDownEvent);
                control.MouseUp += new MouseEventHandler(MouseUpEvent);
            }
        }

        #region events form move
        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }
        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void EventLoad(object sender, EventArgs e)
        {
            new LanguageView().ChooseLanguage(new OpenForms());
        }
    }
}
