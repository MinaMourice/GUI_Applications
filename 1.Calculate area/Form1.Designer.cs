namespace Hello_World_GUI
{
    partial class Form_Mina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Area = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Length_textBox = new System.Windows.Forms.TextBox();
            this.Width_textBox = new System.Windows.Forms.TextBox();
            this.Room_Area_Result = new System.Windows.Forms.Label();
            this.Cost_Result = new System.Windows.Forms.Label();
            this.button_cost = new System.Windows.Forms.Button();
            this.Error_Message = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Carpeting Shop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Price PSF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Room Carpeting Cost";
            // 
            // button_Area
            // 
            this.button_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Area.Location = new System.Drawing.Point(423, 102);
            this.button_Area.Name = "button_Area";
            this.button_Area.Size = new System.Drawing.Size(80, 38);
            this.button_Area.TabIndex = 8;
            this.button_Area.Text = "Area";
            this.button_Area.UseVisualStyleBackColor = true;
            this.button_Area.Click += new System.EventHandler(this.button_Area_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(423, 212);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(80, 38);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(237, 203);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(144, 22);
            this.Price_textBox.TabIndex = 11;
            this.Price_textBox.TextChanged += new System.EventHandler(this.Price_textBox_TextChanged);
            // 
            // Length_textBox
            // 
            this.Length_textBox.Location = new System.Drawing.Point(237, 159);
            this.Length_textBox.Name = "Length_textBox";
            this.Length_textBox.Size = new System.Drawing.Size(144, 22);
            this.Length_textBox.TabIndex = 12;
            this.Length_textBox.TextChanged += new System.EventHandler(this.Length_textBox_TextChanged);
            // 
            // Width_textBox
            // 
            this.Width_textBox.Location = new System.Drawing.Point(237, 113);
            this.Width_textBox.Name = "Width_textBox";
            this.Width_textBox.Size = new System.Drawing.Size(144, 22);
            this.Width_textBox.TabIndex = 13;
            this.Width_textBox.TextChanged += new System.EventHandler(this.Width_textBox_TextChanged);
            // 
            // Room_Area_Result
            // 
            this.Room_Area_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Room_Area_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Area_Result.Location = new System.Drawing.Point(271, 321);
            this.Room_Area_Result.Name = "Room_Area_Result";
            this.Room_Area_Result.Size = new System.Drawing.Size(119, 25);
            this.Room_Area_Result.TabIndex = 14;
            this.Room_Area_Result.Click += new System.EventHandler(this.Room_Area_Result_Click);
            // 
            // Cost_Result
            // 
            this.Cost_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cost_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_Result.Location = new System.Drawing.Point(281, 365);
            this.Cost_Result.Name = "Cost_Result";
            this.Cost_Result.Size = new System.Drawing.Size(119, 25);
            this.Cost_Result.TabIndex = 15;
            this.Cost_Result.Click += new System.EventHandler(this.Cost_Result_Click);
            // 
            // button_cost
            // 
            this.button_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cost.Location = new System.Drawing.Point(423, 153);
            this.button_cost.Name = "button_cost";
            this.button_cost.Size = new System.Drawing.Size(80, 38);
            this.button_cost.TabIndex = 16;
            this.button_cost.Text = "Cost";
            this.button_cost.UseVisualStyleBackColor = true;
            this.button_cost.Click += new System.EventHandler(this.button1_Click);
            // 
            // Error_Message
            // 
            this.Error_Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Error_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Message.Location = new System.Drawing.Point(182, 256);
            this.Error_Message.Name = "Error_Message";
            this.Error_Message.Size = new System.Drawing.Size(163, 41);
            this.Error_Message.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Error";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form_Mina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Error_Message);
            this.Controls.Add(this.button_cost);
            this.Controls.Add(this.Cost_Result);
            this.Controls.Add(this.Room_Area_Result);
            this.Controls.Add(this.Width_textBox);
            this.Controls.Add(this.Length_textBox);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Area);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form_Mina";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Area;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.TextBox Length_textBox;
        private System.Windows.Forms.TextBox Width_textBox;
        private System.Windows.Forms.Label Room_Area_Result;
        private System.Windows.Forms.Label Cost_Result;
        private System.Windows.Forms.Button button_cost;
        private System.Windows.Forms.Label Error_Message;
        private System.Windows.Forms.Label label6;
    }
}

