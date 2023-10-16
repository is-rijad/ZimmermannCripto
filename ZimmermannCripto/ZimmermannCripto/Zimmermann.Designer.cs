namespace ZimmermannCripto {
    partial class Frm_Zimmermann {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            rb_Encryption = new RadioButton();
            gb_EncDec = new GroupBox();
            label1 = new Label();
            rb_Decryption = new RadioButton();
            txt_Unos = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_Rezultat = new TextBox();
            btn_Izvrsi = new Button();
            gb_EncDec.SuspendLayout();
            SuspendLayout();
            // 
            // rb_Encryption
            // 
            rb_Encryption.AutoSize = true;
            rb_Encryption.Cursor = Cursors.Hand;
            rb_Encryption.Location = new Point(19, 48);
            rb_Encryption.Margin = new Padding(3, 4, 3, 4);
            rb_Encryption.Name = "rb_Encryption";
            rb_Encryption.Size = new Size(94, 24);
            rb_Encryption.TabIndex = 0;
            rb_Encryption.TabStop = true;
            rb_Encryption.Text = "Enkripcija";
            rb_Encryption.UseVisualStyleBackColor = true;
            rb_Encryption.CheckedChanged += rb_Encryption_CheckedChanged;
            // 
            // gb_EncDec
            // 
            gb_EncDec.Controls.Add(label1);
            gb_EncDec.Controls.Add(rb_Decryption);
            gb_EncDec.Controls.Add(rb_Encryption);
            gb_EncDec.Location = new Point(14, 16);
            gb_EncDec.Margin = new Padding(3, 4, 3, 4);
            gb_EncDec.Name = "gb_EncDec";
            gb_EncDec.Padding = new Padding(3, 4, 3, 4);
            gb_EncDec.Size = new Size(877, 81);
            gb_EncDec.TabIndex = 1;
            gb_EncDec.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 24);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Izaberite opciju";
            // 
            // rb_Decryption
            // 
            rb_Decryption.AutoSize = true;
            rb_Decryption.Cursor = Cursors.Hand;
            rb_Decryption.Location = new Point(134, 48);
            rb_Decryption.Margin = new Padding(3, 4, 3, 4);
            rb_Decryption.Name = "rb_Decryption";
            rb_Decryption.Size = new Size(97, 24);
            rb_Decryption.TabIndex = 1;
            rb_Decryption.TabStop = true;
            rb_Decryption.Text = "Dekripcija";
            rb_Decryption.UseVisualStyleBackColor = true;
            rb_Decryption.CheckedChanged += rb_Decryption_CheckedChanged;
            // 
            // txt_Unos
            // 
            txt_Unos.Location = new Point(33, 145);
            txt_Unos.Margin = new Padding(3, 4, 3, 4);
            txt_Unos.Multiline = true;
            txt_Unos.Name = "txt_Unos";
            txt_Unos.Size = new Size(857, 175);
            txt_Unos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Unesite text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 364);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Rezultat";
            // 
            // txt_Rezultat
            // 
            txt_Rezultat.Location = new Point(33, 388);
            txt_Rezultat.Margin = new Padding(3, 4, 3, 4);
            txt_Rezultat.Multiline = true;
            txt_Rezultat.Name = "txt_Rezultat";
            txt_Rezultat.ReadOnly = true;
            txt_Rezultat.Size = new Size(857, 175);
            txt_Rezultat.TabIndex = 5;
            // 
            // btn_Izvrsi
            // 
            btn_Izvrsi.Cursor = Cursors.Hand;
            btn_Izvrsi.Location = new Point(777, 329);
            btn_Izvrsi.Margin = new Padding(3, 4, 3, 4);
            btn_Izvrsi.Name = "btn_Izvrsi";
            btn_Izvrsi.Size = new Size(113, 31);
            btn_Izvrsi.TabIndex = 6;
            btn_Izvrsi.UseVisualStyleBackColor = true;
            btn_Izvrsi.Click += btn_Izvrsi_Click;
            // 
            // Frm_Zimmermann
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 588);
            Controls.Add(btn_Izvrsi);
            Controls.Add(txt_Rezultat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Unos);
            Controls.Add(gb_EncDec);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Zimmermann";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zimmermann Enryption-Decryption";
            Load += Frm_Zimmermann_Load;
            gb_EncDec.ResumeLayout(false);
            gb_EncDec.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rb_Encryption;
        private GroupBox gb_EncDec;
        private RadioButton rb_Decryption;
        private Label label1;
        private TextBox txt_Unos;
        private Label label2;
        private Label label3;
        private TextBox txt_Rezultat;
        private Button btn_Izvrsi;
    }
}