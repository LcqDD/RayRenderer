﻿namespace RayRenderer
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

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFPS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.BackColor = System.Drawing.Color.Transparent;
            this.lblFPS.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFPS.Location = new System.Drawing.Point(545, 22);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(11, 12);
            this.lblFPS.TabIndex = 0;
            this.lblFPS.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(510, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "FPS:";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(1, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(461, 457);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(512, 129);
            this.bar.Maximum = 20;
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(201, 45);
            this.bar.TabIndex = 4;
            this.bar.Value = 10;
            this.bar.Scroll += new System.EventHandler(this.bar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 469);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFPS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TrackBar bar;
    }
}

