namespace USteuerbetrag
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdCalculate1 = new System.Windows.Forms.Button();
            this.CmdCalculate2 = new System.Windows.Forms.Button();
            this.TBxUserInput = new System.Windows.Forms.TextBox();
            this.LblGehalt = new System.Windows.Forms.Label();
            this.LblSteuerbetrag = new System.Windows.Forms.Label();
            this.CmdSteuertabelleAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCalculate1
            // 
            this.CmdCalculate1.Location = new System.Drawing.Point(12, 56);
            this.CmdCalculate1.Name = "CmdCalculate1";
            this.CmdCalculate1.Size = new System.Drawing.Size(148, 23);
            this.CmdCalculate1.TabIndex = 0;
            this.CmdCalculate1.Text = "Berchnen mit if...else";
            this.CmdCalculate1.UseVisualStyleBackColor = true;
            this.CmdCalculate1.Click += new System.EventHandler(this.CmdCalculate1_Click);
            // 
            // CmdCalculate2
            // 
            this.CmdCalculate2.Location = new System.Drawing.Point(12, 85);
            this.CmdCalculate2.Name = "CmdCalculate2";
            this.CmdCalculate2.Size = new System.Drawing.Size(148, 23);
            this.CmdCalculate2.TabIndex = 1;
            this.CmdCalculate2.Text = "Berechnen mit switch";
            this.CmdCalculate2.UseVisualStyleBackColor = true;
            this.CmdCalculate2.Click += new System.EventHandler(this.CmdCalculate2_Click);
            // 
            // TBxUserInput
            // 
            this.TBxUserInput.Location = new System.Drawing.Point(12, 27);
            this.TBxUserInput.Name = "TBxUserInput";
            this.TBxUserInput.Size = new System.Drawing.Size(122, 23);
            this.TBxUserInput.TabIndex = 2;
            // 
            // LblGehalt
            // 
            this.LblGehalt.AutoSize = true;
            this.LblGehalt.Location = new System.Drawing.Point(12, 9);
            this.LblGehalt.Name = "LblGehalt";
            this.LblGehalt.Size = new System.Drawing.Size(44, 15);
            this.LblGehalt.TabIndex = 3;
            this.LblGehalt.Text = "Gehalt:";
            // 
            // LblSteuerbetrag
            // 
            this.LblSteuerbetrag.AutoSize = true;
            this.LblSteuerbetrag.Location = new System.Drawing.Point(167, 30);
            this.LblSteuerbetrag.Name = "LblSteuerbetrag";
            this.LblSteuerbetrag.Size = new System.Drawing.Size(77, 15);
            this.LblSteuerbetrag.TabIndex = 4;
            this.LblSteuerbetrag.Text = "Steuerbetrag:";
            // 
            // CmdSteuertabelleAnzeigen
            // 
            this.CmdSteuertabelleAnzeigen.Location = new System.Drawing.Point(12, 114);
            this.CmdSteuertabelleAnzeigen.Name = "CmdSteuertabelleAnzeigen";
            this.CmdSteuertabelleAnzeigen.Size = new System.Drawing.Size(148, 23);
            this.CmdSteuertabelleAnzeigen.TabIndex = 5;
            this.CmdSteuertabelleAnzeigen.Text = "Steuertabelle anzeigen";
            this.CmdSteuertabelleAnzeigen.UseVisualStyleBackColor = true;
            this.CmdSteuertabelleAnzeigen.Click += new System.EventHandler(this.CmdSteuertabelleAnzeigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 309);
            this.Controls.Add(this.CmdSteuertabelleAnzeigen);
            this.Controls.Add(this.LblSteuerbetrag);
            this.Controls.Add(this.LblGehalt);
            this.Controls.Add(this.TBxUserInput);
            this.Controls.Add(this.CmdCalculate2);
            this.Controls.Add(this.CmdCalculate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdCalculate1;
        private Button CmdCalculate2;
        private TextBox TBxUserInput;
        private Label LblGehalt;
        private Label LblSteuerbetrag;
        private Button CmdSteuertabelleAnzeigen;
    }
}