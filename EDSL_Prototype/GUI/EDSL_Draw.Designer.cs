namespace EDSL_Prototype.GUI
{
    partial class EDSL_Draw
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
            this.grid_Draw = new System.Windows.Forms.DataGridView();
            this.lbl_SeasonAdmin = new System.Windows.Forms.Label();
            this.lbl_Division = new System.Windows.Forms.Label();
            this.btn_Rounds = new System.Windows.Forms.Button();
            this.btn_Fixtures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Draw)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Draw
            // 
            this.grid_Draw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Draw.Location = new System.Drawing.Point(51, 135);
            this.grid_Draw.Name = "grid_Draw";
            this.grid_Draw.Size = new System.Drawing.Size(1002, 439);
            this.grid_Draw.TabIndex = 0;
            // 
            // lbl_SeasonAdmin
            // 
            this.lbl_SeasonAdmin.AutoSize = true;
            this.lbl_SeasonAdmin.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SeasonAdmin.Location = new System.Drawing.Point(516, 38);
            this.lbl_SeasonAdmin.Name = "lbl_SeasonAdmin";
            this.lbl_SeasonAdmin.Size = new System.Drawing.Size(160, 28);
            this.lbl_SeasonAdmin.TabIndex = 15;
            this.lbl_SeasonAdmin.Text = "Season Draw";
            // 
            // lbl_Division
            // 
            this.lbl_Division.AutoSize = true;
            this.lbl_Division.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Division.Location = new System.Drawing.Point(385, 38);
            this.lbl_Division.Name = "lbl_Division";
            this.lbl_Division.Size = new System.Drawing.Size(75, 28);
            this.lbl_Division.TabIndex = 16;
            this.lbl_Division.Text = "         ";
            // 
            // btn_Rounds
            // 
            this.btn_Rounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rounds.Location = new System.Drawing.Point(603, 86);
            this.btn_Rounds.Name = "btn_Rounds";
            this.btn_Rounds.Size = new System.Drawing.Size(134, 30);
            this.btn_Rounds.TabIndex = 17;
            this.btn_Rounds.Text = "View Rounds";
            this.btn_Rounds.UseVisualStyleBackColor = true;
            this.btn_Rounds.Click += new System.EventHandler(this.btn_Rounds_Click);
            // 
            // btn_Fixtures
            // 
            this.btn_Fixtures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fixtures.Location = new System.Drawing.Point(330, 86);
            this.btn_Fixtures.Name = "btn_Fixtures";
            this.btn_Fixtures.Size = new System.Drawing.Size(134, 30);
            this.btn_Fixtures.TabIndex = 18;
            this.btn_Fixtures.Text = "View Fixtures";
            this.btn_Fixtures.UseVisualStyleBackColor = true;
            this.btn_Fixtures.Click += new System.EventHandler(this.btn_Fixtures_Click);
            // 
            // EDSL_Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 606);
            this.Controls.Add(this.btn_Fixtures);
            this.Controls.Add(this.btn_Rounds);
            this.Controls.Add(this.lbl_Division);
            this.Controls.Add(this.lbl_SeasonAdmin);
            this.Controls.Add(this.grid_Draw);
            this.Name = "EDSL_Draw";
            this.Text = "EDSL_Draw";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Draw;
        private System.Windows.Forms.Label lbl_SeasonAdmin;
        private System.Windows.Forms.Label lbl_Division;
        private System.Windows.Forms.Button btn_Rounds;
        private System.Windows.Forms.Button btn_Fixtures;
    }
}