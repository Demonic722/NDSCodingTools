namespace XD_and_Colosseum_RNG_Tool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region InitializeComponent()

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pidText = new System.Windows.Forms.TextBox();
            this.hpText = new System.Windows.Forms.TextBox();
            this.atkText = new System.Windows.Forms.TextBox();
            this.defText = new System.Windows.Forms.TextBox();
            this.spaText = new System.Windows.Forms.TextBox();
            this.spdText = new System.Windows.Forms.TextBox();
            this.speText = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.pidOutput = new System.Windows.Forms.DataGridView();
            this.pidIvLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rngOutput = new System.Windows.Forms.DataGridView();
            this.rngDirectionChoice = new System.Windows.Forms.ComboBox();
            this.directionLabel = new System.Windows.Forms.Label();
            this.frameLabel = new System.Windows.Forms.Label();
            this.frameText = new System.Windows.Forms.TextBox();
            this.rngStart = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.seedStartText = new System.Windows.Forms.TextBox();
            this.pidStart = new System.Windows.Forms.Button();
            this.dhpText = new System.Windows.Forms.TextBox();
            this.dspeText = new System.Windows.Forms.TextBox();
            this.dspdText = new System.Windows.Forms.TextBox();
            this.dspaText = new System.Windows.Forms.TextBox();
            this.ddefText = new System.Windows.Forms.TextBox();
            this.datkText = new System.Windows.Forms.TextBox();
            this.pidGroup = new System.Windows.Forms.GroupBox();
            this.rngGroup = new System.Windows.Forms.GroupBox();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkLegalityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.runRNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForStableReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAnyReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pidOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rngOutput)).BeginInit();
            this.pidGroup.SuspendLayout();
            this.rngGroup.SuspendLayout();
            this.menubar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pidText
            // 
            this.pidText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pidText.Location = new System.Drawing.Point(64, 29);
            this.pidText.MaxLength = 10;
            this.pidText.Name = "pidText";
            this.pidText.Size = new System.Drawing.Size(117, 20);
            this.pidText.TabIndex = 0;
            this.pidText.Enter += new System.EventHandler(this.pidText_Enter);
            this.pidText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkDec_KeyPress);
            this.pidText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // hpText
            // 
            this.hpText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hpText.Location = new System.Drawing.Point(33, 56);
            this.hpText.MaxLength = 2;
            this.hpText.Name = "hpText";
            this.hpText.Size = new System.Drawing.Size(25, 20);
            this.hpText.TabIndex = 1;
            this.hpText.Enter += new System.EventHandler(this.hpText_Enter);
            this.hpText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.hpText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // atkText
            // 
            this.atkText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.atkText.Location = new System.Drawing.Point(64, 56);
            this.atkText.MaxLength = 2;
            this.atkText.Name = "atkText";
            this.atkText.Size = new System.Drawing.Size(25, 20);
            this.atkText.TabIndex = 2;
            this.atkText.Enter += new System.EventHandler(this.atkText_Enter);
            this.atkText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.atkText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // defText
            // 
            this.defText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.defText.Location = new System.Drawing.Point(94, 56);
            this.defText.MaxLength = 2;
            this.defText.Name = "defText";
            this.defText.Size = new System.Drawing.Size(25, 20);
            this.defText.TabIndex = 3;
            this.defText.Enter += new System.EventHandler(this.defText_Enter);
            this.defText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.defText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // spaText
            // 
            this.spaText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.spaText.Location = new System.Drawing.Point(125, 56);
            this.spaText.MaxLength = 2;
            this.spaText.Name = "spaText";
            this.spaText.Size = new System.Drawing.Size(25, 20);
            this.spaText.TabIndex = 4;
            this.spaText.Enter += new System.EventHandler(this.spaText_Enter);
            this.spaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.spaText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // spdText
            // 
            this.spdText.Location = new System.Drawing.Point(156, 56);
            this.spdText.MaxLength = 2;
            this.spdText.Name = "spdText";
            this.spdText.Size = new System.Drawing.Size(25, 20);
            this.spdText.TabIndex = 5;
            this.spdText.Enter += new System.EventHandler(this.spdText_Enter);
            this.spdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.spdText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // speText
            // 
            this.speText.Location = new System.Drawing.Point(187, 56);
            this.speText.MaxLength = 2;
            this.speText.Name = "speText";
            this.speText.Size = new System.Drawing.Size(25, 20);
            this.speText.TabIndex = 6;
            this.speText.Enter += new System.EventHandler(this.speText_Enter);
            this.speText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.speText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // checkButton
            // 
            this.checkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkButton.Location = new System.Drawing.Point(85, 82);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "&Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            this.checkButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.checkButton.MouseHover += new System.EventHandler(this.checkLegality_MouseHover);
            // 
            // pidOutput
            // 
            this.pidOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pidOutput.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pidOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.pidOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pidOutput.DefaultCellStyle = dataGridViewCellStyle8;
            this.pidOutput.Location = new System.Drawing.Point(6, 194);
            this.pidOutput.Name = "pidOutput";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pidOutput.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.pidOutput.Size = new System.Drawing.Size(250, 294);
            this.pidOutput.TabIndex = 8;
            // 
            // pidIvLabel
            // 
            this.pidIvLabel.AutoSize = true;
            this.pidIvLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pidIvLabel.Location = new System.Drawing.Point(61, 13);
            this.pidIvLabel.Name = "pidIvLabel";
            this.pidIvLabel.Size = new System.Drawing.Size(126, 13);
            this.pidIvLabel.TabIndex = 9;
            this.pidIvLabel.Text = "Input PID and IVs to test:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input desired IVs:";
            // 
            // rngOutput
            // 
            this.rngOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rngOutput.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rngOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.rngOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rngOutput.DefaultCellStyle = dataGridViewCellStyle11;
            this.rngOutput.Location = new System.Drawing.Point(9, 158);
            this.rngOutput.Name = "rngOutput";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rngOutput.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.rngOutput.Size = new System.Drawing.Size(236, 327);
            this.rngOutput.TabIndex = 11;
            // 
            // rngDirectionChoice
            // 
            this.rngDirectionChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rngDirectionChoice.FormattingEnabled = true;
            this.rngDirectionChoice.Items.AddRange(new object[] {
            "Advance XD RNG",
            "Reverse XD RNG"});
            this.rngDirectionChoice.Location = new System.Drawing.Point(47, 28);
            this.rngDirectionChoice.Name = "rngDirectionChoice";
            this.rngDirectionChoice.Size = new System.Drawing.Size(165, 21);
            this.rngDirectionChoice.TabIndex = 12;
            this.rngDirectionChoice.SelectedIndexChanged += new System.EventHandler(this.rngDirectionChoice_SelectedIndexChanged);
            this.rngDirectionChoice.Enter += new System.EventHandler(this.rngDirectionChoice_Enter);
            this.rngDirectionChoice.Leave += new System.EventHandler(this.setReady_Leave);
            this.rngDirectionChoice.MouseLeave += new System.EventHandler(this.rngDirectionChoice_MouseLeave);
            this.rngDirectionChoice.MouseHover += new System.EventHandler(this.rngDirectionChoice_MouseHover);
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.directionLabel.Location = new System.Drawing.Point(80, 12);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(98, 13);
            this.directionLabel.TabIndex = 13;
            this.directionLabel.Text = "Choose a direction:";
            // 
            // frameLabel
            // 
            this.frameLabel.AutoSize = true;
            this.frameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frameLabel.Location = new System.Drawing.Point(44, 59);
            this.frameLabel.Name = "frameLabel";
            this.frameLabel.Size = new System.Drawing.Size(70, 13);
            this.frameLabel.TabIndex = 14;
            this.frameLabel.Text = "Frame Count:";
            // 
            // frameText
            // 
            this.frameText.Location = new System.Drawing.Point(116, 56);
            this.frameText.MaxLength = 8;
            this.frameText.Name = "frameText";
            this.frameText.Size = new System.Drawing.Size(92, 20);
            this.frameText.TabIndex = 15;
            this.frameText.Enter += new System.EventHandler(this.frameText_Enter);
            this.frameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkDec_KeyPress);
            this.frameText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // rngStart
            // 
            this.rngStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rngStart.Location = new System.Drawing.Point(87, 128);
            this.rngStart.Name = "rngStart";
            this.rngStart.Size = new System.Drawing.Size(75, 24);
            this.rngStart.TabIndex = 16;
            this.rngStart.Text = "&Run RNG";
            this.rngStart.UseVisualStyleBackColor = true;
            this.rngStart.Click += new System.EventHandler(this.rngStart_Click);
            this.rngStart.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.rngStart.MouseHover += new System.EventHandler(this.runRNG_MouseHover);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startLabel.Location = new System.Drawing.Point(67, 86);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(111, 13);
            this.startLabel.TabIndex = 17;
            this.startLabel.Text = "Starting Seed: (in hex)";
            // 
            // seedStartText
            // 
            this.seedStartText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.seedStartText.Location = new System.Drawing.Point(47, 102);
            this.seedStartText.MaxLength = 8;
            this.seedStartText.Name = "seedStartText";
            this.seedStartText.Size = new System.Drawing.Size(159, 20);
            this.seedStartText.TabIndex = 18;
            this.seedStartText.Enter += new System.EventHandler(this.seedStartText_Enter);
            this.seedStartText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkHex_KeyPress);
            this.seedStartText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // pidStart
            // 
            this.pidStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pidStart.Location = new System.Drawing.Point(85, 165);
            this.pidStart.Name = "pidStart";
            this.pidStart.Size = new System.Drawing.Size(75, 23);
            this.pidStart.TabIndex = 19;
            this.pidStart.Text = "Get &PID";
            this.pidStart.UseVisualStyleBackColor = true;
            this.pidStart.Click += new System.EventHandler(this.pidStart_Click);
            this.pidStart.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.pidStart.MouseHover += new System.EventHandler(this.getPID_MouseHover);
            // 
            // dhpText
            // 
            this.dhpText.Location = new System.Drawing.Point(31, 140);
            this.dhpText.MaxLength = 2;
            this.dhpText.Name = "dhpText";
            this.dhpText.Size = new System.Drawing.Size(25, 20);
            this.dhpText.TabIndex = 20;
            this.dhpText.Enter += new System.EventHandler(this.dhpText_Enter);
            this.dhpText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.dhpText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // dspeText
            // 
            this.dspeText.Location = new System.Drawing.Point(187, 140);
            this.dspeText.MaxLength = 2;
            this.dspeText.Name = "dspeText";
            this.dspeText.Size = new System.Drawing.Size(25, 20);
            this.dspeText.TabIndex = 21;
            this.dspeText.Enter += new System.EventHandler(this.dspeText_Enter);
            this.dspeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.dspeText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // dspdText
            // 
            this.dspdText.Location = new System.Drawing.Point(156, 140);
            this.dspdText.MaxLength = 2;
            this.dspdText.Name = "dspdText";
            this.dspdText.Size = new System.Drawing.Size(25, 20);
            this.dspdText.TabIndex = 22;
            this.dspdText.Enter += new System.EventHandler(this.dspdText_Enter);
            this.dspdText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.dspdText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // dspaText
            // 
            this.dspaText.Location = new System.Drawing.Point(125, 140);
            this.dspaText.MaxLength = 2;
            this.dspaText.Name = "dspaText";
            this.dspaText.Size = new System.Drawing.Size(25, 20);
            this.dspaText.TabIndex = 23;
            this.dspaText.Enter += new System.EventHandler(this.dspaText_Enter);
            this.dspaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.dspaText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // ddefText
            // 
            this.ddefText.Location = new System.Drawing.Point(94, 140);
            this.ddefText.MaxLength = 2;
            this.ddefText.Name = "ddefText";
            this.ddefText.Size = new System.Drawing.Size(25, 20);
            this.ddefText.TabIndex = 24;
            this.ddefText.Enter += new System.EventHandler(this.ddefText_Enter);
            this.ddefText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.ddefText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // datkText
            // 
            this.datkText.Location = new System.Drawing.Point(62, 140);
            this.datkText.MaxLength = 2;
            this.datkText.Name = "datkText";
            this.datkText.Size = new System.Drawing.Size(25, 20);
            this.datkText.TabIndex = 25;
            this.datkText.Enter += new System.EventHandler(this.datkText_Enter);
            this.datkText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIV_KeyPress);
            this.datkText.Leave += new System.EventHandler(this.setReady_Leave);
            // 
            // pidGroup
            // 
            this.pidGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pidGroup.Controls.Add(this.datkText);
            this.pidGroup.Controls.Add(this.pidOutput);
            this.pidGroup.Controls.Add(this.ddefText);
            this.pidGroup.Controls.Add(this.pidText);
            this.pidGroup.Controls.Add(this.dspaText);
            this.pidGroup.Controls.Add(this.hpText);
            this.pidGroup.Controls.Add(this.dspdText);
            this.pidGroup.Controls.Add(this.atkText);
            this.pidGroup.Controls.Add(this.dspeText);
            this.pidGroup.Controls.Add(this.defText);
            this.pidGroup.Controls.Add(this.dhpText);
            this.pidGroup.Controls.Add(this.spaText);
            this.pidGroup.Controls.Add(this.pidStart);
            this.pidGroup.Controls.Add(this.spdText);
            this.pidGroup.Controls.Add(this.speText);
            this.pidGroup.Controls.Add(this.checkButton);
            this.pidGroup.Controls.Add(this.pidIvLabel);
            this.pidGroup.Controls.Add(this.label2);
            this.pidGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pidGroup.Location = new System.Drawing.Point(5, 29);
            this.pidGroup.Name = "pidGroup";
            this.pidGroup.Size = new System.Drawing.Size(262, 497);
            this.pidGroup.TabIndex = 26;
            this.pidGroup.TabStop = false;
            this.pidGroup.Text = "PID";
            // 
            // rngGroup
            // 
            this.rngGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rngGroup.Controls.Add(this.seedStartText);
            this.rngGroup.Controls.Add(this.rngDirectionChoice);
            this.rngGroup.Controls.Add(this.startLabel);
            this.rngGroup.Controls.Add(this.rngOutput);
            this.rngGroup.Controls.Add(this.rngStart);
            this.rngGroup.Controls.Add(this.directionLabel);
            this.rngGroup.Controls.Add(this.frameText);
            this.rngGroup.Controls.Add(this.frameLabel);
            this.rngGroup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rngGroup.Location = new System.Drawing.Point(275, 29);
            this.rngGroup.Name = "rngGroup";
            this.rngGroup.Size = new System.Drawing.Size(251, 497);
            this.rngGroup.TabIndex = 27;
            this.rngGroup.TabStop = false;
            this.rngGroup.Text = "RNG";
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menubar.Size = new System.Drawing.Size(532, 24);
            this.menubar.TabIndex = 28;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.fileToolStripMenuItem.MouseHover += new System.EventHandler(this.fileToolStripMenuItem_MouseHover);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.exitToolStripMenuItem_MouseHover);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.viewToolStripMenuItem.MouseHover += new System.EventHandler(this.viewToolStripMenuItem_MouseHover);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.statusBarToolStripMenuItem_CheckStateChanged);
            this.statusBarToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.statusBarToolStripMenuItem.MouseHover += new System.EventHandler(this.statusBarToolStripMenuItem_MouseHover);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkLegalityToolStripMenuItem,
            this.getPIDToolStripMenuItem,
            this.toolStripSeparator1,
            this.runRNGToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "R&un";
            this.runToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.runToolStripMenuItem.MouseHover += new System.EventHandler(this.runToolStripMenuItem_MouseHover);
            // 
            // checkLegalityToolStripMenuItem
            // 
            this.checkLegalityToolStripMenuItem.Name = "checkLegalityToolStripMenuItem";
            this.checkLegalityToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.checkLegalityToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.checkLegalityToolStripMenuItem.Text = "&Check Legality";
            this.checkLegalityToolStripMenuItem.Click += new System.EventHandler(this.checkButton_Click);
            this.checkLegalityToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.checkLegalityToolStripMenuItem.MouseHover += new System.EventHandler(this.checkLegality_MouseHover);
            // 
            // getPIDToolStripMenuItem
            // 
            this.getPIDToolStripMenuItem.Name = "getPIDToolStripMenuItem";
            this.getPIDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.getPIDToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.getPIDToolStripMenuItem.Text = "Get &PID";
            this.getPIDToolStripMenuItem.Click += new System.EventHandler(this.pidStart_Click);
            this.getPIDToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.getPIDToolStripMenuItem.MouseHover += new System.EventHandler(this.getPID_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // runRNGToolStripMenuItem
            // 
            this.runRNGToolStripMenuItem.Name = "runRNGToolStripMenuItem";
            this.runRNGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.runRNGToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.runRNGToolStripMenuItem.Text = "&Run RNG";
            this.runRNGToolStripMenuItem.Click += new System.EventHandler(this.rngStart_Click);
            this.runRNGToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.runRNGToolStripMenuItem.MouseHover += new System.EventHandler(this.runRNG_MouseHover);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.toolStripSeparator2,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.helpToolStripMenuItem.MouseHover += new System.EventHandler(this.helpToolStripMenuItem_MouseHover);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            this.aboutToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.aboutToolStripMenuItem.MouseHover += new System.EventHandler(this.aboutToolStripMenuItem_MouseHover);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changelogToolStripMenuItem.Text = "&Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            this.changelogToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.changelogToolStripMenuItem.MouseHover += new System.EventHandler(this.changelogToolStripMenuItem_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForStableReleaseToolStripMenuItem,
            this.checkForAnyReleaseToolStripMenuItem});
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for &Updates";
            this.checkForUpdatesToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.checkForUpdatesToolStripMenuItem.MouseHover += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_MouseHover);
            // 
            // checkForStableReleaseToolStripMenuItem
            // 
            this.checkForStableReleaseToolStripMenuItem.Name = "checkForStableReleaseToolStripMenuItem";
            this.checkForStableReleaseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.checkForStableReleaseToolStripMenuItem.Text = "Check for &Stable Release";
            this.checkForStableReleaseToolStripMenuItem.Click += new System.EventHandler(this.checkForStableReleaseToolStripMenuItem_Click);
            this.checkForStableReleaseToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.checkForStableReleaseToolStripMenuItem.MouseHover += new System.EventHandler(this.checkForStableReleaseToolStripMenuItem_MouseHover);
            // 
            // checkForAnyReleaseToolStripMenuItem
            // 
            this.checkForAnyReleaseToolStripMenuItem.Name = "checkForAnyReleaseToolStripMenuItem";
            this.checkForAnyReleaseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.checkForAnyReleaseToolStripMenuItem.Text = "Check for &Any Release";
            this.checkForAnyReleaseToolStripMenuItem.Click += new System.EventHandler(this.checkForAnyReleaseToolStripMenuItem_Click);
            this.checkForAnyReleaseToolStripMenuItem.MouseLeave += new System.EventHandler(this.setReady_MouseLeave);
            this.checkForAnyReleaseToolStripMenuItem.MouseHover += new System.EventHandler(this.checkForAnyReleaseToolStripMenuItem_MouseHover);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 534);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(532, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 29;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(59, 17);
            this.statusLabel.Text = "Loading...";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 556);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pidGroup);
            this.Controls.Add(this.rngGroup);
            this.Controls.Add(this.menubar);
            this.MainMenuStrip = this.menubar;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(548, 650);
            this.MinimumSize = new System.Drawing.Size(548, 400);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Pokémon Colosseum/XD RNG Tool";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pidOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rngOutput)).EndInit();
            this.pidGroup.ResumeLayout(false);
            this.pidGroup.PerformLayout();
            this.rngGroup.ResumeLayout(false);
            this.rngGroup.PerformLayout();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pidText;
        private System.Windows.Forms.TextBox hpText;
        private System.Windows.Forms.TextBox atkText;
        private System.Windows.Forms.TextBox defText;
        private System.Windows.Forms.TextBox spaText;
        private System.Windows.Forms.TextBox spdText;
        private System.Windows.Forms.TextBox speText;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.DataGridView pidOutput;
        private System.Windows.Forms.Label pidIvLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView rngOutput;
        private System.Windows.Forms.ComboBox rngDirectionChoice;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label frameLabel;
        private System.Windows.Forms.TextBox frameText;
        private System.Windows.Forms.Button rngStart;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox seedStartText;
        private System.Windows.Forms.Button pidStart;
        private System.Windows.Forms.TextBox dhpText;
        private System.Windows.Forms.TextBox dspeText;
        private System.Windows.Forms.TextBox dspdText;
        private System.Windows.Forms.TextBox dspaText;
        private System.Windows.Forms.TextBox ddefText;
        private System.Windows.Forms.TextBox datkText;
        private System.Windows.Forms.GroupBox pidGroup;
        private System.Windows.Forms.GroupBox rngGroup;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkLegalityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getPIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem runRNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForStableReleaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForAnyReleaseToolStripMenuItem;
    }
}

