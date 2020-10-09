namespace WindowsFormsApp1
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
            this.input1 = new System.Windows.Forms.RichTextBox();
            this.input3 = new System.Windows.Forms.RichTextBox();
            this.input5 = new System.Windows.Forms.RichTextBox();
            this.decode_DES_ECB = new System.Windows.Forms.Button();
            this.encode_DES_ECB = new System.Windows.Forms.Button();
            this.encode_DES_CBC = new System.Windows.Forms.Button();
            this.decode_DES_CBC = new System.Windows.Forms.Button();
            this.encode_Rijndael_EBC = new System.Windows.Forms.Button();
            this.decode_Rijndael_EBC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delta1 = new System.Windows.Forms.Label();
            this.delta2 = new System.Windows.Forms.Label();
            this.delta3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.RichTextBox();
            this.input4 = new System.Windows.Forms.RichTextBox();
            this.input6 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.delta4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.encode_RC2_CBF = new System.Windows.Forms.Button();
            this.decode_RC2_CBF = new System.Windows.Forms.Button();
            this.input8 = new System.Windows.Forms.RichTextBox();
            this.input7 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(19, 62);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(221, 77);
            this.input1.TabIndex = 0;
            this.input1.Text = "";
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(19, 169);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(221, 77);
            this.input3.TabIndex = 2;
            this.input3.Text = "";
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(19, 280);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(221, 77);
            this.input5.TabIndex = 4;
            this.input5.Text = "";
            // 
            // decode_DES_ECB
            // 
            this.decode_DES_ECB.Location = new System.Drawing.Point(294, 116);
            this.decode_DES_ECB.Name = "decode_DES_ECB";
            this.decode_DES_ECB.Size = new System.Drawing.Size(75, 23);
            this.decode_DES_ECB.TabIndex = 6;
            this.decode_DES_ECB.Text = "Decode";
            this.decode_DES_ECB.UseVisualStyleBackColor = true;
            this.decode_DES_ECB.Click += new System.EventHandler(this.decode_DES_ECB_Click);
            // 
            // encode_DES_ECB
            // 
            this.encode_DES_ECB.Location = new System.Drawing.Point(294, 60);
            this.encode_DES_ECB.Name = "encode_DES_ECB";
            this.encode_DES_ECB.Size = new System.Drawing.Size(75, 23);
            this.encode_DES_ECB.TabIndex = 7;
            this.encode_DES_ECB.Text = "Encode";
            this.encode_DES_ECB.UseVisualStyleBackColor = true;
            this.encode_DES_ECB.Click += new System.EventHandler(this.encode_DES_ECB_Click);
            // 
            // encode_DES_CBC
            // 
            this.encode_DES_CBC.Location = new System.Drawing.Point(294, 167);
            this.encode_DES_CBC.Name = "encode_DES_CBC";
            this.encode_DES_CBC.Size = new System.Drawing.Size(75, 23);
            this.encode_DES_CBC.TabIndex = 9;
            this.encode_DES_CBC.Text = "Encode";
            this.encode_DES_CBC.UseVisualStyleBackColor = true;
            this.encode_DES_CBC.Click += new System.EventHandler(this.encode_DES_CBC_Click);
            // 
            // decode_DES_CBC
            // 
            this.decode_DES_CBC.Location = new System.Drawing.Point(294, 223);
            this.decode_DES_CBC.Name = "decode_DES_CBC";
            this.decode_DES_CBC.Size = new System.Drawing.Size(75, 23);
            this.decode_DES_CBC.TabIndex = 8;
            this.decode_DES_CBC.Text = "Decode";
            this.decode_DES_CBC.UseVisualStyleBackColor = true;
            this.decode_DES_CBC.Click += new System.EventHandler(this.decode_DES_CBC_Click);
            // 
            // encode_Rijndael_EBC
            // 
            this.encode_Rijndael_EBC.Location = new System.Drawing.Point(294, 280);
            this.encode_Rijndael_EBC.Name = "encode_Rijndael_EBC";
            this.encode_Rijndael_EBC.Size = new System.Drawing.Size(75, 23);
            this.encode_Rijndael_EBC.TabIndex = 11;
            this.encode_Rijndael_EBC.Text = "Encode";
            this.encode_Rijndael_EBC.UseVisualStyleBackColor = true;
            this.encode_Rijndael_EBC.Click += new System.EventHandler(this.encode_Rijndael_EBC_Click);
            // 
            // decode_Rijndael_EBC
            // 
            this.decode_Rijndael_EBC.Location = new System.Drawing.Point(294, 336);
            this.decode_Rijndael_EBC.Name = "decode_Rijndael_EBC";
            this.decode_Rijndael_EBC.Size = new System.Drawing.Size(75, 23);
            this.decode_Rijndael_EBC.TabIndex = 10;
            this.decode_Rijndael_EBC.Text = "Decode";
            this.decode_Rijndael_EBC.UseVisualStyleBackColor = true;
            this.decode_Rijndael_EBC.Click += new System.EventHandler(this.decode_Rijndael_EBC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time";
            // 
            // delta1
            // 
            this.delta1.AutoSize = true;
            this.delta1.Location = new System.Drawing.Point(317, 92);
            this.delta1.Name = "delta1";
            this.delta1.Size = new System.Drawing.Size(36, 13);
            this.delta1.TabIndex = 15;
            this.delta1.Text = "delta1";
            // 
            // delta2
            // 
            this.delta2.AutoSize = true;
            this.delta2.Location = new System.Drawing.Point(317, 203);
            this.delta2.Name = "delta2";
            this.delta2.Size = new System.Drawing.Size(36, 13);
            this.delta2.TabIndex = 16;
            this.delta2.Text = "delta2";
            // 
            // delta3
            // 
            this.delta3.AutoSize = true;
            this.delta3.Location = new System.Drawing.Point(317, 313);
            this.delta3.Name = "delta3";
            this.delta3.Size = new System.Drawing.Size(36, 13);
            this.delta3.TabIndex = 17;
            this.delta3.Text = "delta3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DES ECB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "DES CBC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rijndael EBC";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(434, 62);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(221, 77);
            this.input2.TabIndex = 1;
            this.input2.Text = "";
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(434, 169);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(221, 77);
            this.input4.TabIndex = 3;
            this.input4.Text = "";
            // 
            // input6
            // 
            this.input6.Location = new System.Drawing.Point(434, 280);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(221, 77);
            this.input6.TabIndex = 5;
            this.input6.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "RC2 CBF";
            // 
            // delta4
            // 
            this.delta4.AutoSize = true;
            this.delta4.Location = new System.Drawing.Point(317, 420);
            this.delta4.Name = "delta4";
            this.delta4.Size = new System.Drawing.Size(36, 13);
            this.delta4.TabIndex = 26;
            this.delta4.Text = "delta4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Time";
            // 
            // encode_RC2_CBF
            // 
            this.encode_RC2_CBF.Location = new System.Drawing.Point(294, 387);
            this.encode_RC2_CBF.Name = "encode_RC2_CBF";
            this.encode_RC2_CBF.Size = new System.Drawing.Size(75, 23);
            this.encode_RC2_CBF.TabIndex = 24;
            this.encode_RC2_CBF.Text = "Encode";
            this.encode_RC2_CBF.UseVisualStyleBackColor = true;
            this.encode_RC2_CBF.Click += new System.EventHandler(this.encode_RC2_CBF_Click);
            // 
            // decode_RC2_CBF
            // 
            this.decode_RC2_CBF.Location = new System.Drawing.Point(294, 443);
            this.decode_RC2_CBF.Name = "decode_RC2_CBF";
            this.decode_RC2_CBF.Size = new System.Drawing.Size(75, 23);
            this.decode_RC2_CBF.TabIndex = 23;
            this.decode_RC2_CBF.Text = "Decode";
            this.decode_RC2_CBF.UseVisualStyleBackColor = true;
            this.decode_RC2_CBF.Click += new System.EventHandler(this.decode_RC2_CBF_Click);
            // 
            // input8
            // 
            this.input8.Location = new System.Drawing.Point(434, 387);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(221, 77);
            this.input8.TabIndex = 22;
            this.input8.Text = "";
            // 
            // input7
            // 
            this.input7.Location = new System.Drawing.Point(19, 387);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(221, 77);
            this.input7.TabIndex = 21;
            this.input7.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 520);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.delta4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.encode_RC2_CBF);
            this.Controls.Add(this.decode_RC2_CBF);
            this.Controls.Add(this.input8);
            this.Controls.Add(this.input7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delta3);
            this.Controls.Add(this.delta2);
            this.Controls.Add(this.delta1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encode_Rijndael_EBC);
            this.Controls.Add(this.decode_Rijndael_EBC);
            this.Controls.Add(this.encode_DES_CBC);
            this.Controls.Add(this.decode_DES_CBC);
            this.Controls.Add(this.encode_DES_ECB);
            this.Controls.Add(this.decode_DES_ECB);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input1;
        private System.Windows.Forms.RichTextBox input3;
        private System.Windows.Forms.RichTextBox input5;
        private System.Windows.Forms.Button decode_DES_ECB;
        private System.Windows.Forms.Button encode_DES_ECB;
        private System.Windows.Forms.Button encode_DES_CBC;
        private System.Windows.Forms.Button decode_DES_CBC;
        private System.Windows.Forms.Button encode_Rijndael_EBC;
        private System.Windows.Forms.Button decode_Rijndael_EBC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label delta1;
        private System.Windows.Forms.Label delta2;
        private System.Windows.Forms.Label delta3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox input2;
        private System.Windows.Forms.RichTextBox input4;
        private System.Windows.Forms.RichTextBox input6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label delta4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button encode_RC2_CBF;
        private System.Windows.Forms.Button decode_RC2_CBF;
        private System.Windows.Forms.RichTextBox input8;
        private System.Windows.Forms.RichTextBox input7;
    }
}

