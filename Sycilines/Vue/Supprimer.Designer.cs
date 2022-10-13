namespace Sycilines.Vue
{
    partial class Supprimer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Label();
            this.suppr = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-537, -13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1607, 91);
            this.label2.TabIndex = 11;
            this.label2.Text = " dsv  sdlknnqlmknkvsqlknvmlqskndfvlqkdnff0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-537, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1607, 91);
            this.label1.TabIndex = 12;
            this.label1.Text = " dsv  sdlknnqlmknkvsqlknvmlqskndfvlqkdnff0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Voulez vous confirmer la suppresion de cette liaison:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Location = new System.Drawing.Point(113, 132);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(0, 13);
            this.confirm.TabIndex = 14;
            this.confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suppr
            // 
            this.suppr.Location = new System.Drawing.Point(232, 180);
            this.suppr.Name = "suppr";
            this.suppr.Size = new System.Drawing.Size(75, 23);
            this.suppr.TabIndex = 15;
            this.suppr.Text = "Supprimer";
            this.suppr.UseVisualStyleBackColor = true;
            this.suppr.Click += new System.EventHandler(this.suppr_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(232, 209);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 16;
            this.annuler.Text = "annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.suppr);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Supprimer";
            this.Text = "Supréssion";
            this.Load += new System.EventHandler(this.suppr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.Button suppr;
        private System.Windows.Forms.Button annuler;
    }
}