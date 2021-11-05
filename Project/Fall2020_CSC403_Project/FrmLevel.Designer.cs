namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }
    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.HPlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.picHeartContainer0 = new System.Windows.Forms.PictureBox();
            this.picHeartContainer1 = new System.Windows.Forms.PictureBox();
            this.picEnemyGrapeKoolAid = new System.Windows.Forms.PictureBox();
            this.picEnemyKnife = new System.Windows.Forms.PictureBox();
            this.picEnemyDorittoMan = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picOffScreen = new System.Windows.Forms.PictureBox();
            this.picOffScreenPlayer = new System.Windows.Forms.PictureBox();
            this.picInventory0 = new System.Windows.Forms.PictureBox();
            this.picInventory1 = new System.Windows.Forms.PictureBox();
            this.picHeartIndex0 = new System.Windows.Forms.PictureBox();
            this.picHeartIndex1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartContainer0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyGrapeKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyKnife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyDorittoMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffScreenPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartIndex0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartIndex1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(60, 24);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // HPlabel
            // 
            this.HPlabel.BackColor = System.Drawing.Color.Ivory;
            this.HPlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPlabel.Location = new System.Drawing.Point(167, 17);
            this.HPlabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.HPlabel.Name = "HPlabel";
            this.HPlabel.Size = new System.Drawing.Size(93, 21);
            this.HPlabel.TabIndex = 18;
            this.HPlabel.Text = "Player HP";
            this.HPlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(262, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 21);
            this.label1.TabIndex = 4;
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(263, 18);
            this.lblPlayerHealthFull.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 20);
            this.lblPlayerHealthFull.TabIndex = 4;
            // 
            // picHeartContainer0
            // 
            this.picHeartContainer0.BackColor = System.Drawing.Color.Transparent;
            this.picHeartContainer0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHeartContainer0.BackgroundImage")));
            this.picHeartContainer0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHeartContainer0.Location = new System.Drawing.Point(436, 323);
            this.picHeartContainer0.Name = "picHeartContainer0";
            this.picHeartContainer0.Size = new System.Drawing.Size(70, 70);
            this.picHeartContainer0.TabIndex = 23;
            this.picHeartContainer0.TabStop = false;
            // 
            // picHeartContainer1
            // 
            this.picHeartContainer1.BackColor = System.Drawing.Color.Transparent;
            this.picHeartContainer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHeartContainer1.BackgroundImage")));
            this.picHeartContainer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHeartContainer1.Location = new System.Drawing.Point(683, 290);
            this.picHeartContainer1.Name = "picHeartContainer1";
            this.picHeartContainer1.Size = new System.Drawing.Size(70, 70);
            this.picHeartContainer1.TabIndex = 22;
            this.picHeartContainer1.TabStop = false;
            // 
            // picEnemyGrapeKoolAid
            // 
            this.picEnemyGrapeKoolAid.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.grape_packet;
            this.picEnemyGrapeKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyGrapeKoolAid.Location = new System.Drawing.Point(497, 452);
            this.picEnemyGrapeKoolAid.Margin = new System.Windows.Forms.Padding(1);
            this.picEnemyGrapeKoolAid.Name = "picEnemyGrapeKoolAid";
            this.picEnemyGrapeKoolAid.Size = new System.Drawing.Size(38, 58);
            this.picEnemyGrapeKoolAid.TabIndex = 20;
            this.picEnemyGrapeKoolAid.TabStop = false;
            // 
            // picEnemyKnife
            // 
            this.picEnemyKnife.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.knife;
            this.picEnemyKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyKnife.Location = new System.Drawing.Point(167, 360);
            this.picEnemyKnife.Margin = new System.Windows.Forms.Padding(1);
            this.picEnemyKnife.Name = "picEnemyKnife";
            this.picEnemyKnife.Size = new System.Drawing.Size(38, 29);
            this.picEnemyKnife.TabIndex = 19;
            this.picEnemyKnife.TabStop = false;
            // 
            // picEnemyDorittoMan
            // 
            this.picEnemyDorittoMan.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.dorito_man;
            this.picEnemyDorittoMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyDorittoMan.Location = new System.Drawing.Point(566, 180);
            this.picEnemyDorittoMan.Margin = new System.Windows.Forms.Padding(1);
            this.picEnemyDorittoMan.Name = "picEnemyDorittoMan";
            this.picEnemyDorittoMan.Size = new System.Drawing.Size(36, 68);
            this.picEnemyDorittoMan.TabIndex = 18;
            this.picEnemyDorittoMan.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(551, 425);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(164, 232);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 1);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(469, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1093, 274);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 449);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(714, 656);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(83, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(2, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(606, 89);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(275, 159);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(248, 142);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(197, 118);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 656);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(890, 397);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(203, 113);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(2, 454);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(2, 656);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(850, 528);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(148, 154);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(2, 388);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(358, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(966, 78);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 510);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picOffScreen
            // 
            this.picOffScreen.BackColor = System.Drawing.Color.Gray;
            this.picOffScreen.Location = new System.Drawing.Point(698, 1);
            this.picOffScreen.Margin = new System.Windows.Forms.Padding(1);
            this.picOffScreen.Name = "picOffScreen";
            this.picOffScreen.Size = new System.Drawing.Size(17, 16);
            this.picOffScreen.TabIndex = 20;
            this.picOffScreen.TabStop = false;
            // 
            // picOffScreenPlayer
            // 
            this.picOffScreenPlayer.BackColor = System.Drawing.Color.Red;
            this.picOffScreenPlayer.Location = new System.Drawing.Point(933, 1);
            this.picOffScreenPlayer.Margin = new System.Windows.Forms.Padding(1);
            this.picOffScreenPlayer.Name = "picOffScreenPlayer";
            this.picOffScreenPlayer.Size = new System.Drawing.Size(13, 12);
            this.picOffScreenPlayer.TabIndex = 21;
            this.picOffScreenPlayer.TabStop = false;
            // 
            // picInventory0
            // 
            this.picInventory0.BackColor = System.Drawing.Color.Transparent;
            this.picInventory0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInventory0.BackgroundImage")));
            this.picInventory0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picInventory0.Location = new System.Drawing.Point(560, 510);
            this.picInventory0.Name = "picInventory0";
            this.picInventory0.Size = new System.Drawing.Size(70, 70);
            this.picInventory0.TabIndex = 24;
            this.picInventory0.TabStop = false;
            this.picInventory0.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picInventory1
            // 
            this.picInventory1.BackColor = System.Drawing.Color.Transparent;
            this.picInventory1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInventory1.BackgroundImage")));
            this.picInventory1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picInventory1.Location = new System.Drawing.Point(636, 510);
            this.picInventory1.Name = "picInventory1";
            this.picInventory1.Size = new System.Drawing.Size(70, 70);
            this.picInventory1.TabIndex = 25;
            this.picInventory1.TabStop = false;
            this.picInventory1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picHeartIndex0
            // 
            this.picHeartIndex0.BackColor = System.Drawing.Color.Transparent;
            this.picHeartIndex0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHeartIndex0.BackgroundImage")));
            this.picHeartIndex0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHeartIndex0.Location = new System.Drawing.Point(575, 525);
            this.picHeartIndex0.Name = "picHeartIndex0";
            this.picHeartIndex0.Size = new System.Drawing.Size(40, 40);
            this.picHeartIndex0.TabIndex = 27;
            this.picHeartIndex0.TabStop = false;
            this.picHeartIndex0.Visible = false;
            // 
            // picHeartIndex1
            // 
            this.picHeartIndex1.BackColor = System.Drawing.Color.Transparent;
            this.picHeartIndex1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHeartIndex1.BackgroundImage")));
            this.picHeartIndex1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHeartIndex1.Location = new System.Drawing.Point(651, 525);
            this.picHeartIndex1.Name = "picHeartIndex1";
            this.picHeartIndex1.Size = new System.Drawing.Size(40, 40);
            this.picHeartIndex1.TabIndex = 26;
            this.picHeartIndex1.TabStop = false;
            this.picHeartIndex1.Visible = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 725);
            this.Controls.Add(this.picHeartIndex0);
            this.Controls.Add(this.picHeartIndex1);
            this.Controls.Add(this.picInventory1);
            this.Controls.Add(this.picInventory0);
            this.Controls.Add(this.picHeartContainer0);
            this.Controls.Add(this.picHeartContainer1);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HPlabel);
            this.Controls.Add(this.picEnemyGrapeKoolAid);
            this.Controls.Add(this.picEnemyKnife);
            this.Controls.Add(this.picEnemyDorittoMan);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picOffScreen);
            this.Controls.Add(this.picOffScreenPlayer);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picHeartContainer0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyGrapeKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyKnife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyDorittoMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOffScreenPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartIndex0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeartIndex1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall12;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;
    private System.Windows.Forms.Label HPlabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.PictureBox picOffScreen;
    private System.Windows.Forms.PictureBox picOffScreenPlayer;
    private System.Windows.Forms.PictureBox picEnemyDorittoMan;
    private System.Windows.Forms.PictureBox picEnemyKnife;
    private System.Windows.Forms.PictureBox picEnemyGrapeKoolAid;
        private System.Windows.Forms.PictureBox picHeartContainer1;
        private System.Windows.Forms.PictureBox picHeartContainer0;
        private System.Windows.Forms.PictureBox picInventory0;
        private System.Windows.Forms.PictureBox picInventory1;
        private System.Windows.Forms.PictureBox picHeartIndex0;
        private System.Windows.Forms.PictureBox picHeartIndex1;
    }
}

