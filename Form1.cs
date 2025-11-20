using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private String addressToConvert;
        private String ipOnly;
        private String font = "Calibri";
        private String[] addressOctets;
        private String[] subnetOctets;
        private TextBox[] octetBoxes;
        private int CIDRValue;
        private int fontSize = 15;
        private Random rand = new Random();

        public Form1()
        {

            SetupInitialValues();

            InitializeComponent();

            SetupTableAndLabel();
            SetupAllTextBoxes();
            SetupAllButtons();
            SetupAllOctetBoxes();

        }

        private void SetupTextBox(TextBox box, string text, bool readOnly)
        {
            box.Text = text;
            box.Font = new Font(font, fontSize);
            box.ReadOnly = readOnly;
        }

        private void SetupAllTextBoxes()
        {
            SetupTextBox(textBox1, "Address to Convert", true);
            SetupTextBox(textBox2, addressToConvert, true);


            // CONVERSION TABLE LABELS
            SetupTextBox(textBox3, "Address", true);
            SetupTextBox(textBox4, "Mask", true);
            SetupTextBox(textBox5, "Network", true);
            SetupTextBox(textBox6, "Broadcast", true);


            // ROW 1
            SetupTextBox(octetBox1, "", false);
            SetupTextBox(octetBox2, "", false);
            SetupTextBox(octetBox3, "", false);
            SetupTextBox(octetBox4, "", false);

            // ROW 2
            SetupTextBox(octetBox1R2, "", false);
            SetupTextBox(octetBox2R2, "", false);
            SetupTextBox(octetBox3R2, "", false);
            SetupTextBox(octetBox4R2, "", false);

            // ROW 3
            SetupTextBox(octetBox1R3, "", false);
            SetupTextBox(octetBox2R3, "", false);
            SetupTextBox(octetBox3R3, "", false);
            SetupTextBox(octetBox4R3, "", false);

            // ROW 4
            SetupTextBox(octetBox1R4, "", false);
            SetupTextBox(octetBox2R4, "", false);
            SetupTextBox(octetBox3R4, "", false);
            SetupTextBox(octetBox4R4, "", false);
        }

        private void SetupTableAndLabel()
        {
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
        }

        private void SetupAllButtons()
        {

            // enter button
            button1.Text = ("ENTER");
            button1.Font = new Font(font, fontSize);

            // reset button
            button2.Text = ("TRY NEW IP");
            button2.Font = new Font(font, fontSize);
        }

        private void SetupAllOctetBoxes()
        {
            octetBoxes = new TextBox[] { octetBox1, octetBox2, octetBox3, octetBox4,
                octetBox1R2, octetBox2R2, octetBox3R2, octetBox4R2,
                octetBox1R3, octetBox2R3, octetBox3R3, octetBox4R3,
                octetBox1R4, octetBox2R4, octetBox3R4, octetBox4R4 };
        }

        private void SetupInitialValues()
        {
            String[] randomIp = randomizeIP();
            addressToConvert = String.Join(".", randomIp, 0, 4) + "/" + randomIp[4];

            ipOnly = addressToConvert.Substring(0, addressToConvert.IndexOf('/'));

            addressOctets = ipOnly.Split('.');
            CIDRValue = int.Parse(addressToConvert.Substring(addressToConvert.IndexOf('/') + 1));
        }

        public String[] randomizeIP()
        {
            String[] randomIPArray = new string[5];

            for (int i = 0; i < 4; i++)
            {
                int randomOctet = rand.Next(0, 256);
                randomIPArray[i] = randomOctet.ToString();
            }

            int randomCIDR = rand.Next(1, 33);
            String randomCIDRStr = randomCIDR.ToString();
            randomIPArray[4] = randomCIDRStr;

            return randomIPArray;
        }

        public void compareUserEntry(String[] stringToBreakup)
        {
            String toCompare;
            String userEntry;
            int lengthBoxes = octetBoxes.Length / 2;

            for (int i = 0; i < octetBoxes.Length; i++)
            {
                toCompare = stringToBreakup[i];
                userEntry = octetBoxes[i].Text;

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

        public String[] CalculateSubnet(int subnetCIDR)
        {
            String[] subnetAddress = new string[4];
            int subnetCIDRDivide = subnetCIDR / 8;
            int remainder = subnetCIDR % 8;
            int octetValue = 256 - (int)Math.Pow(2, 8 - remainder);

            for (int i = 0; i < 4; i++)
            {
                if ( i < subnetCIDRDivide)
                {
                    subnetAddress[i] = "255";
                }
                else if (i == subnetCIDRDivide && remainder != 0)
                {
                    subnetAddress[i] = octetValue.ToString();
                }
                else
                {
                    subnetAddress[i] = "0";
                }
            }
            return subnetAddress;
        }

        public String[] CalculateNet(String[] addressToCalc, String[] subnetToCalc)
        {
            String[] networkAddOctets = new string[addressToCalc.Length];
            int networkOct;

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
                else
                {
                    networkOct = Int32.Parse(subnetToCalc[i]) & Int32.Parse(addressToCalc[i]);
                    networkAddOctets[i] = networkOct.ToString();
                }
            } 
            return networkAddOctets;
        }

        public String[] CalculateBroad(String[] addressToCalc, String[] subnetToCalc, String[] networkToCalc)
        {
            String[] broadcastAddOctets = new string[addressToCalc.Length];
            int broadcastOct;

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
                else
                {
                    broadcastOct = Int32.Parse(networkToCalc[i]) | (~Int32.Parse(subnetToCalc[i]) & 0xFF);
                    broadcastAddOctets[i] = broadcastOct.ToString();
                }
            }
            return broadcastAddOctets;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            subnetOctets = CalculateSubnet(CIDRValue);

            String[] combined = addressOctets.Concat(subnetOctets).ToArray();
            String[] networkAddress = CalculateNet(addressOctets, subnetOctets);
            String[] broadcastAddress = CalculateBroad(addressOctets, subnetOctets, networkAddress);
            combined = combined.Concat(networkAddress).ToArray();
            combined = combined.Concat(broadcastAddress).ToArray();
            compareUserEntry(combined);

           Console.WriteLine("network address: " + String.Join(",", networkAddress));
           Console.WriteLine("broadcast address: " + String.Join(",",  broadcastAddress));
           Console.WriteLine("subnet address: " + String.Join(",", subnetOctets));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] randomIp = randomizeIP();
            addressToConvert = String.Join(".", randomIp, 0, 4) + "/" + randomIp[4];
            textBox2.Text = addressToConvert;

            ipOnly = addressToConvert.Substring(0, addressToConvert.IndexOf('/'));
            addressOctets = ipOnly.Split('.');
            CIDRValue = int.Parse(addressToConvert.Substring(addressToConvert.IndexOf('/') + 1));

            // Clear all textboxes
            foreach (TextBox box in octetBoxes)
            {
                box.Text = "";
                box.BackColor = Color.White;
            }
        }
    }
}
