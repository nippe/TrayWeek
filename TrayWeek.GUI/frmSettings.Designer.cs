namespace TrayWeek.GUI
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.drpWeekStartDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpFirstWeek = new System.Windows.Forms.ComboBox();
            this.brnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First day of week";
            // 
            // drpWeekStartDay
            // 
            this.drpWeekStartDay.FormattingEnabled = true;
            this.drpWeekStartDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.drpWeekStartDay.Location = new System.Drawing.Point(12, 29);
            this.drpWeekStartDay.Name = "drpWeekStartDay";
            this.drpWeekStartDay.Size = new System.Drawing.Size(186, 21);
            this.drpWeekStartDay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First week of year starts with";
            // 
            // drpFirstWeek
            // 
            this.drpFirstWeek.FormattingEnabled = true;
            this.drpFirstWeek.Items.AddRange(new object[] {
            "First 4-day week",
            "1 january",
            "First full week"});
            this.drpFirstWeek.Location = new System.Drawing.Point(12, 83);
            this.drpFirstWeek.Name = "drpFirstWeek";
            this.drpFirstWeek.Size = new System.Drawing.Size(186, 21);
            this.drpFirstWeek.TabIndex = 3;
            // 
            // brnOk
            // 
            this.brnOk.Location = new System.Drawing.Point(12, 110);
            this.brnOk.Name = "brnOk";
            this.brnOk.Size = new System.Drawing.Size(75, 23);
            this.brnOk.TabIndex = 4;
            this.brnOk.Text = "OK";
            this.brnOk.UseVisualStyleBackColor = true;
            this.brnOk.Click += new System.EventHandler(this.brnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 150);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.brnOk);
            this.Controls.Add(this.drpFirstWeek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drpWeekStartDay);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "TrayWeek Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpWeekStartDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpFirstWeek;
        private System.Windows.Forms.Button brnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}