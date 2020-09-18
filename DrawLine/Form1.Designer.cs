namespace DrawLine
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
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.btDraw = new System.Windows.Forms.Button();
            this.textx1 = new System.Windows.Forms.TextBox();
            this.textx2 = new System.Windows.Forms.TextBox();
            this.texty1 = new System.Windows.Forms.TextBox();
            this.texty2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Location = new System.Drawing.Point(234, 66);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(508, 334);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            // 
            // btDraw
            // 
            this.btDraw.Location = new System.Drawing.Point(27, 62);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(145, 58);
            this.btDraw.TabIndex = 1;
            this.btDraw.Text = "Draw Something";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // textx1
            // 
            this.textx1.Location = new System.Drawing.Point(83, 148);
            this.textx1.Name = "textx1";
            this.textx1.Size = new System.Drawing.Size(89, 20);
            this.textx1.TabIndex = 2;
          
            // 
            // textx2
            // 
            this.textx2.Location = new System.Drawing.Point(83, 174);
            this.textx2.Name = "textx2";
            this.textx2.Size = new System.Drawing.Size(89, 20);
            this.textx2.TabIndex = 3;
        
            // 
            // texty1
            // 
            this.texty1.Location = new System.Drawing.Point(83, 200);
            this.texty1.Name = "texty1";
            this.texty1.Size = new System.Drawing.Size(89, 20);
            this.texty1.TabIndex = 4;
            // 
            // texty2
            // 
            this.texty2.Location = new System.Drawing.Point(83, 226);
            this.texty2.Name = "texty2";
            this.texty2.Size = new System.Drawing.Size(89, 20);
            this.texty2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texty2);
            this.Controls.Add(this.texty1);
            this.Controls.Add(this.textx2);
            this.Controls.Add(this.textx1);
            this.Controls.Add(this.btDraw);
            this.Controls.Add(this.drawingArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingArea;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.TextBox textx1;
        private System.Windows.Forms.TextBox textx2;
        private System.Windows.Forms.TextBox texty1;
        private System.Windows.Forms.TextBox texty2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

