using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TimeSpan
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码


        // Token: 0x04000005 RID: 5
        private ComboBox cbx_start_year;

        // Token: 0x04000006 RID: 6
        private Label lb_tip;

        // Token: 0x04000007 RID: 7
        private ComboBox cbx_start_month;

        // Token: 0x04000008 RID: 8
        private Label label2;

        // Token: 0x04000009 RID: 9
        private ComboBox cbx_start_days;

        // Token: 0x0400000A RID: 10
        private Label label3;

        // Token: 0x0400000B RID: 11
        private Label label4;

        // Token: 0x0400000C RID: 12
        private ComboBox cbx_end_year;

        // Token: 0x0400000D RID: 13
        private ComboBox cbx_end_month;

        // Token: 0x0400000E RID: 14
        private ComboBox cbx_end_days;

        // Token: 0x0400000F RID: 15
        private Label label5;

        // Token: 0x04000010 RID: 16
        private Label label6;

        // Token: 0x04000011 RID: 17
        private Label label7;

        // Token: 0x04000012 RID: 18
        private Label label8;

        // Token: 0x04000013 RID: 19
        private Label label1;
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbx_start_year = new System.Windows.Forms.ComboBox();
            this.cbx_start_month = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_start_days = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_end_year = new System.Windows.Forms.ComboBox();
            this.cbx_end_month = new System.Windows.Forms.ComboBox();
            this.cbx_end_days = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_tip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_start_year
            // 
            this.cbx_start_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_start_year.FormattingEnabled = true;
            this.cbx_start_year.Location = new System.Drawing.Point(36, 30);
            this.cbx_start_year.Name = "cbx_start_year";
            this.cbx_start_year.Size = new System.Drawing.Size(84, 22);
            this.cbx_start_year.TabIndex = 0;
            this.cbx_start_year.SelectedIndexChanged += new System.EventHandler(this.Cbx_start_year_SelectedIndexChanged);
            // 
            // cbx_start_month
            // 
            this.cbx_start_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_start_month.FormattingEnabled = true;
            this.cbx_start_month.Location = new System.Drawing.Point(155, 30);
            this.cbx_start_month.Name = "cbx_start_month";
            this.cbx_start_month.Size = new System.Drawing.Size(68, 22);
            this.cbx_start_month.TabIndex = 0;
            this.cbx_start_month.SelectedIndexChanged += new System.EventHandler(this.Cbx_start_month_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // cbx_start_days
            // 
            this.cbx_start_days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_start_days.FormattingEnabled = true;
            this.cbx_start_days.Location = new System.Drawing.Point(258, 30);
            this.cbx_start_days.Name = "cbx_start_days";
            this.cbx_start_days.Size = new System.Drawing.Size(63, 22);
            this.cbx_start_days.TabIndex = 0;
            this.cbx_start_days.SelectedIndexChanged += new System.EventHandler(this.Cbx_start_days_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "起始时间";
            // 
            // cbx_end_year
            // 
            this.cbx_end_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_end_year.FormattingEnabled = true;
            this.cbx_end_year.Location = new System.Drawing.Point(36, 78);
            this.cbx_end_year.Name = "cbx_end_year";
            this.cbx_end_year.Size = new System.Drawing.Size(84, 22);
            this.cbx_end_year.TabIndex = 0;
            this.cbx_end_year.SelectedIndexChanged += new System.EventHandler(this.Cbx_end_year_SelectedIndexChanged);
            // 
            // cbx_end_month
            // 
            this.cbx_end_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_end_month.FormattingEnabled = true;
            this.cbx_end_month.Location = new System.Drawing.Point(155, 78);
            this.cbx_end_month.Name = "cbx_end_month";
            this.cbx_end_month.Size = new System.Drawing.Size(68, 22);
            this.cbx_end_month.TabIndex = 0;
            this.cbx_end_month.SelectedIndexChanged += new System.EventHandler(this.Cbx_end_month_SelectedIndexChanged);
            // 
            // cbx_end_days
            // 
            this.cbx_end_days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_end_days.FormattingEnabled = true;
            this.cbx_end_days.Location = new System.Drawing.Point(258, 78);
            this.cbx_end_days.Name = "cbx_end_days";
            this.cbx_end_days.Size = new System.Drawing.Size(63, 22);
            this.cbx_end_days.TabIndex = 0;
            this.cbx_end_days.SelectedIndexChanged += new System.EventHandler(this.Cbx_end_days_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "年";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "截至时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "月";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "日";
            // 
            // lb_tip
            // 
            this.lb_tip.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_tip.ForeColor = System.Drawing.Color.Blue;
            this.lb_tip.Location = new System.Drawing.Point(28, 106);
            this.lb_tip.Name = "lb_tip";
            this.lb_tip.Size = new System.Drawing.Size(326, 28);
            this.lb_tip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(361, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 141);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_tip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_end_days);
            this.Controls.Add(this.cbx_end_month);
            this.Controls.Add(this.cbx_start_days);
            this.Controls.Add(this.cbx_end_year);
            this.Controls.Add(this.cbx_start_month);
            this.Controls.Add(this.cbx_start_year);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "时光机器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

