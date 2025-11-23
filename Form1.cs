using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private String font = "Calibri";
        private int fontSize = 15;

        public PracticeMode currentMode;
        private BitwiseSubnetting bitwiseSubnetting;
        private MagicNumberSubnetting magicNumberSubnetting;

        private Button backButton;


        public enum PracticeMode
        {
            MainMenu,
            BitwiseSubnetting,
            MagicNumberSubnetting,
            PortQuiz,
            ProtocolMatch
        }

        public Form1()
        {
            currentMode = PracticeMode.MainMenu;
            InitializeComponent();

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(806, 544);

            SetupMainMenu();
        }

        private void SetupMainMenu()
        {
            this.Controls.Clear();

            Label title = new Label();
            title.Text = "Networking Practice";
            title.Font = new Font(font, 25);
            title.Location = new Point(100, 50);
            title.AutoSize = true;
            this.Controls.Add(title);

            Button bitwiseBtn = new Button();
            bitwiseBtn.Text = "Bitwise Subnetting";
            bitwiseBtn.Location = new Point(100, 150);
            bitwiseBtn.Click += (s, e) => SwitchMode(PracticeMode.BitwiseSubnetting);
            this.Controls.Add(bitwiseBtn);

            Button magicBtn = new Button();
            magicBtn.Text = "Magic Number Subnetting";
            magicBtn.Location = new Point(100, 200);
            magicBtn.Click += (s, e) => SwitchMode(PracticeMode.MagicNumberSubnetting);
            this.Controls.Add(magicBtn);
        }

        public void SwitchMode(PracticeMode newMode)
        {
            currentMode = newMode;
            this.Controls.Clear();

            switch(currentMode)
            {
                case PracticeMode.MainMenu:
                    SetupMainMenu();
                    break;
                case PracticeMode.BitwiseSubnetting:
                    bitwiseSubnetting = new BitwiseSubnetting(this);
                    bitwiseSubnetting.SetupBitwiseMode();
                    break;
                case PracticeMode.MagicNumberSubnetting:
                    magicNumberSubnetting = new MagicNumberSubnetting(this);
                    magicNumberSubnetting.SetupMagicNumberMode();
                    break;
            }
        }



    }
}
