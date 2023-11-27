namespace U3_P2_Practica_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(440, 25);
            label1.TabIndex = 0;
            label1.Text = "Genera los numeros del 1 al 20 con While";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(128, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 404);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(90, 483);
            button1.Name = "button1";
            button1.Size = new Size(295, 34);
            button1.TabIndex = 2;
            button1.Text = "Imprime en pantalla\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(480, 543);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "1 al 20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
    }
}