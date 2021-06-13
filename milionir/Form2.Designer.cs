namespace milionir
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Score_0 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.flatMini1 = new theme.FlatMini();
            this.flatClose1 = new theme.FlatClose();
            this.FourthAnsweer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ThirdAnswer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SecondAnswer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FirstAnswer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Question = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Score_0)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "30";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Score_0
            // 
            this.Score_0.Image = global::milionir.Properties.Resources.Picture0;
            this.Score_0.Location = new System.Drawing.Point(647, 36);
            this.Score_0.Name = "Score_0";
            this.Score_0.Size = new System.Drawing.Size(223, 622);
            this.Score_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Score_0.TabIndex = 1;
            this.Score_0.TabStop = false;
            this.Score_0.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.flatMini1);
            this.bunifuGradientPanel1.Controls.Add(this.flatClose1);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-4, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(878, 25);
            this.bunifuGradientPanel1.TabIndex = 25;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(822, 3);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.Maroon;
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(850, 3);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // FourthAnsweer
            // 
            this.FourthAnsweer.ActiveBorderThickness = 5;
            this.FourthAnsweer.ActiveCornerRadius = 90;
            this.FourthAnsweer.ActiveFillColor = System.Drawing.Color.Black;
            this.FourthAnsweer.ActiveForecolor = System.Drawing.Color.White;
            this.FourthAnsweer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FourthAnsweer.BackColor = System.Drawing.Color.Black;
            this.FourthAnsweer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FourthAnsweer.BackgroundImage")));
            this.FourthAnsweer.ButtonText = "";
            this.FourthAnsweer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FourthAnsweer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourthAnsweer.ForeColor = System.Drawing.Color.SeaGreen;
            this.FourthAnsweer.IdleBorderThickness = 5;
            this.FourthAnsweer.IdleCornerRadius = 90;
            this.FourthAnsweer.IdleFillColor = System.Drawing.Color.Black;
            this.FourthAnsweer.IdleForecolor = System.Drawing.Color.White;
            this.FourthAnsweer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FourthAnsweer.Location = new System.Drawing.Point(5, 539);
            this.FourthAnsweer.Margin = new System.Windows.Forms.Padding(5);
            this.FourthAnsweer.Name = "FourthAnsweer";
            this.FourthAnsweer.Size = new System.Drawing.Size(308, 114);
            this.FourthAnsweer.TabIndex = 24;
            this.FourthAnsweer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FourthAnsweer.Click += new System.EventHandler(this.FourthAnsweer_Click);
            // 
            // ThirdAnswer
            // 
            this.ThirdAnswer.ActiveBorderThickness = 5;
            this.ThirdAnswer.ActiveCornerRadius = 90;
            this.ThirdAnswer.ActiveFillColor = System.Drawing.Color.Black;
            this.ThirdAnswer.ActiveForecolor = System.Drawing.Color.White;
            this.ThirdAnswer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ThirdAnswer.BackColor = System.Drawing.Color.Black;
            this.ThirdAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThirdAnswer.BackgroundImage")));
            this.ThirdAnswer.ButtonText = "";
            this.ThirdAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThirdAnswer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdAnswer.ForeColor = System.Drawing.Color.SeaGreen;
            this.ThirdAnswer.IdleBorderThickness = 5;
            this.ThirdAnswer.IdleCornerRadius = 90;
            this.ThirdAnswer.IdleFillColor = System.Drawing.Color.Black;
            this.ThirdAnswer.IdleForecolor = System.Drawing.Color.White;
            this.ThirdAnswer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ThirdAnswer.Location = new System.Drawing.Point(331, 537);
            this.ThirdAnswer.Margin = new System.Windows.Forms.Padding(5);
            this.ThirdAnswer.Name = "ThirdAnswer";
            this.ThirdAnswer.Size = new System.Drawing.Size(308, 114);
            this.ThirdAnswer.TabIndex = 23;
            this.ThirdAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ThirdAnswer.Click += new System.EventHandler(this.ThirdAnswer_Click);
            // 
            // SecondAnswer
            // 
            this.SecondAnswer.ActiveBorderThickness = 5;
            this.SecondAnswer.ActiveCornerRadius = 90;
            this.SecondAnswer.ActiveFillColor = System.Drawing.Color.Black;
            this.SecondAnswer.ActiveForecolor = System.Drawing.Color.White;
            this.SecondAnswer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SecondAnswer.BackColor = System.Drawing.Color.Black;
            this.SecondAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondAnswer.BackgroundImage")));
            this.SecondAnswer.ButtonText = "";
            this.SecondAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondAnswer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondAnswer.ForeColor = System.Drawing.Color.SeaGreen;
            this.SecondAnswer.IdleBorderThickness = 5;
            this.SecondAnswer.IdleCornerRadius = 90;
            this.SecondAnswer.IdleFillColor = System.Drawing.Color.Black;
            this.SecondAnswer.IdleForecolor = System.Drawing.Color.White;
            this.SecondAnswer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SecondAnswer.Location = new System.Drawing.Point(5, 430);
            this.SecondAnswer.Margin = new System.Windows.Forms.Padding(5);
            this.SecondAnswer.Name = "SecondAnswer";
            this.SecondAnswer.Size = new System.Drawing.Size(308, 114);
            this.SecondAnswer.TabIndex = 22;
            this.SecondAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SecondAnswer.Click += new System.EventHandler(this.SecondAnswer_Click);
            // 
            // FirstAnswer
            // 
            this.FirstAnswer.ActiveBorderThickness = 5;
            this.FirstAnswer.ActiveCornerRadius = 90;
            this.FirstAnswer.ActiveFillColor = System.Drawing.Color.Black;
            this.FirstAnswer.ActiveForecolor = System.Drawing.Color.White;
            this.FirstAnswer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FirstAnswer.BackColor = System.Drawing.Color.Black;
            this.FirstAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstAnswer.BackgroundImage")));
            this.FirstAnswer.ButtonText = "";
            this.FirstAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstAnswer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstAnswer.ForeColor = System.Drawing.Color.Transparent;
            this.FirstAnswer.IdleBorderThickness = 5;
            this.FirstAnswer.IdleCornerRadius = 90;
            this.FirstAnswer.IdleFillColor = System.Drawing.Color.Black;
            this.FirstAnswer.IdleForecolor = System.Drawing.Color.White;
            this.FirstAnswer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FirstAnswer.Location = new System.Drawing.Point(331, 430);
            this.FirstAnswer.Margin = new System.Windows.Forms.Padding(5);
            this.FirstAnswer.Name = "FirstAnswer";
            this.FirstAnswer.Size = new System.Drawing.Size(308, 114);
            this.FirstAnswer.TabIndex = 21;
            this.FirstAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FirstAnswer.Click += new System.EventHandler(this.FirstAnswer_Click_1);
            // 
            // Question
            // 
            this.Question.ActiveBorderThickness = 5;
            this.Question.ActiveCornerRadius = 90;
            this.Question.ActiveFillColor = System.Drawing.Color.Black;
            this.Question.ActiveForecolor = System.Drawing.Color.White;
            this.Question.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Question.BackColor = System.Drawing.Color.Black;
            this.Question.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Question.BackgroundImage")));
            this.Question.ButtonText = "";
            this.Question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Question.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.Color.SeaGreen;
            this.Question.IdleBorderThickness = 5;
            this.Question.IdleCornerRadius = 90;
            this.Question.IdleFillColor = System.Drawing.Color.Black;
            this.Question.IdleForecolor = System.Drawing.Color.White;
            this.Question.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Question.Location = new System.Drawing.Point(5, 324);
            this.Question.Margin = new System.Windows.Forms.Padding(5);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(634, 114);
            this.Question.TabIndex = 20;
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Question.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::milionir.Properties.Resources.cgjh1;
            this.pictureBox11.Location = new System.Drawing.Point(293, 33);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(72, 57);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::milionir.Properties.Resources.man_sayarbah_al_malyon_apk_pc_thumb;
            this.pictureBox10.Location = new System.Drawing.Point(196, 83);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(252, 238);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::milionir.Properties.Resources.jpgePeople;
            this.pictureBox9.Location = new System.Drawing.Point(396, 31);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(72, 57);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::milionir.Properties.Resources.jpge50;
            this.pictureBox8.Location = new System.Drawing.Point(182, 32);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(72, 57);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::milionir.Properties.Resources.jpgePhone;
            this.pictureBox7.Location = new System.Drawing.Point(485, 32);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(72, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::milionir.Properties.Resources.cgjh;
            this.pictureBox6.Location = new System.Drawing.Point(92, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(72, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(873, 662);
            this.Controls.Add(this.Score_0);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.FourthAnsweer);
            this.Controls.Add(this.ThirdAnswer);
            this.Controls.Add(this.SecondAnswer);
            this.Controls.Add(this.FirstAnswer);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Score_0)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuThinButton2 Question;
        private Bunifu.Framework.UI.BunifuThinButton2 SecondAnswer;
        private Bunifu.Framework.UI.BunifuThinButton2 ThirdAnswer;
        private Bunifu.Framework.UI.BunifuThinButton2 FourthAnsweer;
        private Bunifu.Framework.UI.BunifuThinButton2 FirstAnswer;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private theme.FlatMini flatMini1;
        private theme.FlatClose flatClose1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox Score_0;
        private System.Windows.Forms.Timer timer4;
    }
}