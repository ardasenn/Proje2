namespace ABOACIDIYET
{
    partial class UserScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStandartKilo = new System.Windows.Forms.Label();
            this.lblBodyIndex = new System.Windows.Forms.Label();
            this.cbMeal = new System.Windows.Forms.ComboBox();
            this.btnMealSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKiloSave = new System.Windows.Forms.Button();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataTimeNow = new System.Windows.Forms.Label();
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.cbActivityTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTargetEndDate = new System.Windows.Forms.Label();
            this.lblTargetStartDate = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRapors = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStandartKilo);
            this.groupBox1.Controls.Add(this.lblBodyIndex);
            this.groupBox1.Location = new System.Drawing.Point(1207, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(291, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı bilgileri";
            // 
            // lblStandartKilo
            // 
            this.lblStandartKilo.AutoSize = true;
            this.lblStandartKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStandartKilo.Location = new System.Drawing.Point(9, 59);
            this.lblStandartKilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStandartKilo.Name = "lblStandartKilo";
            this.lblStandartKilo.Size = new System.Drawing.Size(92, 25);
            this.lblStandartKilo.TabIndex = 0;
            this.lblStandartKilo.Text = "İdeal Kilo";
            // 
            // lblBodyIndex
            // 
            this.lblBodyIndex.AutoSize = true;
            this.lblBodyIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBodyIndex.Location = new System.Drawing.Point(9, 23);
            this.lblBodyIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBodyIndex.Name = "lblBodyIndex";
            this.lblBodyIndex.Size = new System.Drawing.Size(163, 25);
            this.lblBodyIndex.TabIndex = 0;
            this.lblBodyIndex.Text = "Vücut Kitle İndexi";
            // 
            // cbMeal
            // 
            this.cbMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMeal.FormattingEnabled = true;
            this.cbMeal.Location = new System.Drawing.Point(496, 90);
            this.cbMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMeal.Name = "cbMeal";
            this.cbMeal.Size = new System.Drawing.Size(152, 33);
            this.cbMeal.TabIndex = 2;
            // 
            // btnMealSelect
            // 
            this.btnMealSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMealSelect.Location = new System.Drawing.Point(496, 143);
            this.btnMealSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnMealSelect.Name = "btnMealSelect";
            this.btnMealSelect.Size = new System.Drawing.Size(152, 180);
            this.btnMealSelect.TabIndex = 1;
            this.btnMealSelect.Text = "+";
            this.btnMealSelect.UseVisualStyleBackColor = true;
            this.btnMealSelect.Click += new System.EventHandler(this.btnMealSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKiloSave);
            this.groupBox3.Controls.Add(this.txtKilo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblDataTimeNow);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(21, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(375, 201);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Günlük Veri Girişi";
            // 
            // btnKiloSave
            // 
            this.btnKiloSave.Location = new System.Drawing.Point(180, 149);
            this.btnKiloSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnKiloSave.Name = "btnKiloSave";
            this.btnKiloSave.Size = new System.Drawing.Size(176, 44);
            this.btnKiloSave.TabIndex = 3;
            this.btnKiloSave.Text = "Kaydet";
            this.btnKiloSave.UseVisualStyleBackColor = true;
            this.btnKiloSave.Click += new System.EventHandler(this.btnKiloSave_Click);
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(180, 97);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(175, 36);
            this.txtKilo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güncel Kilo :";
            // 
            // lblDataTimeNow
            // 
            this.lblDataTimeNow.AutoSize = true;
            this.lblDataTimeNow.Location = new System.Drawing.Point(107, 53);
            this.lblDataTimeNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataTimeNow.Name = "lblDataTimeNow";
            this.lblDataTimeNow.Size = new System.Drawing.Size(139, 29);
            this.lblDataTimeNow.TabIndex = 1;
            this.lblDataTimeNow.Text = "11/06/2022";
            // 
            // cbActivity
            // 
            this.cbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Location = new System.Drawing.Point(15, 27);
            this.cbActivity.Margin = new System.Windows.Forms.Padding(4);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(465, 33);
            this.cbActivity.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddActivity);
            this.groupBox4.Controls.Add(this.cbActivityTime);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.cbActivity);
            this.groupBox4.Location = new System.Drawing.Point(21, 235);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(501, 330);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktiviteler";
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(280, 286);
            this.btnAddActivity.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(201, 37);
            this.btnAddActivity.TabIndex = 5;
            this.btnAddActivity.Text = "Ekle";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // cbActivityTime
            // 
            this.cbActivityTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbActivityTime.FormattingEnabled = true;
            this.cbActivityTime.Location = new System.Drawing.Point(171, 70);
            this.cbActivityTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbActivityTime.Name = "cbActivityTime";
            this.cbActivityTime.Size = new System.Drawing.Size(309, 33);
            this.cbActivityTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aktivite süresi";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(15, 124);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(465, 154);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTargetEndDate);
            this.groupBox5.Controls.Add(this.lblTargetStartDate);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(437, 14);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(762, 85);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aktif Hedef";
            // 
            // lblTargetEndDate
            // 
            this.lblTargetEndDate.AutoSize = true;
            this.lblTargetEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTargetEndDate.Location = new System.Drawing.Point(396, 28);
            this.lblTargetEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetEndDate.Name = "lblTargetEndDate";
            this.lblTargetEndDate.Size = new System.Drawing.Size(162, 29);
            this.lblTargetEndDate.TabIndex = 4;
            this.lblTargetEndDate.Text = "Hedefin Bitişi";
            // 
            // lblTargetStartDate
            // 
            this.lblTargetStartDate.AutoSize = true;
            this.lblTargetStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTargetStartDate.Location = new System.Drawing.Point(92, 28);
            this.lblTargetStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetStartDate.Name = "lblTargetStartDate";
            this.lblTargetStartDate.Size = new System.Drawing.Size(224, 29);
            this.lblTargetStartDate.TabIndex = 4;
            this.lblTargetStartDate.Text = "Hedefin Başlangıcı";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(602, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 75);
            this.button3.TabIndex = 0;
            this.button3.Text = "Hedeflerim";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(633, 120);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(566, 28);
            this.progressBar1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(410, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hedefe Giden Yol ";
            // 
            // cbRapors
            // 
            this.cbRapors.FormattingEnabled = true;
            this.cbRapors.Location = new System.Drawing.Point(15, 23);
            this.cbRapors.Margin = new System.Windows.Forms.Padding(4);
            this.cbRapors.Name = "cbRapors";
            this.cbRapors.Size = new System.Drawing.Size(271, 33);
            this.cbRapors.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnReport);
            this.groupBox6.Controls.Add(this.cbRapors);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(1207, 271);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(295, 138);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Raporlar";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport.Location = new System.Drawing.Point(15, 57);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(272, 74);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Raporla";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 343);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMeal);
            this.groupBox2.Controls.Add(this.btnMealSelect);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(534, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(665, 386);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğünlerim";
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 609);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserScreen";
            this.Load += new System.EventHandler(this.UserScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMealSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKiloSave;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataTimeNow;
        private System.Windows.Forms.ComboBox cbActivity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbActivityTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblStandartKilo;
        private System.Windows.Forms.Label lblBodyIndex;
        private System.Windows.Forms.Label lblTargetEndDate;
        private System.Windows.Forms.Label lblTargetStartDate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRapors;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.ComboBox cbMeal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}