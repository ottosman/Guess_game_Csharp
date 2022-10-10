
namespace WFA_guess_last
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
            this.components = new System.ComponentModel.Container();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_universe = new System.Windows.Forms.Button();
            this.button_check_iF = new System.Windows.Forms.Button();
            this.label_header = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label_guess_counter = new System.Windows.Forms.Label();
            this.label_time_counter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(543, 261);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(366, 23);
            this.textBox_input.TabIndex = 3;
            this.textBox_input.Text = "Please insert an input";
            this.textBox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_input_KeyPress);
            // 
            // button_universe
            // 
            this.button_universe.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_universe.Location = new System.Drawing.Point(58, 129);
            this.button_universe.Name = "button_universe";
            this.button_universe.Size = new System.Drawing.Size(282, 112);
            this.button_universe.TabIndex = 2;
            this.button_universe.Text = "START THE GAME";
            this.button_universe.UseVisualStyleBackColor = true;
            this.button_universe.Click += new System.EventHandler(this.button_universe_Click);
            // 
            // button_check_iF
            // 
            this.button_check_iF.Font = new System.Drawing.Font("Unispace", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button_check_iF.Location = new System.Drawing.Point(598, 418);
            this.button_check_iF.Name = "button_check_iF";
            this.button_check_iF.Size = new System.Drawing.Size(331, 105);
            this.button_check_iF.TabIndex = 0;
            this.button_check_iF.Text = "TRY!";
            this.button_check_iF.UseVisualStyleBackColor = true;
            this.button_check_iF.Click += new System.EventHandler(this.button_check_if_Click);
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_header.Location = new System.Drawing.Point(700, 106);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(305, 60);
            this.label_header.TabIndex = 3;
            this.label_header.Text = "label_header";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_info.Location = new System.Drawing.Point(1030, 138);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(23, 33);
            this.label_info.TabIndex = 4;
            this.label_info.Text = " ";
            // 
            // label_guess_counter
            // 
            this.label_guess_counter.AutoSize = true;
            this.label_guess_counter.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_guess_counter.Location = new System.Drawing.Point(1030, 418);
            this.label_guess_counter.Name = "label_guess_counter";
            this.label_guess_counter.Size = new System.Drawing.Size(296, 33);
            this.label_guess_counter.TabIndex = 5;
            this.label_guess_counter.Text = "label_guess_counter";
            // 
            // label_time_counter
            // 
            this.label_time_counter.AutoSize = true;
            this.label_time_counter.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_time_counter.Location = new System.Drawing.Point(1030, 581);
            this.label_time_counter.Name = "label_time_counter";
            this.label_time_counter.Size = new System.Drawing.Size(279, 33);
            this.label_time_counter.TabIndex = 6;
            this.label_time_counter.Text = "label_time_counter";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 684);
            this.Controls.Add(this.label_time_counter);
            this.Controls.Add(this.label_guess_counter);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.button_check_iF);
            this.Controls.Add(this.button_universe);
            this.Controls.Add(this.textBox_input);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_universe;
        private System.Windows.Forms.Button button_check_iF;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_guess_counter;
        private System.Windows.Forms.Label label_time_counter;
        private System.Windows.Forms.Timer timer1;
    }
}

