using System.Diagnostics;
using DayZLootEditor;
using WeatherEditor;
using GlobalsEditor;

namespace DayZTool
{
    public partial class Home : Form
    {
        frmMain lootEditorForm;
        WeatherMain weatherEditorForm;
        MainGlobals globalEditorForm;

        public Home()
        {
            InitializeComponent();
            // Initialize the forms
            lootEditorForm = new frmMain();
            weatherEditorForm = new WeatherMain();
            globalEditorForm = new MainGlobals();
        }


        private void Home_Load(object sender, EventArgs e)
        { 
            InitializeControls();
        }



        //                 INITIALIZE CONTROLS
        //
        //
        // Initializes the controls on the form, including buttons and labels
        private void InitializeControls()
        {
            // BUTTONS
            // Create button for Loot Editor
            CreateButton("btnLootEditor", "Spawn Loot Editor", 152, 459, (s, e) => { 
                if (lootEditorForm.IsDisposed)
                {
                    lootEditorForm = new frmMain();
                }

                lootEditorForm.Show();
            });

            // Create button for Weather Editor
            CreateButton("btnWeatherEditor", "Weather Editor", 407, 459, (s, e) => {
                if (weatherEditorForm.IsDisposed)
                {
                    weatherEditorForm = new WeatherMain();
                }
                weatherEditorForm.Show();
            });

            // Create button for ...
            CreateButton("btnGlobalsEditor", "Globals Editor", 662, 459, (s, e) => {
                if (globalEditorForm.IsDisposed)
                {
                    globalEditorForm = new MainGlobals();
                }
                globalEditorForm.Show();
            });

            // Create button for ...
            CreateButton("tbd1", "Coming Soon...", 917, 459, (s, e) => { /* Event handler here */ MessageBox.Show("Coming Soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); });

            // LABEL
            // Create Label
            RotatedLabel label = new RotatedLabel
            {
                Text = "Tool",
                Font = new Font("Impact", 36, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#F0F0F0"),
                BackColor = Color.Transparent,
                Angle = -19.5f,
                Location = new Point(970, 256),
                Size = new Size(200, 90)
            };

            this.Controls.Add(label);

            // TOOLTIP
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(lnkPicCredit, "https://www.deviantart.com/suzuki88/art/DayZ-screenshot-wallpapers-326440177");
            toolTip.SetToolTip(lnkProgram, "https://github.com/Spartan1034x");
        }
        //
        // Creates a button with the specified properties and adds it to the form.
        private void CreateButton(string name, string text, int x, int y, EventHandler clickEvent)
        {
            HomePageButtons button = new HomePageButtons
            {
                Name = name,
                Text = text,
                Location = new Point(x, y),
                Size = new Size(150, 50)
            };
            button.Click += clickEvent;
            Controls.Add(button);
        }



        //                     LINK CLICKED ART
        //
        //
        // Event handler for link pressed, opens the link in the default browser for art creator
        private void lnkPicCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.deviantart.com/suzuki88/art/DayZ-screenshot-wallpapers-326440177",
                UseShellExecute = true
            });
        }



        //                 LINK CLICKED PROGRAM
        //
        //
        // Event handler for link pressed, opens the link in the default browser for program creator
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Spartan1034x",
                UseShellExecute = true
            });
        }
    }
}
