namespace activity_3
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
            this.jpCB = new System.Windows.Forms.CheckBox();
            this.survey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phCB = new System.Windows.Forms.CheckBox();
            this.thaiCB = new System.Windows.Forms.CheckBox();
            this.ausCB = new System.Windows.Forms.CheckBox();
            this.otherslabel = new System.Windows.Forms.Label();
            this.othersTB = new System.Windows.Forms.TextBox();
            this.submitB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.othersCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // jpCB
            // 
            this.jpCB.AutoSize = true;
            this.jpCB.Location = new System.Drawing.Point(36, 116);
            this.jpCB.Name = "jpCB";
            this.jpCB.Size = new System.Drawing.Size(55, 17);
            this.jpCB.TabIndex = 0;
            this.jpCB.Text = "Japan";
            this.jpCB.UseVisualStyleBackColor = true;
            this.jpCB.CheckedChanged += new System.EventHandler(this.jpCB_CheckedChanged);
            // 
            // survey
            // 
            this.survey.AutoSize = true;
            this.survey.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survey.Location = new System.Drawing.Point(31, 28);
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(83, 25);
            this.survey.TabIndex = 1;
            this.survey.Text = "Survey";
            this.survey.Click += new System.EventHandler(this.survey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "What country would you like to visit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phCB
            // 
            this.phCB.AutoSize = true;
            this.phCB.Location = new System.Drawing.Point(36, 139);
            this.phCB.Name = "phCB";
            this.phCB.Size = new System.Drawing.Size(76, 17);
            this.phCB.TabIndex = 3;
            this.phCB.Text = "Philippines";
            this.phCB.UseVisualStyleBackColor = true;
            this.phCB.CheckedChanged += new System.EventHandler(this.phCB_CheckedChanged);
            // 
            // thaiCB
            // 
            this.thaiCB.AutoSize = true;
            this.thaiCB.Location = new System.Drawing.Point(193, 116);
            this.thaiCB.Name = "thaiCB";
            this.thaiCB.Size = new System.Drawing.Size(67, 17);
            this.thaiCB.TabIndex = 4;
            this.thaiCB.Text = "Thailand";
            this.thaiCB.UseVisualStyleBackColor = true;
            this.thaiCB.CheckedChanged += new System.EventHandler(this.thaiCB_CheckedChanged);
            // 
            // ausCB
            // 
            this.ausCB.AutoSize = true;
            this.ausCB.Location = new System.Drawing.Point(193, 139);
            this.ausCB.Name = "ausCB";
            this.ausCB.Size = new System.Drawing.Size(66, 17);
            this.ausCB.TabIndex = 5;
            this.ausCB.Text = "Australia";
            this.ausCB.UseVisualStyleBackColor = true;
            this.ausCB.CheckedChanged += new System.EventHandler(this.ausCB_CheckedChanged);
            // 
            // otherslabel
            // 
            this.otherslabel.AutoSize = true;
            this.otherslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherslabel.Location = new System.Drawing.Point(32, 207);
            this.otherslabel.Name = "otherslabel";
            this.otherslabel.Size = new System.Drawing.Size(184, 20);
            this.otherslabel.TabIndex = 6;
            this.otherslabel.Text = "If others, please specify :";
            this.otherslabel.Visible = false;
            this.otherslabel.Click += new System.EventHandler(this.otherslabel_Click);
            // 
            // othersTB
            // 
            this.othersTB.Location = new System.Drawing.Point(36, 242);
            this.othersTB.Name = "othersTB";
            this.othersTB.Size = new System.Drawing.Size(224, 20);
            this.othersTB.TabIndex = 7;
            this.othersTB.Visible = false;
            this.othersTB.TextChanged += new System.EventHandler(this.othersTB_TextChanged);
            // 
            // submitB
            // 
            this.submitB.Location = new System.Drawing.Point(36, 277);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(75, 23);
            this.submitB.TabIndex = 8;
            this.submitB.Text = "Submit";
            this.submitB.UseVisualStyleBackColor = true;
            this.submitB.Click += new System.EventHandler(this.submitB_Click);
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(36, 318);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 23);
            this.exitB.TabIndex = 9;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // othersCB
            // 
            this.othersCB.AutoSize = true;
            this.othersCB.Location = new System.Drawing.Point(36, 172);
            this.othersCB.Name = "othersCB";
            this.othersCB.Size = new System.Drawing.Size(57, 17);
            this.othersCB.TabIndex = 10;
            this.othersCB.Text = "Others";
            this.othersCB.UseVisualStyleBackColor = true;
            this.othersCB.CheckedChanged += new System.EventHandler(this.othersCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 364);
            this.Controls.Add(this.othersCB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.submitB);
            this.Controls.Add(this.othersTB);
            this.Controls.Add(this.otherslabel);
            this.Controls.Add(this.ausCB);
            this.Controls.Add(this.thaiCB);
            this.Controls.Add(this.phCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.survey);
            this.Controls.Add(this.jpCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox jpCB;
        private System.Windows.Forms.Label survey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox phCB;
        private System.Windows.Forms.CheckBox thaiCB;
        private System.Windows.Forms.CheckBox ausCB;
        private System.Windows.Forms.Label otherslabel;
        private System.Windows.Forms.TextBox othersTB;
        private System.Windows.Forms.Button submitB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.CheckBox othersCB;

    }
}

