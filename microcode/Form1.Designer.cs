namespace microcode
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
            this.FLAG = new System.Windows.Forms.ComboBox();
            this.ALU = new System.Windows.Forms.ComboBox();
            this.mc510 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.REGA = new System.Windows.Forms.NumericUpDown();
            this.REGB = new System.Windows.Forms.NumericUpDown();
            this.REGOUT = new System.Windows.Forms.NumericUpDown();
            this.MCPC = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.REGA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGOUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCPC)).BeginInit();
            this.SuspendLayout();
            // 
            // FLAG
            // 
            this.FLAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FLAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLAG.FormattingEnabled = true;
            this.FLAG.Items.AddRange(new object[] {
            "no jump",
            "jump on N",
            "jump on Z",
            "jump"});
            this.FLAG.Location = new System.Drawing.Point(44, 38);
            this.FLAG.Name = "FLAG";
            this.FLAG.Size = new System.Drawing.Size(121, 28);
            this.FLAG.TabIndex = 1;
            // 
            // ALU
            // 
            this.ALU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ALU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALU.FormattingEnabled = true;
            this.ALU.Items.AddRange(new object[] {
            "C := A",
            "C := Not A",
            "C := A + B",
            "C := A And B",
            "C := A Or B",
            "C := A Xor B",
            "C := Lshift(A)",
            "C := Rshift(B)"});
            this.ALU.Location = new System.Drawing.Point(44, 72);
            this.ALU.Name = "ALU";
            this.ALU.Size = new System.Drawing.Size(121, 28);
            this.ALU.TabIndex = 2;
            // 
            // mc510
            // 
            this.mc510.BackColor = System.Drawing.SystemColors.Control;
            this.mc510.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mc510.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc510.FormattingEnabled = true;
            this.mc510.Items.AddRange(new object[] {
            "Save Result to MAR",
            "Load MDR as A-input",
            "Save Result to MDR",
            "Put MDR value at MAR address",
            "MC[9]",
            "Save Result in Register"});
            this.mc510.Location = new System.Drawing.Point(44, 106);
            this.mc510.Name = "mc510";
            this.mc510.Size = new System.Drawing.Size(265, 126);
            this.mc510.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Flag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ALU instruction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Register B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Register A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Register Out";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(170, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "MCPC jump address";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(44, 447);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(254, 26);
            this.output.TabIndex = 23;
            this.output.Text = "000000000000000000000000000";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(44, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Generate MicroCode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // REGA
            // 
            this.REGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGA.Location = new System.Drawing.Point(45, 239);
            this.REGA.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.REGA.Name = "REGA";
            this.REGA.Size = new System.Drawing.Size(120, 26);
            this.REGA.TabIndex = 29;
            // 
            // REGB
            // 
            this.REGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGB.Location = new System.Drawing.Point(44, 270);
            this.REGB.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.REGB.Name = "REGB";
            this.REGB.Size = new System.Drawing.Size(120, 26);
            this.REGB.TabIndex = 30;
            // 
            // REGOUT
            // 
            this.REGOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGOUT.Location = new System.Drawing.Point(44, 302);
            this.REGOUT.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.REGOUT.Name = "REGOUT";
            this.REGOUT.Size = new System.Drawing.Size(120, 26);
            this.REGOUT.TabIndex = 31;
            // 
            // MCPC
            // 
            this.MCPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCPC.Location = new System.Drawing.Point(44, 334);
            this.MCPC.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.MCPC.Name = "MCPC";
            this.MCPC.Size = new System.Drawing.Size(120, 26);
            this.MCPC.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 510);
            this.Controls.Add(this.MCPC);
            this.Controls.Add(this.REGOUT);
            this.Controls.Add(this.REGB);
            this.Controls.Add(this.REGA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mc510);
            this.Controls.Add(this.ALU);
            this.Controls.Add(this.FLAG);
            this.Name = "Form1";
            this.Text = "Generate MicroCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REGA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REGOUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox FLAG;
        private System.Windows.Forms.ComboBox ALU;
        private System.Windows.Forms.CheckedListBox mc510;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown REGA;
        private System.Windows.Forms.NumericUpDown REGB;
        private System.Windows.Forms.NumericUpDown REGOUT;
        private System.Windows.Forms.NumericUpDown MCPC;
    }
}

