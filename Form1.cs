using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private String addressToConvert;
        private String subnetMask;
        private String[] addressOctets;
        private String[] subnetOctets;
        private TextBox[] octetBoxes;

        public Form1()
        {
            addressToConvert = "165.245.12.88/24";
            subnetMask = "255.255.255.0";
            addressOctets = addressToConvert.Split('.'); 
            subnetOctets = subnetMask.Split('.');

            int fontSize = 15;
            String font = "Calibri";

            InitializeComponent();
            dataGridView1.Rows.Add("/1", "/9", "/17", "/25", "128", "2", "128");
            dataGridView1.Rows.Add("/2", "/10", "/18", "/26", "192", "4", "64");
            dataGridView1.Rows.Add("/3", "/11", "/19", "/27", "224", "8", "32");
            dataGridView1.Rows.Add("/4", "/12", "/20", "/28", "240", "16", "16");
            dataGridView1.Rows.Add("/5", "/13", "/21", "/29", "248", "32", "8");
            dataGridView1.Rows.Add("/6", "/14", "/22", "/30", "252", "64", "4");
            dataGridView1.Rows.Add("/7", "/15", "/23", "/31", "254", "128", "2");
            dataGridView1.Rows.Add("/8", "/16", "/24", "/32", "255", "256", "1");


            Label label1 = new Label();
            label1.Font = new Font(font, 25);
            label1.AutoSize = true;
            label1.Text = "7 second subnetting";
            label1.Padding = new Padding(5);
            label1.Location = new Point(280, 10);
            this.Controls.Add(label1);

            textBox1.Text = ("Address to Convert");
            textBox1.Font = new Font(font, fontSize);
            textBox1.ReadOnly = true;

            textBox2.Text = (addressToConvert);
            textBox2.Font = new Font(font, fontSize);
            textBox2.ReadOnly = true;

            textBox7.Text = ("Subnet Mask");
            textBox7.Font = new Font(font, fontSize);
            textBox7.ReadOnly = true;

            textBox8.Text = (subnetMask);
            textBox8.Font = new Font(font, fontSize);
            textBox8.ReadOnly = true;


            // CONVERSION TABLE LABELS
            textBox3.Text = ("Address") ;
            textBox3.Font = new Font(font, fontSize);
            textBox3.ReadOnly = true;

            textBox4.Text = ("Mask");
            textBox4.Font = new Font(font, fontSize);
            textBox4.ReadOnly = true;

            textBox5.Text = ("Net");
            textBox5.Font = new Font(font, fontSize);
            textBox5.ReadOnly = true;

            textBox6.Text = ("Broadcast");
            textBox6.Font = new Font(font, fontSize);
            textBox6.ReadOnly = true;


            // USER TABLE ENTRY
            octetBox1.Text = ("");
            octetBox1.Font = new Font(font, fontSize);
            octetBox1.ReadOnly = false;

            octetBox2.Text = ("");
            octetBox2.Font = new Font(font, fontSize);
            octetBox2.ReadOnly = false;

            octetBox3.Text = ("");
            octetBox3.Font = new Font(font, fontSize);
            octetBox3.ReadOnly = false;

            octetBox4.Text = ("");
            octetBox4.Font = new Font(font, fontSize);
            octetBox4.ReadOnly = false;

            // ROW 2
            octetBox1R2.Text = ("");
            octetBox1R2.Font = new Font(font, fontSize);
            octetBox1R2.ReadOnly = false;

            octetBox2R2.Text = ("");
            octetBox2R2.Font = new Font(font, fontSize);
            octetBox2R2.ReadOnly = false;

            octetBox3R2.Text = ("");
            octetBox3R2.Font = new Font(font, fontSize);
            octetBox3R2.ReadOnly = false;

            octetBox4R2.Text = ("");
            octetBox4R2.Font = new Font(font, fontSize);
            octetBox4R2.ReadOnly = false;

            // ROW 3
            octetBox1R3.Text = ("");
            octetBox1R3.Font = new Font(font, fontSize);
            octetBox1R3.ReadOnly = false;

            octetBox2R3.Text = ("");
            octetBox2R3.Font = new Font(font, fontSize);
            octetBox2R3.ReadOnly = false;

            octetBox3R3.Text = ("");
            octetBox3R3.Font = new Font(font, fontSize);
            octetBox3R3.ReadOnly = false;

            octetBox4R3.Text = ("");
            octetBox4R3.Font = new Font(font, fontSize);
            octetBox4R3.ReadOnly = false;

            // ROW 4
            octetBox1R4.Text = ("");
            octetBox1R4.Font = new Font(font, fontSize);
            octetBox1R4.ReadOnly = false;

            octetBox2R4.Text = ("");
            octetBox2R4.Font = new Font(font, fontSize);
            octetBox2R4.ReadOnly = false;

            octetBox3R4.Text = ("");
            octetBox3R4.Font = new Font(font, fontSize);
            octetBox3R4.ReadOnly = false;

            octetBox4R4.Text = ("");
            octetBox4R4.Font = new Font(font, fontSize);
            octetBox4R4.ReadOnly = false;

            // button
            button1.Text = ("ENTER");
            button1.Font = new Font(font, fontSize);

            //octetBoxes
            octetBoxes = new TextBox[] { octetBox1, octetBox2, octetBox3, octetBox4, octetBox1R2, octetBox2R2, octetBox3R2, octetBox4R2, octetBox1R3, octetBox2R3, octetBox3R3, octetBox4R3, octetBox1R4, octetBox2R4, octetBox3R4, octetBox4R4 };
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void octetBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void octectBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void compareUserEntryRow1(String[] stringToBreakup)
        {
            String toCompare;
            String userEntry;
            int lengthBoxes = octetBoxes.Length / 2;

            for (int i = 0; i < octetBoxes.Length; i++)
            {
                toCompare = stringToBreakup[i];
                userEntry = octetBoxes[i].Text;
                Console.WriteLine("to compare: " + toCompare + "    userentry: " + userEntry);

                if (userEntry == toCompare)
                {
                    octetBoxes[i].BackColor = Color.Green;
                }
                else
                {
                    octetBoxes[i].BackColor = Color.Red;
                }
            }
        }

        public String[] CalculateNet(String[] addressToCalc, String[] subnetToCalc)
        {
            String[] networkAddOctets = new string[addressToCalc.Length];

            for (int i = 0; i < addressToCalc.Length; i++)
            {
                if (subnetToCalc[i] == "255")
                {
                    networkAddOctets[i] = addressToCalc[i];
                }
                else if (subnetToCalc[i] == "0")
                {
                    networkAddOctets[i] = "0";
                }
            } 
            return networkAddOctets;
        }

        public String[] CalculateBroad(String[] addressToCalc, String[] subnetToCalc)
        {
            String[] broadcastAddOctets = new string[addressToCalc.Length];

            for (int i = 0; i < addressToCalc.Length; i++)
            {
                if (subnetToCalc[i] == "255")
                {
                    broadcastAddOctets[i] = addressToCalc[i];
                }
                else if (subnetToCalc[i] == "0")
                {
                    broadcastAddOctets[i] = "255";
                }
            }
            return broadcastAddOctets;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String[] combined = addressOctets.Concat(subnetOctets).ToArray();
            String[] networkAddress = CalculateNet(addressOctets, subnetOctets);
            String[] broadcastAddress = CalculateBroad(addressOctets, subnetOctets);
            combined = combined.Concat(networkAddress).ToArray();
            combined = combined.Concat(broadcastAddress).ToArray();
            Console.WriteLine("combined array length: " + combined.Length);
            compareUserEntryRow1(combined);
            Console.WriteLine("network address: " + String.Join(",", networkAddress));
            Console.WriteLine("broadcast address: " + String.Join(",",  broadcastAddress));
        }
    }
}
