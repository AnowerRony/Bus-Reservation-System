using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusReserve.Pages
{
    public partial class AdminPanel : Form
    {
        int PanelWidth;
        bool Hided;
        public AdminPanel()
        {
            InitializeComponent();
            PanelWidth = slidingPanel.Width;
            Hided = false;
        }

        private void menuSlideButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Hided)
            {
                slidingPanel.Width = slidingPanel.Width + 20;
                if(slidingPanel.Width >= PanelWidth)
                {
                    timer1.Stop();
                    Hided = false;
                }
            }
            else
            {
                slidingPanel.Width = slidingPanel.Width - 20;
                if(slidingPanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                }
            }
        }
    }
}
