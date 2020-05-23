namespace Speech_Recognizer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.enableButton = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelPosX = new System.Windows.Forms.Label();
            this.labelPosY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDef = new System.Windows.Forms.Label();
            this.labelAttaq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(579, 275);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(149, 59);
            this.enableButton.TabIndex = 0;
            this.enableButton.Text = "Enable Speech";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Location = new System.Drawing.Point(579, 355);
            this.DisableButton.Name = "DisableButton";
            this.DisableButton.Size = new System.Drawing.Size(149, 59);
            this.DisableButton.TabIndex = 1;
            this.DisableButton.Text = "Disable Speech";
            this.DisableButton.UseVisualStyleBackColor = true;
            this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(46, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(698, 204);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Yo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Joueur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position en X :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position en Y :";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(221, 297);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(0, 13);
            this.labelPlayer.TabIndex = 6;
            // 
            // labelPosX
            // 
            this.labelPosX.AutoSize = true;
            this.labelPosX.Location = new System.Drawing.Point(221, 332);
            this.labelPosX.Name = "labelPosX";
            this.labelPosX.Size = new System.Drawing.Size(0, 13);
            this.labelPosX.TabIndex = 7;
            // 
            // labelPosY
            // 
            this.labelPosY.AutoSize = true;
            this.labelPosY.Location = new System.Drawing.Point(221, 363);
            this.labelPosY.Name = "labelPosY";
            this.labelPosY.Size = new System.Drawing.Size(0, 13);
            this.labelPosY.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Attaquant :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Défenseur :";
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Location = new System.Drawing.Point(221, 416);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(0, 13);
            this.labelDef.TabIndex = 11;
            // 
            // labelAttaq
            // 
            this.labelAttaq.AutoSize = true;
            this.labelAttaq.Location = new System.Drawing.Point(221, 391);
            this.labelAttaq.Name = "labelAttaq";
            this.labelAttaq.Size = new System.Drawing.Size(0, 13);
            this.labelAttaq.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAttaq);
            this.Controls.Add(this.labelDef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPosY);
            this.Controls.Add(this.labelPosX);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DisableButton);
            this.Controls.Add(this.enableButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Speech Recogniser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button DisableButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelPosX;
        private System.Windows.Forms.Label labelPosY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDef;
        private System.Windows.Forms.Label labelAttaq;
    }
}

