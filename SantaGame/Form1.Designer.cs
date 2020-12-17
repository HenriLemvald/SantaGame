
namespace SantaGame
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
            this.Jouluvana = new System.Windows.Forms.PictureBox();
            this.kuusk = new System.Windows.Forms.PictureBox();
            this.kuu = new System.Windows.Forms.PictureBox();
            this.majake = new System.Windows.Forms.PictureBox();
            this.maa = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Jouluvana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuusk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maa)).BeginInit();
            this.SuspendLayout();
            // 
            // Jouluvana
            // 
            this.Jouluvana.Image = global::SantaGame.Properties.Resources.sleigh;
            this.Jouluvana.Location = new System.Drawing.Point(27, 256);
            this.Jouluvana.Name = "Jouluvana";
            this.Jouluvana.Size = new System.Drawing.Size(140, 58);
            this.Jouluvana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jouluvana.TabIndex = 7;
            this.Jouluvana.TabStop = false;
            this.Jouluvana.Click += new System.EventHandler(this.Jouluvana_Click);
            // 
            // kuusk
            // 
            this.kuusk.Image = global::SantaGame.Properties.Resources.tree;
            this.kuusk.Location = new System.Drawing.Point(504, 310);
            this.kuusk.Name = "kuusk";
            this.kuusk.Size = new System.Drawing.Size(100, 193);
            this.kuusk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kuusk.TabIndex = 6;
            this.kuusk.TabStop = false;
            // 
            // kuu
            // 
            this.kuu.Image = global::SantaGame.Properties.Resources.moon;
            this.kuu.Location = new System.Drawing.Point(280, 36);
            this.kuu.Name = "kuu";
            this.kuu.Size = new System.Drawing.Size(214, 99);
            this.kuu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kuu.TabIndex = 5;
            this.kuu.TabStop = false;
            // 
            // majake
            // 
            this.majake.Image = global::SantaGame.Properties.Resources.hut;
            this.majake.Location = new System.Drawing.Point(280, 404);
            this.majake.Name = "majake";
            this.majake.Size = new System.Drawing.Size(112, 99);
            this.majake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.majake.TabIndex = 3;
            this.majake.TabStop = false;
            // 
            // maa
            // 
            this.maa.Image = global::SantaGame.Properties.Resources.ground;
            this.maa.Location = new System.Drawing.Point(-32, 500);
            this.maa.Name = "maa";
            this.maa.Size = new System.Drawing.Size(744, 50);
            this.maa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maa.TabIndex = 15;
            this.maa.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(131, 31);
            this.ScoreLabel.TabIndex = 16;
            this.ScoreLabel.Text = "Score : 0";
            this.ScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 90);
            this.button1.TabIndex = 18;
            this.button1.Text = "Mängi uuesti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(616, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.maa);
            this.Controls.Add(this.Jouluvana);
            this.Controls.Add(this.kuusk);
            this.Controls.Add(this.kuu);
            this.Controls.Add(this.majake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Jouluvana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuusk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox majake;
        private System.Windows.Forms.PictureBox kuu;
        private System.Windows.Forms.PictureBox kuusk;
        private System.Windows.Forms.PictureBox Jouluvana;
        private System.Windows.Forms.PictureBox maa;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

