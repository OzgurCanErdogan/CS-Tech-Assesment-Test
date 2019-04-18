namespace CStechAssignment
{
    partial class GameScreen
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
            this.numberOfPlus = new System.Windows.Forms.NumericUpDown();
            this.numberOfNegatives = new System.Windows.Forms.NumericUpDown();
            this.userGuess = new System.Windows.Forms.NumericUpDown();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.positiveLabel = new System.Windows.Forms.Label();
            this.negativeLabel = new System.Windows.Forms.Label();
            this.chatBoxPc = new System.Windows.Forms.ListBox();
            this.submit1 = new System.Windows.Forms.Button();
            this.submit2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNegatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tahmininizi Giriniz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfPlus
            // 
            this.numberOfPlus.Location = new System.Drawing.Point(262, 308);
            this.numberOfPlus.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberOfPlus.Name = "numberOfPlus";
            this.numberOfPlus.Size = new System.Drawing.Size(120, 20);
            this.numberOfPlus.TabIndex = 3;
            this.numberOfPlus.ValueChanged += new System.EventHandler(this.numberOfPlus_ValueChanged);
            // 
            // numberOfNegatives
            // 
            this.numberOfNegatives.Location = new System.Drawing.Point(262, 359);
            this.numberOfNegatives.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberOfNegatives.Name = "numberOfNegatives";
            this.numberOfNegatives.Size = new System.Drawing.Size(120, 20);
            this.numberOfNegatives.TabIndex = 4;
            this.numberOfNegatives.ValueChanged += new System.EventHandler(this.numberOfNegatives_ValueChanged);
            // 
            // userGuess
            // 
            this.userGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userGuess.Location = new System.Drawing.Point(650, 300);
            this.userGuess.Maximum = new decimal(new int[] {
            9876,
            0,
            0,
            0});
            this.userGuess.Minimum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.userGuess.Name = "userGuess";
            this.userGuess.Size = new System.Drawing.Size(120, 26);
            this.userGuess.TabIndex = 5;
            this.userGuess.Value = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.userGuess.ValueChanged += new System.EventHandler(this.userGuess_ValueChanged);
            // 
            // chatBox
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.Location = new System.Drawing.Point(28, 92);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(355, 173);
            this.chatBox.TabIndex = 6;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(27, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(196, 24);
            this.name.TabIndex = 7;
            this.name.Text = "Özgür Can Erdoğan";
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameName.Location = new System.Drawing.Point(27, 56);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(162, 20);
            this.gameName.TabIndex = 8;
            this.gameName.Text = "Sayı Tahmin Oyunu";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(25, 274);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(335, 13);
            this.description.TabIndex = 11;
            this.description.Text = "Bilgisayarın tahmin ettiği sayı içinde tuttuğunuz sayının rakamları varsa:";
            // 
            // positiveLabel
            // 
            this.positiveLabel.AutoSize = true;
            this.positiveLabel.Location = new System.Drawing.Point(25, 309);
            this.positiveLabel.Name = "positiveLabel";
            this.positiveLabel.Size = new System.Drawing.Size(232, 13);
            this.positiveLabel.TabIndex = 12;
            this.positiveLabel.Text = "Basamak Değeri Doğru Rakam Sayısı (+ Sayısı):";
            // 
            // negativeLabel
            // 
            this.negativeLabel.AutoSize = true;
            this.negativeLabel.Location = new System.Drawing.Point(28, 361);
            this.negativeLabel.Name = "negativeLabel";
            this.negativeLabel.Size = new System.Drawing.Size(228, 13);
            this.negativeLabel.TabIndex = 13;
            this.negativeLabel.Text = "Basamak Değeri Yanlış Rakam Sayısı (- Sayısı):";
            // 
            // chatBoxPc
            // 
            this.chatBoxPc.FormattingEnabled = true;
            this.chatBoxPc.Location = new System.Drawing.Point(421, 92);
            this.chatBoxPc.Name = "chatBoxPc";
            this.chatBoxPc.Size = new System.Drawing.Size(349, 173);
            this.chatBoxPc.TabIndex = 14;
            // 
            // submit1
            // 
            this.submit1.Location = new System.Drawing.Point(148, 399);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(75, 23);
            this.submit1.TabIndex = 15;
            this.submit1.Text = "Gönder";
            this.submit1.UseVisualStyleBackColor = true;
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // submit2
            // 
            this.submit2.Location = new System.Drawing.Point(540, 399);
            this.submit2.Name = "submit2";
            this.submit2.Size = new System.Drawing.Size(75, 23);
            this.submit2.TabIndex = 16;
            this.submit2.Text = "Gönder";
            this.submit2.UseVisualStyleBackColor = true;
            this.submit2.Click += new System.EventHandler(this.submit2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rakamları birbirinden farklı olan tahmininizi giriniz:";
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(678, 22);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 18;
            this.restart.Text = "Tekrar";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit2);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.chatBoxPc);
            this.Controls.Add(this.negativeLabel);
            this.Controls.Add(this.positiveLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.userGuess);
            this.Controls.Add(this.numberOfNegatives);
            this.Controls.Add(this.numberOfPlus);
            this.Controls.Add(this.label1);
            this.Name = "GameScreen";
            this.Text = "CSTechAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNegatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfPlus;
        private System.Windows.Forms.NumericUpDown numberOfNegatives;
        private System.Windows.Forms.NumericUpDown userGuess;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label positiveLabel;
        private System.Windows.Forms.Label negativeLabel;
        private System.Windows.Forms.ListBox chatBoxPc;
        private System.Windows.Forms.Button submit1;
        private System.Windows.Forms.Button submit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restart;
    }
}

