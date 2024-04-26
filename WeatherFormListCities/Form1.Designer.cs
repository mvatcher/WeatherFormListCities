namespace WeatherFormListCities
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBCityA = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picIconA = new System.Windows.Forms.PictureBox();
            this.labCityA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labCityB = new System.Windows.Forms.Label();
            this.picIconB = new System.Windows.Forms.PictureBox();
            this.TBCityB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labCityC = new System.Windows.Forms.Label();
            this.picIconC = new System.Windows.Forms.PictureBox();
            this.TBCityC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIconA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // TBCityA
            // 
            this.TBCityA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCityA.Location = new System.Drawing.Point(129, 79);
            this.TBCityA.Name = "TBCityA";
            this.TBCityA.Size = new System.Drawing.Size(308, 44);
            this.TBCityA.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(316, 432);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(265, 79);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // picIconA
            // 
            this.picIconA.BackColor = System.Drawing.Color.Transparent;
            this.picIconA.Location = new System.Drawing.Point(752, 64);
            this.picIconA.Name = "picIconA";
            this.picIconA.Size = new System.Drawing.Size(89, 81);
            this.picIconA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconA.TabIndex = 13;
            this.picIconA.TabStop = false;
            // 
            // labCityA
            // 
            this.labCityA.AutoSize = true;
            this.labCityA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCityA.Location = new System.Drawing.Point(579, 82);
            this.labCityA.Name = "labCityA";
            this.labCityA.Size = new System.Drawing.Size(140, 37);
            this.labCityA.TabIndex = 14;
            this.labCityA.Text = "[Results]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Temp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Temp:";
            // 
            // labCityB
            // 
            this.labCityB.AutoSize = true;
            this.labCityB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCityB.Location = new System.Drawing.Point(579, 200);
            this.labCityB.Name = "labCityB";
            this.labCityB.Size = new System.Drawing.Size(140, 37);
            this.labCityB.TabIndex = 19;
            this.labCityB.Text = "[Results]";
            // 
            // picIconB
            // 
            this.picIconB.BackColor = System.Drawing.Color.Transparent;
            this.picIconB.Location = new System.Drawing.Point(752, 182);
            this.picIconB.Name = "picIconB";
            this.picIconB.Size = new System.Drawing.Size(89, 81);
            this.picIconB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconB.TabIndex = 18;
            this.picIconB.TabStop = false;
            // 
            // TBCityB
            // 
            this.TBCityB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCityB.Location = new System.Drawing.Point(129, 197);
            this.TBCityB.Name = "TBCityB";
            this.TBCityB.Size = new System.Drawing.Size(308, 44);
            this.TBCityB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 37);
            this.label6.TabIndex = 25;
            this.label6.Text = "Temp:";
            // 
            // labCityC
            // 
            this.labCityC.AutoSize = true;
            this.labCityC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCityC.Location = new System.Drawing.Point(579, 320);
            this.labCityC.Name = "labCityC";
            this.labCityC.Size = new System.Drawing.Size(140, 37);
            this.labCityC.TabIndex = 24;
            this.labCityC.Text = "[Results]";
            // 
            // picIconC
            // 
            this.picIconC.BackColor = System.Drawing.Color.Transparent;
            this.picIconC.Location = new System.Drawing.Point(752, 302);
            this.picIconC.Name = "picIconC";
            this.picIconC.Size = new System.Drawing.Size(89, 81);
            this.picIconC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconC.TabIndex = 23;
            this.picIconC.TabStop = false;
            // 
            // TBCityC
            // 
            this.TBCityC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCityC.Location = new System.Drawing.Point(129, 317);
            this.TBCityC.Name = "TBCityC";
            this.TBCityC.Size = new System.Drawing.Size(308, 44);
            this.TBCityC.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 37);
            this.label8.TabIndex = 21;
            this.label8.Text = "City:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labCityC);
            this.Controls.Add(this.picIconC);
            this.Controls.Add(this.TBCityC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labCityB);
            this.Controls.Add(this.picIconB);
            this.Controls.Add(this.TBCityB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labCityA);
            this.Controls.Add(this.picIconA);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCityA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIconA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCityA;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picIconA;
        private System.Windows.Forms.Label labCityA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labCityB;
        private System.Windows.Forms.PictureBox picIconB;
        private System.Windows.Forms.TextBox TBCityB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labCityC;
        private System.Windows.Forms.PictureBox picIconC;
        private System.Windows.Forms.TextBox TBCityC;
        private System.Windows.Forms.Label label8;
    }
}

