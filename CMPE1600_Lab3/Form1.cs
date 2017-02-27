using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using GDIDrawer;


namespace CMPE1600_Lab3
{
    

    public partial class Form1 : Form
    {
        //Circle structure
        [Serializable]
        public struct Circle
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
        //Global Variables
        List<Circle> circList = new List<Circle>();        
        CDrawer canvas = new CDrawer();
        Point ptClick;
        Color circColor = Color.Red;
        public Form1()
        {
            InitializeComponent();           
        }

       
        //Starts draw timer and changes button text based
        //on previous state
        private void UI_DrawButton_Click(object sender, EventArgs e)
        {
            if (DrawTimer.Enabled)
            {
                UI_DrawButton.Text = "Draw";
                DrawTimer.Enabled = false;
            }
            else if (!DrawTimer.Enabled)
            {
                UI_DrawButton.Text = "Stop Draw";
                DrawTimer.Enabled = true;
            }


        }

        //On tick, checks for left mouse click,
        //draws circle at click coordinates,
        //and adds that circle to listview
        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            if (canvas.GetLastMouseLeftClick(out ptClick))
            {
                canvas.AddCenteredEllipse(ptClick.X, ptClick.Y, Convert.ToInt32(UI_DiameterUpDown.Text), Convert.ToInt32(UI_DiameterUpDown.Text), circColor);
                circList.Add(new Circle(Convert.ToInt32(UI_DiameterUpDown.Text), circColor, ptClick));
                listView1.Items.Clear();
                ListPop();

            }
        }

       


        private void UI_RedRadio_CheckedChanged(object sender, EventArgs e)
        {
            circColor = Color.Red;
        }

        private void UI_GreenRadio_CheckedChanged(object sender, EventArgs e)
        {
            circColor = Color.Green;
        }

        private void UI_BlueRadio_CheckedChanged(object sender, EventArgs e)
        {
            circColor = Color.Blue;
        }

        private void UI_EraseListButton_Click(object sender, EventArgs e)
        {
            circList.Clear();
            listView1.Items.Clear();
        }

        private void UI_EraseScreen_Click(object sender, EventArgs e)
        {
            canvas.Clear();
        }

        private void UI_SaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("circles.bin", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, circList);

                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lab 3", "Could not save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UI_OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("circles.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                circList = (List<Circle>)bf.Deserialize(fs);

                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lab 3", "Could not open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listView1.Items.Clear();
            ListPop();
            PlayBack();
        }
        private void UI_PlayBack_Click(object sender, EventArgs e)
        {
            PlayBack();
        }

        private void ListPop()
        {
            foreach (Circle n in circList)
            {
                ListViewItem addCirc = listView1.Items.Add(n._color.ToString());
                addCirc.SubItems.Add(n._center.X.ToString());
                addCirc.SubItems.Add(n._center.Y.ToString());
                addCirc.SubItems.Add(n._diameter.ToString());
            }
        }
        private void PlayBack()
        {
            foreach (Circle n in circList)
            {
                canvas.AddCenteredEllipse(n._center.X, n._center.Y, n._diameter, n._diameter, n._color);
            }
        }

       
    }
}
