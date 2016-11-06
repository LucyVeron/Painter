using System;
using System.Windows.Forms;

namespace EnhancedPainter
{
    public partial class EnhancedPainterForm : Form
    {
        public EnhancedPainterForm()
        {
            InitializeComponent();
        }

        /* Open new drawing workspace when user selects New */
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPaintForm child = new NewPaintForm();
            child.MdiParent = this;
            child.Show();
            /* Keep child form maximized so it looks nicer */
            child.WindowState = FormWindowState.Maximized;
        }
         /* Quit the program if user selects Exit */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
