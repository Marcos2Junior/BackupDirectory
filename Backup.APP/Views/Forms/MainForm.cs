using System.Drawing;
using System.Windows.Forms;

namespace Backup.APP.Views.Forms
{
    public class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Point dragFormPoint;
        protected new void MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        protected new void MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        protected new void MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(254, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(276, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(307, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 48);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(289, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 48);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(264, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 48);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(259, 175);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(47, 48);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(298, 131);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 48);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Location = new System.Drawing.Point(282, 143);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(47, 48);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel9.Location = new System.Drawing.Point(269, 160);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(47, 48);
            this.panel9.TabIndex = 6;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(918, 462);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }
    }
}
