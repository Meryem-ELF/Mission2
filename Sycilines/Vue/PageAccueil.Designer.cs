namespace ScilyLinesMission2
{
    partial class PageAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAccueil));
            this.secteurBox = new System.Windows.Forms.ListBox();
            this.liaisonBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // secteurBox
            // 
            this.secteurBox.FormattingEnabled = true;
            this.secteurBox.Location = new System.Drawing.Point(197, 147);
            this.secteurBox.Name = "secteurBox";
            this.secteurBox.Size = new System.Drawing.Size(120, 95);
            this.secteurBox.TabIndex = 0;
            this.secteurBox.SelectedIndexChanged += new System.EventHandler(this.secteurBox_SelectedIndexChanged);
            // 
            // liaisonBox
            // 
            this.liaisonBox.FormattingEnabled = true;
            this.liaisonBox.Location = new System.Drawing.Point(534, 147);
            this.liaisonBox.Name = "liaisonBox";
            this.liaisonBox.Size = new System.Drawing.Size(120, 95);
            this.liaisonBox.TabIndex = 1;
            this.liaisonBox.SelectedIndexChanged += new System.EventHandler(this.liaisonBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectionner le \r\nsecteur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selectionner la \r\nliaison:";
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(352, 331);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(105, 23);
            this.ajouter.TabIndex = 4;
            this.ajouter.Text = "Ajouter Liaison";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(226, 331);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(109, 23);
            this.supprimer.TabIndex = 5;
            this.supprimer.Text = "Supprimer Liaison";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(-2, -9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1607, 91);
            this.label3.TabIndex = 6;
            this.label3.Text = " dsv  sdlknnqlmknkvsqlknvmlqskndfvlqkdnff0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-293, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1356, 76);
            this.label4.TabIndex = 8;
            this.label4.Text = " dsv  sdlknnqlmknkvsqlknvmlqskndfvlqkdnff0";
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(475, 331);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(109, 23);
            this.modifier.TabIndex = 9;
            this.modifier.Text = "Modifier Liaison";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Impact", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(378, 65);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sycilines Admin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liaisonBox);
            this.Controls.Add(this.secteurBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PageAccueil";
            this.Text = "Sycilines";
            this.Load += new System.EventHandler(this.PageAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox secteurBox;
        private System.Windows.Forms.ListBox liaisonBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Label label5;
    }
}

