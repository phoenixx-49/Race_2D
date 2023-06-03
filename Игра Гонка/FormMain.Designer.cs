namespace Игра_Гонка
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TimerAnim = new System.Windows.Forms.Timer(this.components);
            this.LblDefeat = new System.Windows.Forms.Label();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.LblTitleCoint = new System.Windows.Forms.Label();
            this.LblCountCoin = new System.Windows.Forms.Label();
            this.PbxCoinLogo = new System.Windows.Forms.PictureBox();
            this.PbxCoin = new System.Windows.Forms.PictureBox();
            this.PbxEnemy2 = new System.Windows.Forms.PictureBox();
            this.PbxEnemy1 = new System.Windows.Forms.PictureBox();
            this.PbxCar = new System.Windows.Forms.PictureBox();
            this.PbxTrack1 = new System.Windows.Forms.PictureBox();
            this.PbxTrack2 = new System.Windows.Forms.PictureBox();
            this.PanelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoinLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTrack2)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerAnim
            // 
            this.TimerAnim.Enabled = true;
            this.TimerAnim.Interval = 15;
            this.TimerAnim.Tick += new System.EventHandler(this.TimerAnim_Tick);
            // 
            // LblDefeat
            // 
            this.LblDefeat.BackColor = System.Drawing.Color.Red;
            this.LblDefeat.Font = new System.Drawing.Font("Montserrat ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDefeat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDefeat.Location = new System.Drawing.Point(12, 182);
            this.LblDefeat.Name = "LblDefeat";
            this.LblDefeat.Size = new System.Drawing.Size(816, 67);
            this.LblDefeat.TabIndex = 5;
            this.LblDefeat.Text = "Проигрыш";
            this.LblDefeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRestart
            // 
            this.BtnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestart.Font = new System.Drawing.Font("Montserrat ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRestart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRestart.Location = new System.Drawing.Point(246, 270);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(348, 56);
            this.BtnRestart.TabIndex = 6;
            this.BtnRestart.Text = "Перезапустить";
            this.BtnRestart.UseVisualStyleBackColor = false;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelStatus.Controls.Add(this.LblCountCoin);
            this.PanelStatus.Controls.Add(this.LblTitleCoint);
            this.PanelStatus.Controls.Add(this.PbxCoinLogo);
            this.PanelStatus.Location = new System.Drawing.Point(12, 12);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(246, 40);
            this.PanelStatus.TabIndex = 9;
            // 
            // LblTitleCoint
            // 
            this.LblTitleCoint.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTitleCoint.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitleCoint.ForeColor = System.Drawing.Color.White;
            this.LblTitleCoint.Location = new System.Drawing.Point(39, 0);
            this.LblTitleCoint.Name = "LblTitleCoint";
            this.LblTitleCoint.Size = new System.Drawing.Size(118, 40);
            this.LblTitleCoint.TabIndex = 9;
            this.LblTitleCoint.Text = "Монеты: ";
            this.LblTitleCoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCountCoin
            // 
            this.LblCountCoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCountCoin.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCountCoin.ForeColor = System.Drawing.Color.White;
            this.LblCountCoin.Location = new System.Drawing.Point(157, 0);
            this.LblCountCoin.Name = "LblCountCoin";
            this.LblCountCoin.Size = new System.Drawing.Size(89, 40);
            this.LblCountCoin.TabIndex = 10;
            this.LblCountCoin.Text = "0";
            this.LblCountCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxCoinLogo
            // 
            this.PbxCoinLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PbxCoinLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbxCoinLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxCoinLogo.Image")));
            this.PbxCoinLogo.Location = new System.Drawing.Point(0, 0);
            this.PbxCoinLogo.Name = "PbxCoinLogo";
            this.PbxCoinLogo.Size = new System.Drawing.Size(39, 40);
            this.PbxCoinLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCoinLogo.TabIndex = 8;
            this.PbxCoinLogo.TabStop = false;
            // 
            // PbxCoin
            // 
            this.PbxCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PbxCoin.Image = ((System.Drawing.Image)(resources.GetObject("PbxCoin.Image")));
            this.PbxCoin.Location = new System.Drawing.Point(460, -550);
            this.PbxCoin.Name = "PbxCoin";
            this.PbxCoin.Size = new System.Drawing.Size(40, 40);
            this.PbxCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCoin.TabIndex = 7;
            this.PbxCoin.TabStop = false;
            // 
            // PbxEnemy2
            // 
            this.PbxEnemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PbxEnemy2.Image = ((System.Drawing.Image)(resources.GetObject("PbxEnemy2.Image")));
            this.PbxEnemy2.Location = new System.Drawing.Point(564, -1000);
            this.PbxEnemy2.Name = "PbxEnemy2";
            this.PbxEnemy2.Size = new System.Drawing.Size(98, 185);
            this.PbxEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxEnemy2.TabIndex = 4;
            this.PbxEnemy2.TabStop = false;
            // 
            // PbxEnemy1
            // 
            this.PbxEnemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PbxEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("PbxEnemy1.Image")));
            this.PbxEnemy1.Location = new System.Drawing.Point(181, -250);
            this.PbxEnemy1.Name = "PbxEnemy1";
            this.PbxEnemy1.Size = new System.Drawing.Size(98, 185);
            this.PbxEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxEnemy1.TabIndex = 3;
            this.PbxEnemy1.TabStop = false;
            // 
            // PbxCar
            // 
            this.PbxCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PbxCar.Image = ((System.Drawing.Image)(resources.GetObject("PbxCar.Image")));
            this.PbxCar.Location = new System.Drawing.Point(436, 430);
            this.PbxCar.Name = "PbxCar";
            this.PbxCar.Size = new System.Drawing.Size(98, 180);
            this.PbxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCar.TabIndex = 1;
            this.PbxCar.TabStop = false;
            // 
            // PbxTrack1
            // 
            this.PbxTrack1.Image = ((System.Drawing.Image)(resources.GetObject("PbxTrack1.Image")));
            this.PbxTrack1.Location = new System.Drawing.Point(0, 0);
            this.PbxTrack1.Name = "PbxTrack1";
            this.PbxTrack1.Size = new System.Drawing.Size(840, 650);
            this.PbxTrack1.TabIndex = 0;
            this.PbxTrack1.TabStop = false;
            // 
            // PbxTrack2
            // 
            this.PbxTrack2.Image = ((System.Drawing.Image)(resources.GetObject("PbxTrack2.Image")));
            this.PbxTrack2.Location = new System.Drawing.Point(0, -650);
            this.PbxTrack2.Name = "PbxTrack2";
            this.PbxTrack2.Size = new System.Drawing.Size(840, 650);
            this.PbxTrack2.TabIndex = 2;
            this.PbxTrack2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.PbxCoin);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.LblDefeat);
            this.Controls.Add(this.PbxEnemy2);
            this.Controls.Add(this.PbxEnemy1);
            this.Controls.Add(this.PbxCar);
            this.Controls.Add(this.PbxTrack1);
            this.Controls.Add(this.PbxTrack2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форсаж";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.PanelStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoinLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTrack2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxTrack1;
        private System.Windows.Forms.PictureBox PbxCar;
        private System.Windows.Forms.Timer TimerAnim;
        private System.Windows.Forms.PictureBox PbxTrack2;
        private System.Windows.Forms.PictureBox PbxEnemy1;
        private System.Windows.Forms.PictureBox PbxEnemy2;
        private System.Windows.Forms.Label LblDefeat;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.PictureBox PbxCoin;
        private System.Windows.Forms.PictureBox PbxCoinLogo;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Label LblCountCoin;
        private System.Windows.Forms.Label LblTitleCoint;
    }
}

