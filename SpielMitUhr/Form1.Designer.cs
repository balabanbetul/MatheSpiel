namespace SpielMitUhr
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
            this.aufgabe_lbl = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Button();
            this.checkIt_button = new System.Windows.Forms.Button();
            this.result_label = new System.Windows.Forms.Label();
            this.antwort_box = new System.Windows.Forms.TextBox();
            this.warch_label = new System.Windows.Forms.Label();
            this.requiredTime_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aufgabe_lbl
            // 
            this.aufgabe_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aufgabe_lbl.Location = new System.Drawing.Point(41, 29);
            this.aufgabe_lbl.Name = "aufgabe_lbl";
            this.aufgabe_lbl.Size = new System.Drawing.Size(242, 192);
            this.aufgabe_lbl.TabIndex = 0;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(27, 250);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(126, 33);
            this.New.TabIndex = 1;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // checkIt_button
            // 
            this.checkIt_button.Location = new System.Drawing.Point(159, 250);
            this.checkIt_button.Name = "checkIt_button";
            this.checkIt_button.Size = new System.Drawing.Size(126, 33);
            this.checkIt_button.TabIndex = 2;
            this.checkIt_button.Text = "Check it";
            this.checkIt_button.UseVisualStyleBackColor = true;
            this.checkIt_button.Click += new System.EventHandler(this.checkIt_button_Click);
            // 
            // result_label
            // 
            this.result_label.Location = new System.Drawing.Point(446, 190);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(277, 144);
            this.result_label.TabIndex = 3;
            this.result_label.Text = "Result";
            this.result_label.Visible = false;
            // 
            // antwort_box
            // 
            this.antwort_box.Location = new System.Drawing.Point(160, 170);
            this.antwort_box.Name = "antwort_box";
            this.antwort_box.Size = new System.Drawing.Size(125, 22);
            this.antwort_box.TabIndex = 4;
            // 
            // warch_label
            // 
            this.warch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warch_label.Location = new System.Drawing.Point(445, 99);
            this.warch_label.Name = "warch_label";
            this.warch_label.Size = new System.Drawing.Size(246, 36);
            this.warch_label.TabIndex = 5;
            this.warch_label.Text = "00:00:00:00";
            this.warch_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.warch_label.Visible = false;
            // 
            // requiredTime_label
            // 
            this.requiredTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredTime_label.Location = new System.Drawing.Point(446, 39);
            this.requiredTime_label.Name = "requiredTime_label";
            this.requiredTime_label.Size = new System.Drawing.Size(243, 51);
            this.requiredTime_label.TabIndex = 6;
            this.requiredTime_label.Text = "required time :  30 sec";
            this.requiredTime_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.requiredTime_label.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.requiredTime_label);
            this.Controls.Add(this.warch_label);
            this.Controls.Add(this.antwort_box);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.checkIt_button);
            this.Controls.Add(this.New);
            this.Controls.Add(this.aufgabe_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aufgabe_lbl;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button checkIt_button;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.TextBox antwort_box;
        private System.Windows.Forms.Label warch_label;
        private System.Windows.Forms.Label requiredTime_label;
        private System.Windows.Forms.Timer timer1;
    }
}

