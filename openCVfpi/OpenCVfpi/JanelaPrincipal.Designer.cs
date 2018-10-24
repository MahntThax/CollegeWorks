namespace OpenCVfpi
{
    partial class JanelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.GaussBar = new System.Windows.Forms.TrackBar();
            this.webcamBox = new Emgu.CV.UI.ImageBox();
            this.GaussTip = new System.Windows.Forms.ToolTip(this.components);
            this.GaussText = new System.Windows.Forms.TextBox();
            this.gaussCheck = new System.Windows.Forms.CheckBox();
            this.cannyCheck = new System.Windows.Forms.CheckBox();
            this.sobelCheck = new System.Windows.Forms.CheckBox();
            this.brilhoBar = new System.Windows.Forms.TrackBar();
            this.brilhoCheck = new System.Windows.Forms.CheckBox();
            this.contrastCheck = new System.Windows.Forms.CheckBox();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.negativeCheck = new System.Windows.Forms.CheckBox();
            this.grayCheck = new System.Windows.Forms.CheckBox();
            this.halveCheck = new System.Windows.Forms.CheckBox();
            this.rotateCounter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rotateClock = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mirrorHori = new System.Windows.Forms.Button();
            this.mirrorVert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GaussBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brilhoBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GaussBar
            // 
            this.GaussBar.LargeChange = 8;
            this.GaussBar.Location = new System.Drawing.Point(698, 36);
            this.GaussBar.Maximum = 99;
            this.GaussBar.Minimum = 1;
            this.GaussBar.Name = "GaussBar";
            this.GaussBar.Size = new System.Drawing.Size(243, 45);
            this.GaussBar.SmallChange = 2;
            this.GaussBar.TabIndex = 1;
            this.GaussBar.TickFrequency = 10;
            this.GaussBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GaussBar.Value = 1;
            // 
            // webcamBox
            // 
            this.webcamBox.Location = new System.Drawing.Point(13, 13);
            this.webcamBox.Name = "webcamBox";
            this.webcamBox.Size = new System.Drawing.Size(679, 481);
            this.webcamBox.TabIndex = 2;
            this.webcamBox.TabStop = false;
            // 
            // GaussText
            // 
            this.GaussText.BackColor = System.Drawing.SystemColors.Control;
            this.GaussText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GaussText.Location = new System.Drawing.Point(793, 13);
            this.GaussText.Name = "GaussText";
            this.GaussText.ReadOnly = true;
            this.GaussText.Size = new System.Drawing.Size(148, 13);
            this.GaussText.TabIndex = 3;
            // 
            // gaussCheck
            // 
            this.gaussCheck.AutoSize = true;
            this.gaussCheck.Location = new System.Drawing.Point(698, 13);
            this.gaussCheck.Name = "gaussCheck";
            this.gaussCheck.Size = new System.Drawing.Size(89, 17);
            this.gaussCheck.TabIndex = 4;
            this.gaussCheck.Text = "Aplicar gauss";
            this.gaussCheck.UseVisualStyleBackColor = true;
            // 
            // cannyCheck
            // 
            this.cannyCheck.AutoSize = true;
            this.cannyCheck.Location = new System.Drawing.Point(698, 64);
            this.cannyCheck.Name = "cannyCheck";
            this.cannyCheck.Size = new System.Drawing.Size(90, 17);
            this.cannyCheck.TabIndex = 5;
            this.cannyCheck.Text = "Aplicar canny";
            this.cannyCheck.UseVisualStyleBackColor = true;
            // 
            // sobelCheck
            // 
            this.sobelCheck.AutoSize = true;
            this.sobelCheck.Location = new System.Drawing.Point(698, 87);
            this.sobelCheck.Name = "sobelCheck";
            this.sobelCheck.Size = new System.Drawing.Size(86, 17);
            this.sobelCheck.TabIndex = 6;
            this.sobelCheck.Text = "Aplicar sobel";
            this.sobelCheck.UseVisualStyleBackColor = true;
            // 
            // brilhoBar
            // 
            this.brilhoBar.LargeChange = 10;
            this.brilhoBar.Location = new System.Drawing.Point(698, 133);
            this.brilhoBar.Maximum = 100;
            this.brilhoBar.Minimum = 1;
            this.brilhoBar.Name = "brilhoBar";
            this.brilhoBar.Size = new System.Drawing.Size(243, 45);
            this.brilhoBar.TabIndex = 7;
            this.brilhoBar.TickFrequency = 0;
            this.brilhoBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brilhoBar.Value = 1;
            // 
            // brilhoCheck
            // 
            this.brilhoCheck.AutoSize = true;
            this.brilhoCheck.Location = new System.Drawing.Point(698, 110);
            this.brilhoCheck.Name = "brilhoCheck";
            this.brilhoCheck.Size = new System.Drawing.Size(55, 17);
            this.brilhoCheck.TabIndex = 9;
            this.brilhoCheck.Text = "Brilho:";
            this.brilhoCheck.UseVisualStyleBackColor = true;
            // 
            // contrastCheck
            // 
            this.contrastCheck.AutoSize = true;
            this.contrastCheck.Location = new System.Drawing.Point(698, 161);
            this.contrastCheck.Name = "contrastCheck";
            this.contrastCheck.Size = new System.Drawing.Size(74, 17);
            this.contrastCheck.TabIndex = 10;
            this.contrastCheck.Text = "Contraste:";
            this.contrastCheck.UseVisualStyleBackColor = true;
            // 
            // contrastBar
            // 
            this.contrastBar.LargeChange = 10;
            this.contrastBar.Location = new System.Drawing.Point(698, 184);
            this.contrastBar.Maximum = 100;
            this.contrastBar.Minimum = 1;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(243, 45);
            this.contrastBar.TabIndex = 11;
            this.contrastBar.TickFrequency = 0;
            this.contrastBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.contrastBar.Value = 1;
            // 
            // negativeCheck
            // 
            this.negativeCheck.AutoSize = true;
            this.negativeCheck.Location = new System.Drawing.Point(698, 212);
            this.negativeCheck.Name = "negativeCheck";
            this.negativeCheck.Size = new System.Drawing.Size(69, 17);
            this.negativeCheck.TabIndex = 12;
            this.negativeCheck.Text = "Negativo";
            this.negativeCheck.UseVisualStyleBackColor = true;
            // 
            // grayCheck
            // 
            this.grayCheck.AutoSize = true;
            this.grayCheck.Location = new System.Drawing.Point(698, 235);
            this.grayCheck.Name = "grayCheck";
            this.grayCheck.Size = new System.Drawing.Size(93, 17);
            this.grayCheck.TabIndex = 13;
            this.grayCheck.Text = "Tons de cinza";
            this.grayCheck.UseVisualStyleBackColor = true;
            // 
            // halveCheck
            // 
            this.halveCheck.AutoSize = true;
            this.halveCheck.Location = new System.Drawing.Point(698, 258);
            this.halveCheck.Name = "halveCheck";
            this.halveCheck.Size = new System.Drawing.Size(122, 17);
            this.halveCheck.TabIndex = 14;
            this.halveCheck.Text = "Redimensionamento";
            this.halveCheck.UseVisualStyleBackColor = true;
            // 
            // rotateCounter
            // 
            this.rotateCounter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateCounter.BackgroundImage")));
            this.rotateCounter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateCounter.Location = new System.Drawing.Point(826, 281);
            this.rotateCounter.Name = "rotateCounter";
            this.rotateCounter.Size = new System.Drawing.Size(30, 30);
            this.rotateCounter.TabIndex = 16;
            this.rotateCounter.UseVisualStyleBackColor = true;
            this.rotateCounter.Click += new System.EventHandler(this.rotateCounter_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(698, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 24);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Rotacionar:";
            // 
            // rotateClock
            // 
            this.rotateClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateClock.BackgroundImage")));
            this.rotateClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateClock.Location = new System.Drawing.Point(862, 281);
            this.rotateClock.Name = "rotateClock";
            this.rotateClock.Size = new System.Drawing.Size(30, 30);
            this.rotateClock.TabIndex = 18;
            this.rotateClock.UseVisualStyleBackColor = true;
            this.rotateClock.Click += new System.EventHandler(this.rotateClock_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(698, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(122, 24);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Espelhar:";
            // 
            // mirrorHori
            // 
            this.mirrorHori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mirrorHori.BackgroundImage")));
            this.mirrorHori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mirrorHori.Location = new System.Drawing.Point(826, 317);
            this.mirrorHori.Name = "mirrorHori";
            this.mirrorHori.Size = new System.Drawing.Size(30, 30);
            this.mirrorHori.TabIndex = 20;
            this.mirrorHori.UseVisualStyleBackColor = true;
            this.mirrorHori.Click += new System.EventHandler(this.mirrorHori_Click);
            // 
            // mirrorVert
            // 
            this.mirrorVert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mirrorVert.BackgroundImage")));
            this.mirrorVert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mirrorVert.Location = new System.Drawing.Point(862, 317);
            this.mirrorVert.Name = "mirrorVert";
            this.mirrorVert.Size = new System.Drawing.Size(30, 30);
            this.mirrorVert.TabIndex = 21;
            this.mirrorVert.UseVisualStyleBackColor = true;
            this.mirrorVert.Click += new System.EventHandler(this.mirrorVert_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 506);
            this.Controls.Add(this.mirrorVert);
            this.Controls.Add(this.mirrorHori);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rotateClock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rotateCounter);
            this.Controls.Add(this.halveCheck);
            this.Controls.Add(this.grayCheck);
            this.Controls.Add(this.negativeCheck);
            this.Controls.Add(this.contrastBar);
            this.Controls.Add(this.contrastCheck);
            this.Controls.Add(this.brilhoCheck);
            this.Controls.Add(this.brilhoBar);
            this.Controls.Add(this.sobelCheck);
            this.Controls.Add(this.cannyCheck);
            this.Controls.Add(this.gaussCheck);
            this.Controls.Add(this.GaussText);
            this.Controls.Add(this.webcamBox);
            this.Controls.Add(this.GaussBar);
            this.Name = "JanelaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GaussBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brilhoBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar GaussBar;
        private Emgu.CV.UI.ImageBox webcamBox;
        private System.Windows.Forms.ToolTip GaussTip;
        private System.Windows.Forms.TextBox GaussText;
        private System.Windows.Forms.CheckBox gaussCheck;
        private System.Windows.Forms.CheckBox cannyCheck;
        private System.Windows.Forms.CheckBox sobelCheck;
        private System.Windows.Forms.TrackBar brilhoBar;
        private System.Windows.Forms.CheckBox brilhoCheck;
        private System.Windows.Forms.CheckBox contrastCheck;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.CheckBox negativeCheck;
        private System.Windows.Forms.CheckBox grayCheck;
        private System.Windows.Forms.CheckBox halveCheck;
        private System.Windows.Forms.Button rotateCounter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button rotateClock;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button mirrorHori;
        private System.Windows.Forms.Button mirrorVert;
    }
}

