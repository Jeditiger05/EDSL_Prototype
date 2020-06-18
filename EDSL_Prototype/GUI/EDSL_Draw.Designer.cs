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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Draw)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Draw
            // 
            this.grid_Draw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Draw.Location = new System.Drawing.Point(51, 102);
            this.grid_Draw.Name = "grid_Draw";
            this.grid_Draw.Size = new System.Drawing.Size(1002, 472);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "A Division";
            // 
            // EDSL_Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 606);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}