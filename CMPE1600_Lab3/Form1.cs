using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using GDIDrawer;

namespace CMPE1600_Lab3
{
    [Serializable] public struct Circle
    {
        public int _diameter;
        public Point _center;
        public Color _color;
                
       public Circle(int diameter, Color color, Point point)
        {
            _diameter = diameter;
            _color = color;
            _center = point;
        }
    }

    public partial class Form1 : Form
    {
        List<Circle> circList = new List<Circle>();
        public Form1()
        {
            InitializeComponent();
            CDrawer canvas = new CDrawer();
        }

       

        private void UI_DrawButton_Click(object sender, EventArgs e)
        {
            DrawTimer.Enabled = true;


        }

        private void UI_OpenFile_Click(object sender, EventArgs e)
        {

        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
