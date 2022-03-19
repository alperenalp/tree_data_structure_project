
namespace FinalOdev2
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
            this.ekleTextBox = new System.Windows.Forms.TextBox();
            this.ekleLabel = new System.Windows.Forms.Label();
            this.ekleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.silmeLabel = new System.Windows.Forms.Label();
            this.silmeTextBox = new System.Windows.Forms.TextBox();
            this.bulButton = new System.Windows.Forms.Button();
            this.duzeyLabel = new System.Windows.Forms.Label();
            this.bulmaTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gosterButton1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yapraklarLabel = new System.Windows.Forms.Label();
            this.yapraklarBox = new System.Windows.Forms.TextBox();
            this.yukseklikBox = new System.Windows.Forms.TextBox();
            this.yukseklikLabel = new System.Windows.Forms.Label();
            this.miktarLabel = new System.Windows.Forms.Label();
            this.miktarBox = new System.Windows.Forms.TextBox();
            this.PostorderLabel = new System.Windows.Forms.Label();
            this.postorderBox = new System.Windows.Forms.TextBox();
            this.InorderLabel = new System.Windows.Forms.Label();
            this.preorderBox = new System.Windows.Forms.TextBox();
            this.preorderLabel = new System.Windows.Forms.Label();
            this.inorderBox = new System.Windows.Forms.TextBox();
            this.gosterButton2 = new System.Windows.Forms.Button();
            this.duzeyLabel2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ekleTextBox
            // 
            this.ekleTextBox.Location = new System.Drawing.Point(129, 12);
            this.ekleTextBox.Name = "ekleTextBox";
            this.ekleTextBox.Size = new System.Drawing.Size(100, 20);
            this.ekleTextBox.TabIndex = 0;
            // 
            // ekleLabel
            // 
            this.ekleLabel.AutoSize = true;
            this.ekleLabel.Location = new System.Drawing.Point(12, 15);
            this.ekleLabel.Name = "ekleLabel";
            this.ekleLabel.Size = new System.Drawing.Size(94, 13);
            this.ekleLabel.TabIndex = 1;
            this.ekleLabel.Text = "... düğümü eklendi";
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(235, 10);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(88, 22);
            this.ekleButton.TabIndex = 2;
            this.ekleButton.Text = "Düğüm Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.butonEkle_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(235, 38);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(88, 22);
            this.silButton.TabIndex = 5;
            this.silButton.Text = "Düğüm Silme";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // silmeLabel
            // 
            this.silmeLabel.AutoSize = true;
            this.silmeLabel.Location = new System.Drawing.Point(12, 43);
            this.silmeLabel.Name = "silmeLabel";
            this.silmeLabel.Size = new System.Drawing.Size(87, 13);
            this.silmeLabel.TabIndex = 4;
            this.silmeLabel.Text = "... düğümü Silindi";
            // 
            // silmeTextBox
            // 
            this.silmeTextBox.Location = new System.Drawing.Point(129, 40);
            this.silmeTextBox.Name = "silmeTextBox";
            this.silmeTextBox.Size = new System.Drawing.Size(100, 20);
            this.silmeTextBox.TabIndex = 3;
            // 
            // bulButton
            // 
            this.bulButton.Location = new System.Drawing.Point(235, 66);
            this.bulButton.Name = "bulButton";
            this.bulButton.Size = new System.Drawing.Size(88, 22);
            this.bulButton.TabIndex = 8;
            this.bulButton.Text = "Düğüm Bul";
            this.bulButton.UseVisualStyleBackColor = true;
            this.bulButton.Click += new System.EventHandler(this.bulButton_Click);
            // 
            // duzeyLabel
            // 
            this.duzeyLabel.AutoSize = true;
            this.duzeyLabel.Location = new System.Drawing.Point(12, 71);
            this.duzeyLabel.Name = "duzeyLabel";
            this.duzeyLabel.Size = new System.Drawing.Size(100, 13);
            this.duzeyLabel.TabIndex = 7;
            this.duzeyLabel.Text = "Düğümün Düzeyi ...";
            // 
            // bulmaTextBox
            // 
            this.bulmaTextBox.Location = new System.Drawing.Point(129, 68);
            this.bulmaTextBox.Name = "bulmaTextBox";
            this.bulmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.bulmaTextBox.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(203, 235);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // gosterButton1
            // 
            this.gosterButton1.Location = new System.Drawing.Point(12, 150);
            this.gosterButton1.Name = "gosterButton1";
            this.gosterButton1.Size = new System.Drawing.Size(203, 22);
            this.gosterButton1.TabIndex = 10;
            this.gosterButton1.Text = "Ağaçtaki Düğümleri Göster";
            this.gosterButton1.UseVisualStyleBackColor = true;
            this.gosterButton1.Click += new System.EventHandler(this.gosterButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yapraklarLabel);
            this.groupBox1.Controls.Add(this.yapraklarBox);
            this.groupBox1.Controls.Add(this.yukseklikBox);
            this.groupBox1.Controls.Add(this.yukseklikLabel);
            this.groupBox1.Controls.Add(this.miktarLabel);
            this.groupBox1.Controls.Add(this.miktarBox);
            this.groupBox1.Controls.Add(this.PostorderLabel);
            this.groupBox1.Controls.Add(this.postorderBox);
            this.groupBox1.Controls.Add(this.InorderLabel);
            this.groupBox1.Controls.Add(this.preorderBox);
            this.groupBox1.Controls.Add(this.preorderLabel);
            this.groupBox1.Controls.Add(this.inorderBox);
            this.groupBox1.Location = new System.Drawing.Point(420, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 375);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ağaç Bilgileri";
            // 
            // yapraklarLabel
            // 
            this.yapraklarLabel.AutoSize = true;
            this.yapraklarLabel.Location = new System.Drawing.Point(70, 172);
            this.yapraklarLabel.Name = "yapraklarLabel";
            this.yapraklarLabel.Size = new System.Drawing.Size(96, 13);
            this.yapraklarLabel.TabIndex = 19;
            this.yapraklarLabel.Text = "Ağacın Yaprakları: ";
            // 
            // yapraklarBox
            // 
            this.yapraklarBox.Location = new System.Drawing.Point(172, 169);
            this.yapraklarBox.Name = "yapraklarBox";
            this.yapraklarBox.Size = new System.Drawing.Size(144, 20);
            this.yapraklarBox.TabIndex = 20;
            // 
            // yukseklikBox
            // 
            this.yukseklikBox.Location = new System.Drawing.Point(172, 143);
            this.yukseklikBox.Name = "yukseklikBox";
            this.yukseklikBox.Size = new System.Drawing.Size(144, 20);
            this.yukseklikBox.TabIndex = 18;
            // 
            // yukseklikLabel
            // 
            this.yukseklikLabel.AutoSize = true;
            this.yukseklikLabel.Location = new System.Drawing.Point(69, 146);
            this.yukseklikLabel.Name = "yukseklikLabel";
            this.yukseklikLabel.Size = new System.Drawing.Size(97, 13);
            this.yukseklikLabel.TabIndex = 17;
            this.yukseklikLabel.Text = "Ağacın Yüksekliği: ";
            // 
            // miktarLabel
            // 
            this.miktarLabel.AutoSize = true;
            this.miktarLabel.Location = new System.Drawing.Point(6, 117);
            this.miktarLabel.Name = "miktarLabel";
            this.miktarLabel.Size = new System.Drawing.Size(160, 13);
            this.miktarLabel.TabIndex = 16;
            this.miktarLabel.Text = "Ağaçtaki Toplam Düğüm Sayısı: ";
            // 
            // miktarBox
            // 
            this.miktarBox.Location = new System.Drawing.Point(172, 114);
            this.miktarBox.Name = "miktarBox";
            this.miktarBox.Size = new System.Drawing.Size(144, 20);
            this.miktarBox.TabIndex = 15;
            // 
            // PostorderLabel
            // 
            this.PostorderLabel.AutoSize = true;
            this.PostorderLabel.Location = new System.Drawing.Point(6, 92);
            this.PostorderLabel.Name = "PostorderLabel";
            this.PostorderLabel.Size = new System.Drawing.Size(52, 13);
            this.PostorderLabel.TabIndex = 14;
            this.PostorderLabel.Text = "Postorder";
            // 
            // postorderBox
            // 
            this.postorderBox.Location = new System.Drawing.Point(64, 89);
            this.postorderBox.Name = "postorderBox";
            this.postorderBox.Size = new System.Drawing.Size(252, 20);
            this.postorderBox.TabIndex = 14;
            // 
            // InorderLabel
            // 
            this.InorderLabel.AutoSize = true;
            this.InorderLabel.Location = new System.Drawing.Point(6, 64);
            this.InorderLabel.Name = "InorderLabel";
            this.InorderLabel.Size = new System.Drawing.Size(40, 13);
            this.InorderLabel.TabIndex = 13;
            this.InorderLabel.Text = "Inorder";
            // 
            // preorderBox
            // 
            this.preorderBox.Location = new System.Drawing.Point(64, 33);
            this.preorderBox.Name = "preorderBox";
            this.preorderBox.Size = new System.Drawing.Size(252, 20);
            this.preorderBox.TabIndex = 12;
            // 
            // preorderLabel
            // 
            this.preorderLabel.AutoSize = true;
            this.preorderLabel.Location = new System.Drawing.Point(6, 36);
            this.preorderLabel.Name = "preorderLabel";
            this.preorderLabel.Size = new System.Drawing.Size(47, 13);
            this.preorderLabel.TabIndex = 12;
            this.preorderLabel.Text = "Preorder";
            // 
            // inorderBox
            // 
            this.inorderBox.Location = new System.Drawing.Point(64, 61);
            this.inorderBox.Name = "inorderBox";
            this.inorderBox.Size = new System.Drawing.Size(252, 20);
            this.inorderBox.TabIndex = 13;
            // 
            // gosterButton2
            // 
            this.gosterButton2.Location = new System.Drawing.Point(420, 15);
            this.gosterButton2.Name = "gosterButton2";
            this.gosterButton2.Size = new System.Drawing.Size(322, 22);
            this.gosterButton2.TabIndex = 12;
            this.gosterButton2.Text = "Ağaç Bilgilerini Göster";
            this.gosterButton2.UseVisualStyleBackColor = true;
            this.gosterButton2.Click += new System.EventHandler(this.gosterButton2_Click);
            // 
            // duzeyLabel2
            // 
            this.duzeyLabel2.AutoSize = true;
            this.duzeyLabel2.Location = new System.Drawing.Point(19, 99);
            this.duzeyLabel2.Name = "duzeyLabel2";
            this.duzeyLabel2.Size = new System.Drawing.Size(87, 13);
            this.duzeyLabel2.TabIndex = 13;
            this.duzeyLabel2.Text = "Ağacın Düzeyi ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 458);
            this.Controls.Add(this.duzeyLabel2);
            this.Controls.Add(this.gosterButton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gosterButton1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bulButton);
            this.Controls.Add(this.duzeyLabel);
            this.Controls.Add(this.bulmaTextBox);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.silmeLabel);
            this.Controls.Add(this.silmeTextBox);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.ekleLabel);
            this.Controls.Add(this.ekleTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ekleTextBox;
        private System.Windows.Forms.Label ekleLabel;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Label silmeLabel;
        private System.Windows.Forms.TextBox silmeTextBox;
        private System.Windows.Forms.Button bulButton;
        private System.Windows.Forms.Label duzeyLabel;
        private System.Windows.Forms.TextBox bulmaTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button gosterButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox postorderBox;
        private System.Windows.Forms.TextBox preorderBox;
        private System.Windows.Forms.TextBox inorderBox;
        private System.Windows.Forms.Label PostorderLabel;
        private System.Windows.Forms.Label InorderLabel;
        private System.Windows.Forms.Label preorderLabel;
        private System.Windows.Forms.Label yukseklikLabel;
        private System.Windows.Forms.Label miktarLabel;
        private System.Windows.Forms.TextBox miktarBox;
        private System.Windows.Forms.Label yapraklarLabel;
        private System.Windows.Forms.TextBox yapraklarBox;
        private System.Windows.Forms.TextBox yukseklikBox;
        private System.Windows.Forms.Button gosterButton2;
        private System.Windows.Forms.Label duzeyLabel2;
    }
}

