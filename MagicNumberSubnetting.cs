using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class MagicNumberSubnetting
    {
        private TextBox octetBox1, octetBox2, octetBox3, octetBox4;
        private TextBox octetBox1R2, octetBox2R2, octetBox3R2, octetBox4R2;
        private TextBox octetBox1R3, octetBox2R3, octetBox3R3, octetBox4R3;
        private TextBox octetBox1R4, octetBox2R4, octetBox3R4, octetBox4R4;
        private TextBox[] octetBoxes;
        private Button button1, button2, backButton;
        private TextBox textBox1, textBox2, textBox3, textBox4, textBox5, textBox6;

        private String addressToConvert;
        private int CIDRValue;
        private String[] addressOctets;
        private String[] subnetOctets;
        private String ipOnly;
        private Random rand = new Random();
        private DataGridView dataGridView1;
        private String font = "Calibri";
        private int fontSize = 15;
        private Form1 form1;

        public MagicNumberSubnetting(Form1 form1)
        {
            this.form1 = form1;
        }

        public void SetupMagicNumberMode()
        {
            SetupInitialValues();
            SetupTableAndLabel();
            SetupAllTextBoxes();
            SetupAllButtons();
            SetupAllOctetBoxes();
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

        private void SetupTableAndLabel()
        {
            dataGridView1 = new DataGridView();
            DataGridViewTextBoxColumn Masks = new DataGridViewTextBoxColumn();
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridView1.Columns.Add("Masks", "Masks");
            dataGridView1.Columns.Add("Masks2", "Masks2");
            dataGridView1.Columns.Add("Masks3", "Masks3");
            dataGridView1.Columns.Add("Masks4", "Masks4");
            dataGridView1.Columns.Add("MasksDecimal", "MasksDecimal");
            dataGridView1.Columns.Add("Networks", "Networks");
            dataGridView1.Columns.Add("Addresses", "Addresses");

            dataGridView1.Rows.Add("/1", "/9", "/17", "/25", "128", "2", "128");
            dataGridView1.Rows.Add("/2", "/10", "/18", "/26", "192", "4", "64");
            dataGridView1.Rows.Add("/3", "/11", "/19", "/27", "224", "8", "32");
            dataGridView1.Rows.Add("/4", "/12", "/20", "/28", "240", "16", "16");
            dataGridView1.Rows.Add("/5", "/13", "/21", "/29", "248", "32", "8");
            dataGridView1.Rows.Add("/6", "/14", "/22", "/30", "252", "64", "4");
            dataGridView1.Rows.Add("/7", "/15", "/23", "/31", "254", "128", "2");
            dataGridView1.Rows.Add("/8", "/16", "/24", "/32", "255", "256", "1");
            dataGridView1.Size = new Size(745, 224);
            dataGridView1.Location = new Point(28, 79);

            form1.Controls.Add(dataGridView1);


            Label label1 = new Label();
            label1.Font = new Font(font, 25);
            label1.AutoSize = true;
            label1.Text = "Magic Number Subntting";
            label1.Padding = new Padding(5);
            label1.Location = new Point(280, 10);
            form1.Controls.Add(label1);
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

        private void SetupTextBox(TextBox box, string text, bool readOnly)
        {
            box.Text = text;
            box.Font = new Font(font, fontSize);
            box.ReadOnly = readOnly;
        }

        private void SetupAllTextBoxes()
        {
            textBox1 = new TextBox();
            SetupTextBox(textBox1, "Address to Convert", true);
            textBox1.Size = new Size(179, 20);
            textBox1.Location = new Point(28, 355);
            form1.Controls.Add(textBox1);

            textBox2 = new TextBox();
            SetupTextBox(textBox2, addressToConvert, true);
            textBox2.Size = new Size(179, 20);
            textBox2.Location = new Point(28, 381);
            form1.Controls.Add(textBox2);


            // CONVERSION TABLE LABELS
            textBox3 = new TextBox();
            SetupTextBox(textBox3, "Address", true);
            textBox3.Size = new Size(100, 20);
            textBox3.Location = new Point(239, 355);
            form1.Controls.Add(textBox3);

            textBox4 = new TextBox();
            SetupTextBox(textBox4, "Mask", true);
            textBox4.Size = new Size(100, 20);
            textBox4.Location = new Point(239, 381);
            form1.Controls.Add(textBox4);

            textBox5 = new TextBox();
            SetupTextBox(textBox5, "Network", true);
            textBox5.Size = new Size(100, 20);
            textBox5.Location = new Point(239, 408);
            form1.Controls.Add(textBox5);

            textBox6 = new TextBox();
            SetupTextBox(textBox6, "Broadcast", true);
            textBox6.Size = new Size(100, 20);
            textBox6.Location = new Point(239, 435);
            form1.Controls.Add(textBox6);


            // ROW 1
            octetBox1 = new TextBox();
            SetupTextBox(octetBox1, "", false);
            octetBox1.Size = new Size(100, 20);
            octetBox1.Location = new Point(355, 356);
            form1.Controls.Add(octetBox1);

            octetBox2 = new TextBox();
            SetupTextBox(octetBox2, "", false);
            octetBox2.Size = new Size(100, 20);
            octetBox2.Location = new Point(461, 356);
            form1.Controls.Add(octetBox2);

            octetBox3 = new TextBox();
            SetupTextBox(octetBox3, "", false);
            octetBox3.Size = new Size(100, 20);
            octetBox3.Location = new Point(567, 356);
            form1.Controls.Add(octetBox3);

            octetBox4 = new TextBox();
            SetupTextBox(octetBox4, "", false);
            octetBox4.Size = new Size(100, 20);
            octetBox4.Location = new Point(673, 356);
            form1.Controls.Add(octetBox4);

            // ROW 2
            octetBox1R2 = new TextBox();
            SetupTextBox(octetBox1R2, "", false);
            octetBox1R2.Size = new Size(100, 20);
            octetBox1R2.Location = new Point(355, 382);
            form1.Controls.Add(octetBox1R2);

            octetBox2R2 = new TextBox();
            SetupTextBox(octetBox2R2, "", false);
            octetBox2R2.Size = new Size(100, 20);
            octetBox2R2.Location = new Point(461, 382);
            form1.Controls.Add(octetBox2R2);

            octetBox3R2 = new TextBox();
            SetupTextBox(octetBox3R2, "", false);
            octetBox3R2.Size = new Size(100, 20);
            octetBox3R2.Location = new Point(567, 382);
            form1.Controls.Add(octetBox3R2);

            octetBox4R2 = new TextBox();
            SetupTextBox(octetBox4R2, "", false);
            octetBox4R2.Size = new Size(100, 20);
            octetBox4R2.Location = new Point(673, 382);
            form1.Controls.Add(octetBox4R2);

            // ROW 3
            octetBox1R3 = new TextBox();
            SetupTextBox(octetBox1R3, "", false);
            octetBox1R3.Size = new Size(100, 20);
            octetBox1R3.Location = new Point(355, 408);
            form1.Controls.Add(octetBox1R3);

            octetBox2R3 = new TextBox();
            SetupTextBox(octetBox2R3, "", false);
            octetBox2R3.Size = new Size(100, 20);
            octetBox2R3.Location = new Point(461, 408);
            form1.Controls.Add(octetBox2R3);

            octetBox3R3 = new TextBox();
            SetupTextBox(octetBox3R3, "", false);
            octetBox3R3.Size = new Size(100, 20);
            octetBox3R3.Location = new Point(567, 408);
            form1.Controls.Add(octetBox3R3);

            octetBox4R3 = new TextBox();
            SetupTextBox(octetBox4R3, "", false);
            octetBox4R3.Size = new Size(100, 20);
            octetBox4R3.Location = new Point(673, 408);
            form1.Controls.Add(octetBox4R3);

            // ROW 4
            octetBox1R4 = new TextBox();
            SetupTextBox(octetBox1R4, "", false);
            octetBox1R4.Size = new Size(100, 20);
            octetBox1R4.Location = new Point(355, 435);
            form1.Controls.Add(octetBox1R4);

            octetBox2R4 = new TextBox();
            SetupTextBox(octetBox2R4, "", false);
            octetBox2R4.Size = new Size(100, 20);
            octetBox2R4.Location = new Point(461, 435);
            form1.Controls.Add(octetBox2R4);

            octetBox3R4 = new TextBox();
            SetupTextBox(octetBox3R4, "", false);
            octetBox3R4.Size = new Size(100, 20);
            octetBox3R4.Location = new Point(567, 435);
            form1.Controls.Add(octetBox3R4);

            octetBox4R4 = new TextBox();
            SetupTextBox(octetBox4R4, "", false);
            octetBox4R4.Size = new Size(100, 20);
            octetBox4R4.Location = new Point(673, 435);
            form1.Controls.Add(octetBox4R4);
        }

        private void SetupAllButtons()
        {

            // enter button
            button1 = new Button();
            button1.Text = ("ENTER");
            button1.Font = new Font(font, fontSize);
            button1.Location = new Point(355, 488);
            button1.Size = new Size(75, 39);
            button1.Click += button1_Click;
            form1.Controls.Add(button1);

            // reset button
            button2 = new Button();
            button2.Text = ("TRY NEW IP");
            button2.Font = new Font(font, fontSize);
            button2.Location = new Point(37, 424);
            button2.Size = new Size(170, 39);
            button2.Click += button2_Click;
            form1.Controls.Add(button2);

            //back button
            backButton = new Button();
            backButton.Text = "Back to Main Menu";
            backButton.Font = new Font(font, fontSize);
            backButton.Location = new Point(30, 18);
            backButton.AutoSize = true;
            backButton.Click += backButton_Click;
            form1.Controls.Add(backButton);
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
                if (i < subnetCIDRDivide)
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
            Console.WriteLine("broadcast address: " + String.Join(",", broadcastAddress));
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

        private void backButton_Click(object sender, EventArgs e)
        {
            form1.SwitchMode(Form1.PracticeMode.MainMenu);
        }
    }
}
