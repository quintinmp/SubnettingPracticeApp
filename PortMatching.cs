using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Linq;


namespace WindowsFormsApp1
{
    internal class PortMatching
    {
        Form1 form1;
        Button[] buttons;
        Button[] numButtons;
        Dictionary<int, String> answers;

        private String font = "Calibri";
        private int fontSize = 15;

        String answer1, answer2;

        public PortMatching(Form1 form1)
        {
            this.form1 = form1;
        }

        public void SetupPortMatching()
        {
            buttons = new Button[20];
            numButtons = new Button[20];
            SetupButtons(buttons);
            SetupNumButtons(numButtons);
            LoadJson(buttons);
            LoadNumJson(numButtons);

        }

        private void SetupButtons(Button[] buttons)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();  // Create button instance
                buttons[i].Font = new Font(font, fontSize);
                buttons[i].Location = new Point(150 + (i % 5) * 100, 60 + (i / 5) * 50);
                buttons[i].AutoSize = true;
                buttons[i].Tag = new {Type = "name", Index = i};  // Store index for reference
                buttons[i].Click += Button_Click;  // Use generic handler
                form1.Controls.Add(buttons[i]);
            }
        }

        private void SetupNumButtons(Button[] buttons)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();  // Create button instance
                buttons[i].Font = new Font(font, fontSize);
                buttons[i].Location = new Point(150 + (i % 5) * 100, 325 + (i / 5) * 50);
                buttons[i].AutoSize = true;
                buttons[i].Tag = new { Type = "number", Index = i };  // Store index for reference
                buttons[i].Click += Button_Click;  // Use generic handler
                form1.Controls.Add(buttons[i]);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null) return;

            var tagData = (dynamic)clickedButton.Tag;
            int index = tagData.Index;

            if (tagData.Type == "name")
            {
                Console.WriteLine("you clicked a port name");
                HandleNameClick(buttons[index], index);
            }
            else if (tagData.Type == "number")
            {
                Console.WriteLine("you clicked a port number");
                HandleNumClick(numButtons[index], index);

            }

        }

        private void HandleNameClick(Button button, int index)
        {
            if (answer1 == null)
            {
                buttons[index].Text = answer1;
            } 
            else
            {
                buttons[index].Text = answer2;
            }
        }

        private void HandleNumClick(Button button, int index)
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

        private void LoadNumJson(Button[] btns)
        {
            string workingDir = Directory.GetCurrentDirectory();
            Console.WriteLine($"working dir: {workingDir}");


            string fileName = "ports.json";
            string jsonContent = File.ReadAllText(fileName);

            List<Port> ports = JsonSerializer.Deserialize<List<Port>>(jsonContent);

            for (int i = 0; i < btns.Length && i < ports.Count; i++)
            {
                btns[i].Text = string.Join(", ", ports[i].portNum);
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