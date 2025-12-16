namespace CatLaserProiect1
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
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMiscari = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(485, 107);
            this.trackBarX.Maximum = 180;
            this.trackBarX.Minimum = 90;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(104, 56);
            this.trackBarX.TabIndex = 2;
            this.trackBarX.Value = 100;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Axa X (Sus-Jos)";
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(485, 189);
            this.trackBarY.Maximum = 180;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(104, 56);
            this.trackBarY.TabIndex = 4;
            this.trackBarY.Value = 90;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Axa Y (Stanga-Dreapta)";
            // 
            // lstMiscari
            // 
            this.lstMiscari.FormattingEnabled = true;
            this.lstMiscari.ItemHeight = 16;
            this.lstMiscari.Location = new System.Drawing.Point(27, 15);
            this.lstMiscari.Name = "lstMiscari";
            this.lstMiscari.Size = new System.Drawing.Size(295, 196);
            this.lstMiscari.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adaugă Poziția Curentă";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(27, 285);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(295, 28);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sortează  (Algortim)";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(472, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(295, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Salvează în Fișier";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(27, 353);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(295, 28);
            this.btnExecute.TabIndex = 10;
            this.btnExecute.Text = "Execută Lista";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(512, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Conectare";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(406, 15);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 12;
            this.txtPort.Text = "COM4";
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged_1);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(27, 251);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(295, 28);
            this.btnRandom.TabIndex = 13;
            this.btnRandom.Text = "Generează Mișcări Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(295, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Curată Listă";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(27, 387);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(295, 28);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop Execuție";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(472, 387);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(295, 28);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Incarcă Fișier";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstMiscari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMiscari;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoad;
    }
}

