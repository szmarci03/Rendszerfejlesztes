namespace Ugyfelkezeles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.felvesz = new System.Windows.Forms.Button();
            this.torol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 534);
            this.dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(49, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(597, 69);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Keresés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1011, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Szűrő törlése";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // felvesz
            // 
            this.felvesz.Location = new System.Drawing.Point(731, 746);
            this.felvesz.Name = "felvesz";
            this.felvesz.Size = new System.Drawing.Size(232, 69);
            this.felvesz.TabIndex = 4;
            this.felvesz.Text = "Új ügyfél felvétele";
            this.felvesz.UseVisualStyleBackColor = true;
            // 
            // torol
            // 
            this.torol.Location = new System.Drawing.Point(1011, 746);
            this.torol.Name = "torol";
            this.torol.Size = new System.Drawing.Size(232, 69);
            this.torol.TabIndex = 5;
            this.torol.Text = "Ügyfél törlése";
            this.torol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 868);
            this.Controls.Add(this.torol);
            this.Controls.Add(this.felvesz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button felvesz;
        private System.Windows.Forms.Button torol;
    }
}

