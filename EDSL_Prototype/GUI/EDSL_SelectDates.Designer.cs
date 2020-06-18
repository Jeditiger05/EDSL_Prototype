namespace EDSL_Prototype
{
    partial class EDSL_SelectDates
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.lbl_SeasonAdmin = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_RemoveRound = new System.Windows.Forms.Button();
            this.btn_AddRound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(25, 59);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(522, 345);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.grid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.grid.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lbl_SeasonAdmin
            // 
            this.lbl_SeasonAdmin.AutoSize = true;
            this.lbl_SeasonAdmin.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SeasonAdmin.Location = new System.Drawing.Point(150, 9);
            this.lbl_SeasonAdmin.Name = "lbl_SeasonAdmin";
            this.lbl_SeasonAdmin.Size = new System.Drawing.Size(241, 28);
            this.lbl_SeasonAdmin.TabIndex = 15;
            this.lbl_SeasonAdmin.Text = "Select Season Dates";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(421, 455);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(98, 30);
            this.btn_Ok.TabIndex = 16;
            this.btn_Ok.Text = "Finish";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_RemoveRound
            // 
            this.btn_RemoveRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveRound.Location = new System.Drawing.Point(216, 455);
            this.btn_RemoveRound.Name = "btn_RemoveRound";
            this.btn_RemoveRound.Size = new System.Drawing.Size(163, 30);
            this.btn_RemoveRound.TabIndex = 17;
            this.btn_RemoveRound.Text = "Remove Round";
            this.btn_RemoveRound.UseVisualStyleBackColor = true;
            this.btn_RemoveRound.Click += new System.EventHandler(this.btn_RemoveRound_Click);
            // 
            // btn_AddRound
            // 
            this.btn_AddRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRound.Location = new System.Drawing.Point(78, 455);
            this.btn_AddRound.Name = "btn_AddRound";
            this.btn_AddRound.Size = new System.Drawing.Size(98, 30);
            this.btn_AddRound.TabIndex = 18;
            this.btn_AddRound.Text = "Add Round";
            this.btn_AddRound.UseVisualStyleBackColor = true;
            this.btn_AddRound.Click += new System.EventHandler(this.btn_AddRound_Click);
            // 
            // EDSL_SelectDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 497);
            this.Controls.Add(this.btn_AddRound);
            this.Controls.Add(this.btn_RemoveRound);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_SeasonAdmin);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EDSL_SelectDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDSL_SelectDates";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EDSL_SelectDates_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lbl_SeasonAdmin;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_RemoveRound;
        private System.Windows.Forms.Button btn_AddRound;
    }
}