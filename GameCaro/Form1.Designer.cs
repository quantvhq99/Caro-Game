namespace GameCaro
{
    partial class Form1
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
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pncheckboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptcavatar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.prcbarCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtNameplayer = new System.Windows.Forms.TextBox();
            this.timerCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pncheckboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcavatar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pncheckboard
            // 
            this.pncheckboard.Controls.Add(this.panel2);
            this.pncheckboard.Location = new System.Drawing.Point(0, 36);
            this.pncheckboard.Name = "pncheckboard";
            this.pncheckboard.Size = new System.Drawing.Size(689, 629);
            this.pncheckboard.TabIndex = 0;
            this.pncheckboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pncheckboard_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(683, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 299);
            this.panel2.TabIndex = 1;
            // 
            // ptcavatar
            // 
            this.ptcavatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptcavatar.Image = global::GameCaro.Properties.Resources.Untitled_1;
            this.ptcavatar.Location = new System.Drawing.Point(686, 36);
            this.ptcavatar.Name = "ptcavatar";
            this.ptcavatar.Size = new System.Drawing.Size(325, 296);
            this.ptcavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcavatar.TabIndex = 0;
            this.ptcavatar.TabStop = false;
            this.ptcavatar.Click += new System.EventHandler(this.ptcavatar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txtIP);
            this.panel3.Controls.Add(this.picAvatar);
            this.panel3.Controls.Add(this.prcbarCoolDown);
            this.panel3.Controls.Add(this.txtNameplayer);
            this.panel3.Location = new System.Drawing.Point(695, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 281);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 Phát Để Thắng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLAN
            // 
            this.btnLAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLAN.Location = new System.Drawing.Point(0, 109);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(160, 36);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "Kết Nối ";
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txtIP
            // 
            this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIP.Location = new System.Drawing.Point(0, 71);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(160, 32);
            this.txtIP.TabIndex = 3;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.Location = new System.Drawing.Point(166, 13);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(129, 123);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // prcbarCoolDown
            // 
            this.prcbarCoolDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prcbarCoolDown.Location = new System.Drawing.Point(0, 42);
            this.prcbarCoolDown.Name = "prcbarCoolDown";
            this.prcbarCoolDown.Size = new System.Drawing.Size(160, 23);
            this.prcbarCoolDown.TabIndex = 1;
            this.prcbarCoolDown.Click += new System.EventHandler(this.prcbarCoolDown_Click);
            // 
            // txtNameplayer
            // 
            this.txtNameplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameplayer.Location = new System.Drawing.Point(0, 3);
            this.txtNameplayer.Multiline = true;
            this.txtNameplayer.Name = "txtNameplayer";
            this.txtNameplayer.Size = new System.Drawing.Size(160, 33);
            this.txtNameplayer.TabIndex = 0;
            this.txtNameplayer.TextChanged += new System.EventHandler(this.txtNameplayer_TextChanged);
            // 
            // timerCoolDown
            // 
            this.timerCoolDown.Tick += new System.EventHandler(this.timerCoolDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.quitGameToolStripMenuItem.Text = "Quit Game";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.quitGameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 676);
            this.Controls.Add(this.ptcavatar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pncheckboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pncheckboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcavatar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pncheckboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptcavatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.ProgressBar prcbarCoolDown;
        private System.Windows.Forms.TextBox txtNameplayer;
        private System.Windows.Forms.Timer timerCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitGameToolStripMenuItem;
    }
}

