namespace Nibbles
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xposLabel = new System.Windows.Forms.Label();
            this.yposLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerCountLabel = new System.Windows.Forms.Label();
            this.xposDispl = new System.Windows.Forms.Label();
            this.yposDispl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel1.Controls.Add(this.xposLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.yposLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.timerLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.timerCountLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.xposDispl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.yposDispl, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.03922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.96078F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // xposLabel
            // 
            this.xposLabel.AutoSize = true;
            this.xposLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xposLabel.Location = new System.Drawing.Point(3, 0);
            this.xposLabel.Name = "xposLabel";
            this.xposLabel.Size = new System.Drawing.Size(141, 49);
            this.xposLabel.TabIndex = 0;
            this.xposLabel.Text = "x";
            // 
            // yposLabel
            // 
            this.yposLabel.AutoSize = true;
            this.yposLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yposLabel.Location = new System.Drawing.Point(3, 49);
            this.yposLabel.Name = "yposLabel";
            this.yposLabel.Size = new System.Drawing.Size(141, 53);
            this.yposLabel.TabIndex = 1;
            this.yposLabel.Text = "y";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerLabel.Location = new System.Drawing.Point(3, 102);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(141, 159);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "Timer Ticks";
            // 
            // timerCountLabel
            // 
            this.timerCountLabel.AutoSize = true;
            this.timerCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerCountLabel.Location = new System.Drawing.Point(150, 102);
            this.timerCountLabel.Name = "timerCountLabel";
            this.timerCountLabel.Size = new System.Drawing.Size(131, 159);
            this.timerCountLabel.TabIndex = 3;
            this.timerCountLabel.Text = "0";
            // 
            // xposDispl
            // 
            this.xposDispl.AutoSize = true;
            this.xposDispl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xposDispl.Location = new System.Drawing.Point(150, 0);
            this.xposDispl.Name = "xposDispl";
            this.xposDispl.Size = new System.Drawing.Size(131, 49);
            this.xposDispl.TabIndex = 4;
            this.xposDispl.Text = " ";
            // 
            // yposDispl
            // 
            this.yposDispl.AutoSize = true;
            this.yposDispl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yposDispl.Location = new System.Drawing.Point(150, 49);
            this.yposDispl.Name = "yposDispl";
            this.yposDispl.Size = new System.Drawing.Size(131, 53);
            this.yposDispl.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Nibbles 2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label xposLabel;
        private System.Windows.Forms.Label yposLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timerCountLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label xposDispl;
        private System.Windows.Forms.Label yposDispl;
    }
}

