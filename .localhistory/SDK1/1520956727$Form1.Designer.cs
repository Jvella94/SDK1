namespace SDK1
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
            this.dgvSudok = new System.Windows.Forms.DataGridView();
            this.btnSolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSudok
            // 
            this.dgvSudok.AllowUserToAddRows = false;
            this.dgvSudok.AllowUserToDeleteRows = false;
            this.dgvSudok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudok.ColumnHeadersVisible = false;
            this.dgvSudok.Location = new System.Drawing.Point(13, 39);
            this.dgvSudok.Name = "dgvSudok";
            this.dgvSudok.ReadOnly = true;
            this.dgvSudok.RowHeadersVisible = false;
            this.dgvSudok.Size = new System.Drawing.Size(500, 500);
            this.dgvSudok.TabIndex = 2;
            this.dgvSudok.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSudok_Paint);
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolve.Location = new System.Drawing.Point(436, 10);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(77, 23);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 546);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.dgvSudok);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSudok;
        private System.Windows.Forms.Button btnSolve;
    }
}

