namespace SDK1
{
    partial class SDKSolver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSudok = new System.Windows.Forms.DataGridView();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnSolveEasy = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSudok
            // 
            this.dgvSudok.AllowUserToAddRows = false;
            this.dgvSudok.AllowUserToDeleteRows = false;
            this.dgvSudok.AllowUserToResizeColumns = false;
            this.dgvSudok.AllowUserToResizeRows = false;
            this.dgvSudok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudok.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSudok.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSudok.Location = new System.Drawing.Point(13, 39);
            this.dgvSudok.Name = "dgvSudok";
            this.dgvSudok.RowHeadersVisible = false;
            this.dgvSudok.Size = new System.Drawing.Size(500, 500);
            this.dgvSudok.TabIndex = 2;
            this.dgvSudok.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSudok_CellValueChanged);
            this.dgvSudok.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvSudok_EditingControlShowing);
            this.dgvSudok.Paint += new System.Windows.Forms.PaintEventHandler(this.DgvSudok_Paint);
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolve.Location = new System.Drawing.Point(436, 10);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(77, 23);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Solve Evil";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolveEvil_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(13, 20);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(51, 13);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "Progress:";
            // 
            // btnSolveEasy
            // 
            this.btnSolveEasy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolveEasy.Location = new System.Drawing.Point(353, 10);
            this.btnSolveEasy.Name = "btnSolveEasy";
            this.btnSolveEasy.Size = new System.Drawing.Size(77, 23);
            this.btnSolveEasy.TabIndex = 3;
            this.btnSolveEasy.Text = "Solve Easy";
            this.btnSolveEasy.UseVisualStyleBackColor = true;
            this.btnSolveEasy.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(270, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(163, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 23);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Test";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SDKSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 546);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSolveEasy);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.dgvSudok);
            this.Name = "SDKSolver";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSudok;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnSolveEasy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

