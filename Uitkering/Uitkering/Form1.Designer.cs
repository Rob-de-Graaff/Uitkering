namespace Uitkering
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.listBoxEmployees);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 32);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(348, 208);
            this.panelLayout.TabIndex = 30;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 16;
            this.listBoxEmployees.Location = new System.Drawing.Point(3, 3);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(173, 68);
            this.listBoxEmployees.TabIndex = 59;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(3, 152);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(136, 38);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show benefit";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(3, 115);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(3, 132);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 252);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
    }
}

