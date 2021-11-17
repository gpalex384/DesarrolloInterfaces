namespace Primitive_Lottery
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.reintegroText = new System.Windows.Forms.TextBox();
            this.manualButton = new System.Windows.Forms.Button();
            this.automaticButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.reintegroText, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.manualButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.automaticButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.eraseButton, 5, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 6);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 127);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLACE YOUR BETS!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 376);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reimbursement:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reintegroText
            // 
            this.reintegroText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.reintegroText, 2);
            this.reintegroText.Location = new System.Drawing.Point(369, 529);
            this.reintegroText.Name = "reintegroText";
            this.reintegroText.ReadOnly = true;
            this.reintegroText.Size = new System.Drawing.Size(100, 22);
            this.reintegroText.TabIndex = 2;
            // 
            // manualButton
            // 
            this.manualButton.BackColor = System.Drawing.Color.Lime;
            this.manualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualButton.Location = new System.Drawing.Point(10, 582);
            this.manualButton.Margin = new System.Windows.Forms.Padding(10);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(163, 45);
            this.manualButton.TabIndex = 4;
            this.manualButton.Text = "MANUAL";
            this.manualButton.UseVisualStyleBackColor = false;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // automaticButton
            // 
            this.automaticButton.BackColor = System.Drawing.Color.DarkOrange;
            this.tableLayoutPanel1.SetColumnSpan(this.automaticButton, 4);
            this.automaticButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.automaticButton.Location = new System.Drawing.Point(193, 582);
            this.automaticButton.Margin = new System.Windows.Forms.Padding(10);
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Size = new System.Drawing.Size(224, 45);
            this.automaticButton.TabIndex = 5;
            this.automaticButton.Text = "AUTOMATIC";
            this.automaticButton.UseVisualStyleBackColor = false;
            this.automaticButton.Click += new System.EventHandler(this.automaticButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eraseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eraseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eraseButton.Location = new System.Drawing.Point(437, 582);
            this.eraseButton.Margin = new System.Windows.Forms.Padding(10);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(164, 45);
            this.eraseButton.TabIndex = 6;
            this.eraseButton.Text = "ERASE";
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(611, 637);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PRIMITIVE. GOOD LUCK!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reintegroText;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Button automaticButton;
        private System.Windows.Forms.Button eraseButton;
    }
}

