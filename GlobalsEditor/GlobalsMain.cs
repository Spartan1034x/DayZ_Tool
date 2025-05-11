namespace GlobalsEditor
{
    public partial class MainGlobals : Form
    {
        public MainGlobals()
        {
            InitializeComponent();
        }


        //               SCROLLBAR - LABEL LINKS
        //
        //
        private void trkAnimalMax_Scroll(object sender, EventArgs e)
        {
            lblAnimalMaxCount.Text = trkAnimalMax.Value.ToString();
        }

        private void trkCleanupAvoidance_Scroll(object sender, EventArgs e)
        {
            lblCleanupAvoidance.Text = trkCleanupAvoidance.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblCleanDeadAnimal.Text = trkCleanupDeadAnimal.Value.ToString() + "s";
            lblDeadAnimalMin.Text = (trkCleanupDeadAnimal.Value / 60).ToString() + " min";
        }

        private void trkCleanupDeadZomb_Scroll(object sender, EventArgs e)
        {
            lblCleanDeadZomb.Text = trkCleanupDeadZomb.Value.ToString() + "s";
            lblDeadZombsMin.Text = (trkCleanupDeadZomb.Value / 60).ToString() + " min";
        }

        private void trkCleanDeadPlayer_Scroll(object sender, EventArgs e)
        {
            lblCleanDeadPlayerSeconds.Text = trkCleanDeadPlayer.Value.ToString() + "s";
            lblDeadPlayerMin.Text = (trkCleanDeadPlayer.Value / 60).ToString() + " min";
        }

        private void trkLifetimeDefault_Scroll(object sender, EventArgs e)
        {
            lblLifetimeDefaultS.Text = trkLifetimeDefault.Value.ToString() + "s";
            lblLifetimeDefMin.Text = (trkLifetimeDefault.Value / 60).ToString() + " min";
        }

        private void trkLifetimeLimit_Scroll(object sender, EventArgs e)
        {
            lblLifetimeLimitS.Text = trkLifetimeLimit.Value.ToString() + "s";
            lblLifetimeLimitMin.Text = (trkLifetimeLimit.Value / 60).ToString() + " min";
        }

        private void trkRuined_Scroll(object sender, EventArgs e)
        {
            lblRuinedS.Text = trkRuined.Value.ToString() + "s";
            lblRuinedMin.Text = (trkRuined.Value / 60).ToString() + " min";
        }

        private void nudFlagRefresh_ValueChanged(object sender, EventArgs e)
        {
            lblFlagRefreshMin.Text = nudFlagRefresh.Value.ToString() + " min";
            lblFlagRefreshS.Text = (nudFlagRefresh.Value * 60).ToString() + "s";
        }

        private void nudFlagDur_ValueChanged(object sender, EventArgs e)
        {
            lblFlagDurHour.Text = nudFlagDur.Value.ToString() + " hours";
            lblFlagDurS.Text = ((nudFlagDur.Value * 60) * 60).ToString() + "s";
        }

        private void trkIdleCount_Scroll(object sender, EventArgs e)
        {
            lblIdleCountS.Text = trkIdleCount.Value.ToString() + "s";
        }

        private void trkInitialSpawn_Scroll(object sender, EventArgs e)
        {
            lblInitialSpawn.Text = trkInitialSpawn.Value.ToString() + "s";
        }

        private void trkLootDamMax_Scroll(object sender, EventArgs e)
        {
            lblLootDamMax.Text = trkLootDamMax.Value.ToString() + "%";
        }

        private void trkLootDamMin_Scroll(object sender, EventArgs e)
        {
            lblLootDamMin.Text = trkLootDamMin.Value.ToString() + "%";
        }
    }
}
