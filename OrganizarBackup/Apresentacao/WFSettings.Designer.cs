namespace OrganizarBackup
{
    partial class WFSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WFSettings));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchInputDir = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnSearchOutputDir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchInputDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchOutputDir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(130, 118);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(267, 20);
            this.txtInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(127, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Root Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(127, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(130, 193);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(267, 20);
            this.txtOutput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(127, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Directory";
            // 
            // btnSearchInputDir
            // 
            this.btnSearchInputDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchInputDir.Image = global::OrganizarBackup.Properties.Resources._148953;
            this.btnSearchInputDir.Location = new System.Drawing.Point(403, 113);
            this.btnSearchInputDir.Name = "btnSearchInputDir";
            this.btnSearchInputDir.Size = new System.Drawing.Size(43, 29);
            this.btnSearchInputDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchInputDir.TabIndex = 11;
            this.btnSearchInputDir.TabStop = false;
            this.btnSearchInputDir.Click += new System.EventHandler(this.btnSearchInputDir_Click_1);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(173, 268);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(180, 44);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnSearchOutputDir
            // 
            this.btnSearchOutputDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchOutputDir.Image = global::OrganizarBackup.Properties.Resources._148953;
            this.btnSearchOutputDir.Location = new System.Drawing.Point(403, 187);
            this.btnSearchOutputDir.Name = "btnSearchOutputDir";
            this.btnSearchOutputDir.Size = new System.Drawing.Size(43, 29);
            this.btnSearchOutputDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchOutputDir.TabIndex = 12;
            this.btnSearchOutputDir.TabStop = false;
            this.btnSearchOutputDir.Click += new System.EventHandler(this.btnSearchOutputDir_Click_1);
            // 
            // WFSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(525, 372);
            this.Controls.Add(this.btnSearchOutputDir);
            this.Controls.Add(this.btnSearchInputDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WFSettings";
            this.Text = "WFSettings";
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchInputDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchOutputDir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnSearchInputDir;
        private System.Windows.Forms.PictureBox btnSearchOutputDir;
    }
}