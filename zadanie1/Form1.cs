using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(listOfToys.GetItemText(listOfToys.SelectedItem))
            {
                case "Car": listOfCreated.Items.Add(new Car()); break;
                case "Submarine": listOfCreated.Items.Add(new Submarine()); break;
                case "Plane": listOfCreated.Items.Add(new Plane()); break;
                case "Computer": listOfCreated.Items.Add(new Computer()); break;
            }
        }

        private void listOfCreated_Click(object sender, EventArgs e)
        {
            if (listOfCreated.SelectedItem is IAccelerate)
            {
                groupBox1.Enabled = true;
                valueOfSpeed.Text = ((IAccelerate)listOfCreated.SelectedItem).getAccelerate().ToString();
            }
            else
            {
                groupBox1.Enabled = false;
                valueOfSpeed.Clear();
            }

            if (listOfCreated.SelectedItem is IDrive)
            {
                groupBox3.Enabled = true;
                valueOfDepth.Text = ((IDrive)listOfCreated.SelectedItem).getDrive().ToString();
            }
            else
            {
                groupBox3.Enabled = false;
                valueOfDepth.Clear();
            }

            if (listOfCreated.SelectedItem is IRise)
            {
                groupBox2.Enabled = true;
                valueOfAlt.Text = ((IRise)listOfCreated.SelectedItem).getRise().ToString();
            }
            else
            {
                groupBox2.Enabled = false;
                valueOfAlt.Clear();
            }
        }

        private void IncreaseSpeed_Click(object sender, EventArgs e)
        {
            if (listOfCreated.SelectedItem is IAccelerate)
            {
                IAccelerate tmp = (IAccelerate)listOfCreated.SelectedItem;
                tmp.setAccelerate(tmp.getAccelerate() + 1);
                valueOfSpeed.Text = tmp.getAccelerate().ToString();
            }
        }

        private void DecreaseSpeed_Click(object sender, EventArgs e)
        {
            if (listOfCreated.SelectedItem is IAccelerate)
            {
                IAccelerate tmp = (IAccelerate)listOfCreated.SelectedItem;
                tmp.setAccelerate(tmp.getAccelerate() - 1);
                valueOfSpeed.Text = tmp.getAccelerate().ToString();
            }
        }

        private void IncreaseAlt_Click(object sender, EventArgs e)
        {
            if (listOfCreated.SelectedItem is IRise)
            {
                IRise tmp = (IRise)listOfCreated.SelectedItem;
                tmp.setRise(tmp.getRise() + 1);
                valueOfAlt.Text = tmp.getRise().ToString();
            }
        }

        private void DecreaseAlt_Click(object sender, EventArgs e)
        {
            if (listOfCreated.SelectedItem is IRise)
            {
                IRise tmp = (IRise)listOfCreated.SelectedItem;
                tmp.setRise(tmp.getRise() - 1);
                valueOfAlt.Text = tmp.getRise().ToString();
            }
        }

        private void IncreaseDepth_Click(object sender, EventArgs e)
        {
            if (listOfCreated.SelectedItem is IDrive)
            {
                IDrive tmp = (IDrive)listOfCreated.SelectedItem;
                tmp.setDrive(tmp.getDrive() + 1);
                valueOfDepth.Text = tmp.getDrive().ToString();
            }
        }

        private void DecreaseDepth_Click(object sender, EventArgs e)
        {
            if (listOfCreated.SelectedItem is IDrive)
            {
                IDrive tmp = (IDrive)listOfCreated.SelectedItem;
                tmp.setDrive(tmp.getDrive() - 1);
                valueOfDepth.Text = tmp.getDrive().ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listOfCreated.Items.Remove(listOfCreated.SelectedItem);
            groupBox1.Enabled = false;
            valueOfSpeed.Clear();
            groupBox2.Enabled = false;
            valueOfAlt.Clear();
            groupBox3.Enabled = false;
            valueOfDepth.Clear();
        }
    }
}
