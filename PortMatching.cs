using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;


namespace WindowsFormsApp1
{
    internal class PortMatching
    {
        Form1 form1;
        Button[] buttons;

        private String font = "Calibri";
        private int fontSize = 15;

        public PortMatching(Form1 form1)
        {
            this.form1 = form1;
        }

        public void SetupPortMatching()
        {
            buttons = new Button[20];
            SetupAllButtons(buttons);
            LoadJson(buttons);

        }

        private void SetupAllButtons(Button[] buttons)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();  // Create button instance
                buttons[i].Font = new Font(font, fontSize);
                buttons[i].Location = new Point(150 + (i % 5) * 100, 150 + (i / 5) * 50);
                buttons[i].AutoSize = true;
                buttons[i].Tag = i;  // Store index for reference
                buttons[i].Click += Button_Click;  // Use generic handler
                form1.Controls.Add(buttons[i]);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {

        }

        private void LoadJson(Button[] btns)
        {
            string workingDir = Directory.GetCurrentDirectory();
            Console.WriteLine($"working dir: {workingDir}");


            string fileName = "ports.json";
            string jsonContent = File.ReadAllText(fileName);

            List<Port> ports = JsonSerializer.Deserialize<List<Port>>(jsonContent);

            for (int i = 0; i < btns.Length && i < ports.Count; i++)
            {
                buttons[i].Text = ports[i].name;
            }

        }



    }

    public class Port
    {
        public string name { get; set; }
        public string description { get; set; }
        public int[] portNum { get; set; }
    }
}