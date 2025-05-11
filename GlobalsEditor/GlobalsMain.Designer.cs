namespace GlobalsEditor
{
    partial class MainGlobals
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGlobals));
            label2 = new Label();
            trkAnimalMax = new TrackBar();
            lblAnimalMaxCount = new Label();
            label1 = new Label();
            label3 = new Label();
            lblCleanupAvoidance = new Label();
            trkCleanupAvoidance = new TrackBar();
            label4 = new Label();
            lblCleanDeadAnimal = new Label();
            trkCleanupDeadAnimal = new TrackBar();
            label6 = new Label();
            lblCleanDeadZomb = new Label();
            trkCleanupDeadZomb = new TrackBar();
            label8 = new Label();
            lblCleanDeadPlayerSeconds = new Label();
            trkCleanDeadPlayer = new TrackBar();
            lblDeadPlayerMin = new Label();
            lblDeadZombsMin = new Label();
            lblDeadAnimalMin = new Label();
            lblLifetimeDefMin = new Label();
            lblLifetimeLimitMin = new Label();
            lblRuinedMin = new Label();
            label10 = new Label();
            lblRuinedS = new Label();
            trkRuined = new TrackBar();
            label12 = new Label();
            lblLifetimeLimitS = new Label();
            trkLifetimeLimit = new TrackBar();
            label14 = new Label();
            lblLifetimeDefaultS = new Label();
            trkLifetimeDefault = new TrackBar();
            lblLootDamMax = new Label();
            label17 = new Label();
            trkLootDamMax = new TrackBar();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            trackBar5 = new TrackBar();
            lblFlagRefreshMin = new Label();
            label7 = new Label();
            lblFlagRefreshS = new Label();
            nudFlagRefresh = new NumericUpDown();
            nudFlagDur = new NumericUpDown();
            lblFlagDurHour = new Label();
            label9 = new Label();
            lblFlagDurS = new Label();
            label5 = new Label();
            chkFoodDecay = new CheckBox();
            label13 = new Label();
            lblIdleCountS = new Label();
            trkIdleCount = new TrackBar();
            chkIdleModeStart = new CheckBox();
            label15 = new Label();
            label23 = new Label();
            lblInitialSpawn = new Label();
            trkInitialSpawn = new TrackBar();
            lblLootDamMin = new Label();
            label18 = new Label();
            trkLootDamMin = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trkAnimalMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkCleanupAvoidance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkCleanupDeadAnimal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkCleanupDeadZomb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkCleanDeadPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkRuined).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkLifetimeLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkLifetimeDefault).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkLootDamMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFlagRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFlagDur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkIdleCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkInitialSpawn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkLootDamMin).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(538, 9);
            label2.Name = "label2";
            label2.Size = new Size(246, 48);
            label2.TabIndex = 7;
            label2.Text = "Globals Editor";
            // 
            // trkAnimalMax
            // 
            trkAnimalMax.Location = new Point(73, 141);
            trkAnimalMax.Maximum = 1000;
            trkAnimalMax.Name = "trkAnimalMax";
            trkAnimalMax.Size = new Size(229, 56);
            trkAnimalMax.TabIndex = 8;
            trkAnimalMax.Value = 200;
            trkAnimalMax.Scroll += trkAnimalMax_Scroll;
            // 
            // lblAnimalMaxCount
            // 
            lblAnimalMaxCount.AutoSize = true;
            lblAnimalMaxCount.Location = new Point(171, 118);
            lblAnimalMaxCount.Name = "lblAnimalMaxCount";
            lblAnimalMaxCount.Size = new Size(33, 20);
            lblAnimalMaxCount.TabIndex = 9;
            lblAnimalMaxCount.Text = "200";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 79);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 10;
            label1.Text = "Max Animal Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 200);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 13;
            label3.Text = "Cleanup Avoidance";
            // 
            // lblCleanupAvoidance
            // 
            lblCleanupAvoidance.AutoSize = true;
            lblCleanupAvoidance.Location = new Point(171, 239);
            lblCleanupAvoidance.Name = "lblCleanupAvoidance";
            lblCleanupAvoidance.Size = new Size(33, 20);
            lblCleanupAvoidance.TabIndex = 12;
            lblCleanupAvoidance.Text = "100";
            // 
            // trkCleanupAvoidance
            // 
            trkCleanupAvoidance.Location = new Point(73, 262);
            trkCleanupAvoidance.Maximum = 1000;
            trkCleanupAvoidance.Name = "trkCleanupAvoidance";
            trkCleanupAvoidance.Size = new Size(229, 56);
            trkCleanupAvoidance.TabIndex = 11;
            trkCleanupAvoidance.Value = 100;
            trkCleanupAvoidance.Scroll += trkCleanupAvoidance_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 321);
            label4.Name = "label4";
            label4.Size = new Size(288, 28);
            label4.TabIndex = 16;
            label4.Text = "Cleanup Lifetime Dead Animal";
            // 
            // lblCleanDeadAnimal
            // 
            lblCleanDeadAnimal.AutoSize = true;
            lblCleanDeadAnimal.Location = new Point(126, 360);
            lblCleanDeadAnimal.Name = "lblCleanDeadAnimal";
            lblCleanDeadAnimal.Size = new Size(47, 20);
            lblCleanDeadAnimal.TabIndex = 15;
            lblCleanDeadAnimal.Text = "1200s";
            // 
            // trkCleanupDeadAnimal
            // 
            trkCleanupDeadAnimal.Location = new Point(73, 383);
            trkCleanupDeadAnimal.Maximum = 10000;
            trkCleanupDeadAnimal.Name = "trkCleanupDeadAnimal";
            trkCleanupDeadAnimal.Size = new Size(229, 56);
            trkCleanupDeadAnimal.SmallChange = 100;
            trkCleanupDeadAnimal.TabIndex = 14;
            trkCleanupDeadAnimal.Value = 1200;
            trkCleanupDeadAnimal.Scroll += trackBar1_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 442);
            label6.Name = "label6";
            label6.Size = new Size(288, 28);
            label6.TabIndex = 19;
            label6.Text = "Cleanup Lifetime Dead Zombs";
            // 
            // lblCleanDeadZomb
            // 
            lblCleanDeadZomb.AutoSize = true;
            lblCleanDeadZomb.Location = new Point(130, 481);
            lblCleanDeadZomb.Name = "lblCleanDeadZomb";
            lblCleanDeadZomb.Size = new Size(39, 20);
            lblCleanDeadZomb.TabIndex = 18;
            lblCleanDeadZomb.Text = "330s";
            // 
            // trkCleanupDeadZomb
            // 
            trkCleanupDeadZomb.Location = new Point(73, 504);
            trkCleanupDeadZomb.Maximum = 2500;
            trkCleanupDeadZomb.Name = "trkCleanupDeadZomb";
            trkCleanupDeadZomb.Size = new Size(229, 56);
            trkCleanupDeadZomb.SmallChange = 100;
            trkCleanupDeadZomb.TabIndex = 17;
            trkCleanupDeadZomb.Value = 330;
            trkCleanupDeadZomb.Scroll += trkCleanupDeadZomb_Scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(47, 552);
            label8.Name = "label8";
            label8.Size = new Size(280, 28);
            label8.TabIndex = 22;
            label8.Text = "Cleanup Lifetime Dead Player";
            // 
            // lblCleanDeadPlayerSeconds
            // 
            lblCleanDeadPlayerSeconds.AutoSize = true;
            lblCleanDeadPlayerSeconds.Location = new Point(126, 591);
            lblCleanDeadPlayerSeconds.Name = "lblCleanDeadPlayerSeconds";
            lblCleanDeadPlayerSeconds.Size = new Size(47, 20);
            lblCleanDeadPlayerSeconds.TabIndex = 21;
            lblCleanDeadPlayerSeconds.Text = "3600s";
            // 
            // trkCleanDeadPlayer
            // 
            trkCleanDeadPlayer.Location = new Point(73, 614);
            trkCleanDeadPlayer.Maximum = 15000;
            trkCleanDeadPlayer.Name = "trkCleanDeadPlayer";
            trkCleanDeadPlayer.Size = new Size(229, 56);
            trkCleanDeadPlayer.SmallChange = 100;
            trkCleanDeadPlayer.TabIndex = 20;
            trkCleanDeadPlayer.Value = 3600;
            trkCleanDeadPlayer.Scroll += trkCleanDeadPlayer_Scroll;
            // 
            // lblDeadPlayerMin
            // 
            lblDeadPlayerMin.AutoSize = true;
            lblDeadPlayerMin.Location = new Point(197, 591);
            lblDeadPlayerMin.Name = "lblDeadPlayerMin";
            lblDeadPlayerMin.Size = new Size(54, 20);
            lblDeadPlayerMin.TabIndex = 23;
            lblDeadPlayerMin.Text = "60 min";
            // 
            // lblDeadZombsMin
            // 
            lblDeadZombsMin.AutoSize = true;
            lblDeadZombsMin.Location = new Point(201, 481);
            lblDeadZombsMin.Name = "lblDeadZombsMin";
            lblDeadZombsMin.Size = new Size(46, 20);
            lblDeadZombsMin.TabIndex = 24;
            lblDeadZombsMin.Text = "5 min";
            // 
            // lblDeadAnimalMin
            // 
            lblDeadAnimalMin.AutoSize = true;
            lblDeadAnimalMin.Location = new Point(197, 360);
            lblDeadAnimalMin.Name = "lblDeadAnimalMin";
            lblDeadAnimalMin.Size = new Size(54, 20);
            lblDeadAnimalMin.TabIndex = 25;
            lblDeadAnimalMin.Text = "20 min";
            // 
            // lblLifetimeDefMin
            // 
            lblLifetimeDefMin.AutoSize = true;
            lblLifetimeDefMin.Location = new Point(201, 725);
            lblLifetimeDefMin.Name = "lblLifetimeDefMin";
            lblLifetimeDefMin.Size = new Size(46, 20);
            lblLifetimeDefMin.TabIndex = 37;
            lblLifetimeDefMin.Text = "0 min";
            // 
            // lblLifetimeLimitMin
            // 
            lblLifetimeLimitMin.AutoSize = true;
            lblLifetimeLimitMin.Location = new Point(201, 846);
            lblLifetimeLimitMin.Name = "lblLifetimeLimitMin";
            lblLifetimeLimitMin.Size = new Size(46, 20);
            lblLifetimeLimitMin.TabIndex = 36;
            lblLifetimeLimitMin.Text = "0 min";
            // 
            // lblRuinedMin
            // 
            lblRuinedMin.AutoSize = true;
            lblRuinedMin.Location = new Point(499, 118);
            lblRuinedMin.Name = "lblRuinedMin";
            lblRuinedMin.Size = new Size(46, 20);
            lblRuinedMin.TabIndex = 35;
            lblRuinedMin.Text = "5 min";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(367, 79);
            label10.Name = "label10";
            label10.Size = new Size(236, 28);
            label10.TabIndex = 34;
            label10.Text = "Cleanup Lifetime Ruined";
            // 
            // lblRuinedS
            // 
            lblRuinedS.AutoSize = true;
            lblRuinedS.Location = new Point(424, 118);
            lblRuinedS.Name = "lblRuinedS";
            lblRuinedS.Size = new Size(39, 20);
            lblRuinedS.TabIndex = 33;
            lblRuinedS.Text = "330s";
            // 
            // trkRuined
            // 
            trkRuined.Location = new Point(371, 141);
            trkRuined.Maximum = 3600;
            trkRuined.Name = "trkRuined";
            trkRuined.Size = new Size(229, 56);
            trkRuined.SmallChange = 100;
            trkRuined.TabIndex = 32;
            trkRuined.Value = 330;
            trkRuined.Scroll += trkRuined_Scroll;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(79, 807);
            label12.Name = "label12";
            label12.Size = new Size(217, 28);
            label12.TabIndex = 31;
            label12.Text = "Cleanup Lifetime Limit";
            // 
            // lblLifetimeLimitS
            // 
            lblLifetimeLimitS.AutoSize = true;
            lblLifetimeLimitS.Location = new Point(134, 846);
            lblLifetimeLimitS.Name = "lblLifetimeLimitS";
            lblLifetimeLimitS.Size = new Size(31, 20);
            lblLifetimeLimitS.TabIndex = 30;
            lblLifetimeLimitS.Text = "50s";
            // 
            // trkLifetimeLimit
            // 
            trkLifetimeLimit.Location = new Point(73, 869);
            trkLifetimeLimit.Maximum = 1200;
            trkLifetimeLimit.Name = "trkLifetimeLimit";
            trkLifetimeLimit.Size = new Size(229, 56);
            trkLifetimeLimit.SmallChange = 100;
            trkLifetimeLimit.TabIndex = 29;
            trkLifetimeLimit.Value = 50;
            trkLifetimeLimit.Scroll += trkLifetimeLimit_Scroll;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(68, 686);
            label14.Name = "label14";
            label14.Size = new Size(238, 28);
            label14.TabIndex = 28;
            label14.Text = "Cleanup Lifetime Default";
            // 
            // lblLifetimeDefaultS
            // 
            lblLifetimeDefaultS.AutoSize = true;
            lblLifetimeDefaultS.Location = new Point(134, 725);
            lblLifetimeDefaultS.Name = "lblLifetimeDefaultS";
            lblLifetimeDefaultS.Size = new Size(31, 20);
            lblLifetimeDefaultS.TabIndex = 27;
            lblLifetimeDefaultS.Text = "45s";
            // 
            // trkLifetimeDefault
            // 
            trkLifetimeDefault.Location = new Point(73, 748);
            trkLifetimeDefault.Maximum = 1200;
            trkLifetimeDefault.Name = "trkLifetimeDefault";
            trkLifetimeDefault.Size = new Size(229, 56);
            trkLifetimeDefault.SmallChange = 100;
            trkLifetimeDefault.TabIndex = 26;
            trkLifetimeDefault.Value = 45;
            trkLifetimeDefault.Scroll += trkLifetimeDefault_Scroll;
            // 
            // lblLootDamMax
            // 
            lblLootDamMax.AutoSize = true;
            lblLootDamMax.Location = new Point(775, 118);
            lblLootDamMax.Name = "lblLootDamMax";
            lblLootDamMax.Size = new Size(37, 20);
            lblLootDamMax.TabIndex = 41;
            lblLootDamMax.Text = "82%";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(704, 79);
            label17.Name = "label17";
            label17.Size = new Size(178, 28);
            label17.TabIndex = 40;
            label17.Text = "Loot Damage Max";
            // 
            // trkLootDamMax
            // 
            trkLootDamMax.Location = new Point(679, 141);
            trkLootDamMax.Maximum = 100;
            trkLootDamMax.Name = "trkLootDamMax";
            trkLootDamMax.Size = new Size(229, 56);
            trkLootDamMax.TabIndex = 38;
            trkLootDamMax.Value = 82;
            trkLootDamMax.Scroll += trkLootDamMax_Scroll;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1115, 118);
            label19.Name = "label19";
            label19.Size = new Size(54, 20);
            label19.TabIndex = 45;
            label19.Text = "60 min";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(983, 79);
            label20.Name = "label20";
            label20.Size = new Size(236, 28);
            label20.TabIndex = 44;
            label20.Text = "Cleanup Lifetime Ruined";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1040, 118);
            label21.Name = "label21";
            label21.Size = new Size(51, 20);
            label21.TabIndex = 43;
            label21.Text = "3600 s";
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(987, 141);
            trackBar5.Maximum = 15000;
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(229, 56);
            trackBar5.SmallChange = 100;
            trackBar5.TabIndex = 42;
            trackBar5.Value = 3600;
            // 
            // lblFlagRefreshMin
            // 
            lblFlagRefreshMin.AutoSize = true;
            lblFlagRefreshMin.Location = new Point(500, 239);
            lblFlagRefreshMin.Name = "lblFlagRefreshMin";
            lblFlagRefreshMin.Size = new Size(70, 20);
            lblFlagRefreshMin.TabIndex = 48;
            lblFlagRefreshMin.Text = "7200 min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(374, 200);
            label7.Name = "label7";
            label7.Size = new Size(223, 28);
            label7.TabIndex = 47;
            label7.Text = "Flag Refresh Frequency";
            // 
            // lblFlagRefreshS
            // 
            lblFlagRefreshS.AutoSize = true;
            lblFlagRefreshS.Location = new Point(402, 239);
            lblFlagRefreshS.Name = "lblFlagRefreshS";
            lblFlagRefreshS.Size = new Size(63, 20);
            lblFlagRefreshS.TabIndex = 46;
            lblFlagRefreshS.Text = "432000s";
            // 
            // nudFlagRefresh
            // 
            nudFlagRefresh.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudFlagRefresh.Location = new Point(374, 262);
            nudFlagRefresh.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudFlagRefresh.Name = "nudFlagRefresh";
            nudFlagRefresh.Size = new Size(223, 27);
            nudFlagRefresh.TabIndex = 49;
            nudFlagRefresh.TextAlign = HorizontalAlignment.Center;
            nudFlagRefresh.Value = new decimal(new int[] { 7200, 0, 0, 0 });
            nudFlagRefresh.ValueChanged += nudFlagRefresh_ValueChanged;
            // 
            // nudFlagDur
            // 
            nudFlagDur.Increment = new decimal(new int[] { 25, 0, 0, 0 });
            nudFlagDur.Location = new Point(377, 383);
            nudFlagDur.Maximum = new decimal(new int[] { 25000, 0, 0, 0 });
            nudFlagDur.Name = "nudFlagDur";
            nudFlagDur.Size = new Size(223, 27);
            nudFlagDur.TabIndex = 53;
            nudFlagDur.TextAlign = HorizontalAlignment.Center;
            nudFlagDur.Value = new decimal(new int[] { 960, 0, 0, 0 });
            nudFlagDur.ValueChanged += nudFlagDur_ValueChanged;
            // 
            // lblFlagDurHour
            // 
            lblFlagDurHour.AutoSize = true;
            lblFlagDurHour.Location = new Point(499, 360);
            lblFlagDurHour.Name = "lblFlagDurHour";
            lblFlagDurHour.Size = new Size(73, 20);
            lblFlagDurHour.TabIndex = 52;
            lblFlagDurHour.Text = "960 hours";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(359, 321);
            label9.Name = "label9";
            label9.Size = new Size(252, 28);
            label9.TabIndex = 51;
            label9.Text = "Flag Refresh Max Duration";
            // 
            // lblFlagDurS
            // 
            lblFlagDurS.AutoSize = true;
            lblFlagDurS.Location = new Point(398, 360);
            lblFlagDurS.Name = "lblFlagDurS";
            lblFlagDurS.Size = new Size(71, 20);
            lblFlagDurS.TabIndex = 50;
            lblFlagDurS.Text = "3456000s";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(426, 442);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 54;
            label5.Text = "Food Decay";
            // 
            // chkFoodDecay
            // 
            chkFoodDecay.AutoSize = true;
            chkFoodDecay.Checked = true;
            chkFoodDecay.CheckState = CheckState.Checked;
            chkFoodDecay.Location = new Point(460, 479);
            chkFoodDecay.Name = "chkFoodDecay";
            chkFoodDecay.Size = new Size(50, 24);
            chkFoodDecay.TabIndex = 55;
            chkFoodDecay.Text = "On";
            chkFoodDecay.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(377, 552);
            label13.Name = "label13";
            label13.Size = new Size(217, 28);
            label13.TabIndex = 58;
            label13.Text = "Idle Mode Countdown";
            // 
            // lblIdleCountS
            // 
            lblIdleCountS.AutoSize = true;
            lblIdleCountS.Location = new Point(470, 591);
            lblIdleCountS.Name = "lblIdleCountS";
            lblIdleCountS.Size = new Size(31, 20);
            lblIdleCountS.TabIndex = 57;
            lblIdleCountS.Text = "60s";
            // 
            // trkIdleCount
            // 
            trkIdleCount.Location = new Point(368, 614);
            trkIdleCount.Maximum = 600;
            trkIdleCount.Name = "trkIdleCount";
            trkIdleCount.Size = new Size(229, 56);
            trkIdleCount.SmallChange = 100;
            trkIdleCount.TabIndex = 56;
            trkIdleCount.Value = 60;
            trkIdleCount.Scroll += trkIdleCount_Scroll;
            // 
            // chkIdleModeStart
            // 
            chkIdleModeStart.AutoSize = true;
            chkIdleModeStart.Checked = true;
            chkIdleModeStart.CheckState = CheckState.Checked;
            chkIdleModeStart.Location = new Point(460, 723);
            chkIdleModeStart.Name = "chkIdleModeStart";
            chkIdleModeStart.Size = new Size(50, 24);
            chkIdleModeStart.TabIndex = 60;
            chkIdleModeStart.Text = "On";
            chkIdleModeStart.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(397, 686);
            label15.Name = "label15";
            label15.Size = new Size(177, 28);
            label15.TabIndex = 59;
            label15.Text = "Idle Mode Startup";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(421, 807);
            label23.Name = "label23";
            label23.Size = new Size(128, 28);
            label23.TabIndex = 63;
            label23.Text = "Initial Spawn";
            // 
            // lblInitialSpawn
            // 
            lblInitialSpawn.AutoSize = true;
            lblInitialSpawn.Location = new Point(466, 846);
            lblInitialSpawn.Name = "lblInitialSpawn";
            lblInitialSpawn.Size = new Size(39, 20);
            lblInitialSpawn.TabIndex = 62;
            lblInitialSpawn.Text = "100s";
            // 
            // trkInitialSpawn
            // 
            trkInitialSpawn.Location = new Point(368, 869);
            trkInitialSpawn.Maximum = 1200;
            trkInitialSpawn.Name = "trkInitialSpawn";
            trkInitialSpawn.Size = new Size(229, 56);
            trkInitialSpawn.SmallChange = 100;
            trkInitialSpawn.TabIndex = 61;
            trkInitialSpawn.Value = 100;
            trkInitialSpawn.Scroll += trkInitialSpawn_Scroll;
            // 
            // lblLootDamMin
            // 
            lblLootDamMin.AutoSize = true;
            lblLootDamMin.Location = new Point(775, 239);
            lblLootDamMin.Name = "lblLootDamMin";
            lblLootDamMin.Size = new Size(29, 20);
            lblLootDamMin.TabIndex = 66;
            lblLootDamMin.Text = "0%";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(704, 200);
            label18.Name = "label18";
            label18.Size = new Size(175, 28);
            label18.TabIndex = 65;
            label18.Text = "Loot Damage Min";
            // 
            // trkLootDamMin
            // 
            trkLootDamMin.Location = new Point(679, 262);
            trkLootDamMin.Maximum = 100;
            trkLootDamMin.Name = "trkLootDamMin";
            trkLootDamMin.Size = new Size(229, 56);
            trkLootDamMin.TabIndex = 64;
            trkLootDamMin.Scroll += trkLootDamMin_Scroll;
            // 
            // MainGlobals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1288, 958);
            Controls.Add(lblLootDamMin);
            Controls.Add(label18);
            Controls.Add(trkLootDamMin);
            Controls.Add(label23);
            Controls.Add(lblInitialSpawn);
            Controls.Add(trkInitialSpawn);
            Controls.Add(chkIdleModeStart);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(lblIdleCountS);
            Controls.Add(trkIdleCount);
            Controls.Add(chkFoodDecay);
            Controls.Add(label5);
            Controls.Add(nudFlagDur);
            Controls.Add(lblFlagDurHour);
            Controls.Add(label9);
            Controls.Add(lblFlagDurS);
            Controls.Add(nudFlagRefresh);
            Controls.Add(lblFlagRefreshMin);
            Controls.Add(label7);
            Controls.Add(lblFlagRefreshS);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(trackBar5);
            Controls.Add(lblLootDamMax);
            Controls.Add(label17);
            Controls.Add(trkLootDamMax);
            Controls.Add(lblLifetimeDefMin);
            Controls.Add(lblLifetimeLimitMin);
            Controls.Add(lblRuinedMin);
            Controls.Add(label10);
            Controls.Add(lblRuinedS);
            Controls.Add(trkRuined);
            Controls.Add(label12);
            Controls.Add(lblLifetimeLimitS);
            Controls.Add(trkLifetimeLimit);
            Controls.Add(label14);
            Controls.Add(lblLifetimeDefaultS);
            Controls.Add(trkLifetimeDefault);
            Controls.Add(lblDeadAnimalMin);
            Controls.Add(lblDeadZombsMin);
            Controls.Add(lblDeadPlayerMin);
            Controls.Add(label8);
            Controls.Add(lblCleanDeadPlayerSeconds);
            Controls.Add(trkCleanDeadPlayer);
            Controls.Add(label6);
            Controls.Add(lblCleanDeadZomb);
            Controls.Add(trkCleanupDeadZomb);
            Controls.Add(label4);
            Controls.Add(lblCleanDeadAnimal);
            Controls.Add(trkCleanupDeadAnimal);
            Controls.Add(label3);
            Controls.Add(lblCleanupAvoidance);
            Controls.Add(trkCleanupAvoidance);
            Controls.Add(label1);
            Controls.Add(lblAnimalMaxCount);
            Controls.Add(trkAnimalMax);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainGlobals";
            Text = "Globals Editor";
            ((System.ComponentModel.ISupportInitialize)trkAnimalMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkCleanupAvoidance).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkCleanupDeadAnimal).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkCleanupDeadZomb).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkCleanDeadPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkRuined).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkLifetimeLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkLifetimeDefault).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkLootDamMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFlagRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFlagDur).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkIdleCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkInitialSpawn).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkLootDamMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TrackBar trkAnimalMax;
        private Label lblAnimalMaxCount;
        private Label label1;
        private Label label3;
        private Label lblCleanupAvoidance;
        private TrackBar trkCleanupAvoidance;
        private Label label4;
        private Label lblCleanDeadAnimal;
        private TrackBar trkCleanupDeadAnimal;
        private Label label6;
        private Label lblCleanDeadZomb;
        private TrackBar trkCleanupDeadZomb;
        private Label label8;
        private Label lblCleanDeadPlayerSeconds;
        private TrackBar trkCleanDeadPlayer;
        private Label lblDeadPlayerMin;
        private Label lblDeadZombsMin;
        private Label lblDeadAnimalMin;
        private Label lblLifetimeDefMin;
        private Label lblLifetimeLimitMin;
        private Label lblRuinedMin;
        private Label label10;
        private Label lblRuinedS;
        private TrackBar trkRuined;
        private Label label12;
        private Label lblLifetimeLimitS;
        private TrackBar trkLifetimeLimit;
        private Label label14;
        private Label lblLifetimeDefaultS;
        private TrackBar trkLifetimeDefault;
        private Label lblLootDamMax;
        private Label label17;
        private TrackBar trkLootDamMax;
        private Label label19;
        private Label label20;
        private Label label21;
        private TrackBar trackBar5;
        private Label lblFlagRefreshMin;
        private Label label7;
        private Label lblFlagRefreshS;
        private NumericUpDown nudFlagRefresh;
        private NumericUpDown nudFlagDur;
        private Label lblFlagDurHour;
        private Label label9;
        private Label lblFlagDurS;
        private Label label5;
        private CheckBox chkFoodDecay;
        private Label label11;
        private Label label13;
        private Label lblIdleCountS;
        private TrackBar trkIdleCount;
        private CheckBox chkIdleModeStart;
        private Label label15;
        private Label label23;
        private Label lblInitialSpawn;
        private TrackBar trkInitialSpawn;
        private Label lblLootDamMin;
        private Label label18;
        private TrackBar trkLootDamMin;
    }
}
