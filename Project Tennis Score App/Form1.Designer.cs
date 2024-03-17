namespace Project_Tennis_Score_App
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
            this.Ranking = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rankinglist = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listgames = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ranking
            // 
            this.Ranking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ranking.AutoSize = true;
            this.Ranking.Location = new System.Drawing.Point(49, 54);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(68, 20);
            this.Ranking.TabIndex = 0;
            this.Ranking.Text = "Ranking";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tennis Score\r\n";
            // 
            // rankinglist
            // 
            this.rankinglist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rankinglist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.columnHeader1});
            this.rankinglist.HideSelection = false;
            this.rankinglist.Location = new System.Drawing.Point(53, 87);
            this.rankinglist.Name = "rankinglist";
            this.rankinglist.Size = new System.Drawing.Size(634, 97);
            this.rankinglist.TabIndex = 2;
            this.rankinglist.UseCompatibleStateImageBehavior = false;
            this.rankinglist.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Latest Games";
            // 
            // listgames
            // 
            this.listgames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listgames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listgames.HideSelection = false;
            this.listgames.Location = new System.Drawing.Point(53, 273);
            this.listgames.Name = "listgames";
            this.listgames.Size = new System.Drawing.Size(634, 97);
            this.listgames.TabIndex = 4;
            this.listgames.UseCompatibleStateImageBehavior = false;
            this.listgames.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Score";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Player";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Second Player";
            // 
            // buttonn
            // 
            this.buttonn.Location = new System.Drawing.Point(502, 210);
            this.buttonn.Name = "buttonn";
            this.buttonn.Size = new System.Drawing.Size(185, 42);
            this.buttonn.TabIndex = 5;
            this.buttonn.Text = "Add New Game";
            this.buttonn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonn);
            this.Controls.Add(this.listgames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rankinglist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ranking);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ranking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView rankinglist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listgames;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonn;
    }
}

