
namespace CatchingGame
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
            this.title_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("my game", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(35, 177);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(319, 41);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Catching Game";
            // 
            // start_btn
            // 
            this.start_btn.FlatAppearance.BorderSize = 2;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("KBREINDEERGAMES", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(116, 236);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(157, 55);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            // 
            // help_btn
            // 
            this.help_btn.FlatAppearance.BorderSize = 2;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("KBREINDEERGAMES", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.Location = new System.Drawing.Point(116, 297);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(157, 50);
            this.help_btn.TabIndex = 1;
            this.help_btn.Text = "HELP";
            this.help_btn.UseVisualStyleBackColor = true;
            // 
            // quit_btn
            // 
            this.quit_btn.FlatAppearance.BorderSize = 2;
            this.quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_btn.Font = new System.Drawing.Font("KBREINDEERGAMES", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quit_btn.ForeColor = System.Drawing.Color.White;
            this.quit_btn.Location = new System.Drawing.Point(116, 353);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(157, 49);
            this.quit_btn.TabIndex = 1;
            this.quit_btn.Text = "QUIT GAME";
            this.quit_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(398, 516);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.title_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button quit_btn;
    }
}

