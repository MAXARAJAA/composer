using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace composer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jewelryBox = new JewelryBox { Name = "Моя шкатулка з прекрасами" };
            var topTray = new Tray { Name = "Верхній відсік" };
            //ringCompartment.AddContent("сапфірна прекраса");
            var ringCompartment = new Compartment { Name = "Нижній відсік" };

            ringCompartment.AddContent("золоте кільце");
            ringCompartment.AddContent("срібряне кільце");
            ringCompartment.AddContent("сапфірна прекраса");
            topTray.Add(ringCompartment);
            jewelryBox.Add(topTray);
            jewelryBox.Display(0, textBox1);



        }
    }
}
