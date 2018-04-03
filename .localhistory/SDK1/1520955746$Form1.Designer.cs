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
            this.tBxRow = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBxColumn = new System.Windows.Forms.Label();
            this.dgvSudok = new System.Windows.Forms.DataGridView();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudok)).BeginInit();
            this.SuspendLayout();
            // 
            // tBxRow
            // 
            this.tBxRow.Location = new System.Drawing.Point(74, 13);
            this.tBxRow.Name = "tBxRow";
            this.tBxRow.Size = new System.Drawing.Size(100, 20);
            this.tBxRow.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rows";
            // 
            // tBxColumn
            // 
            this.tBxColumn.AutoSize = true;
            this.tBxColumn.Location = new System.Drawing.Point(209, 19);
            this.tBxColumn.Name = "tBxColumn";
            this.tBxColumn.Size = new System.Drawing.Size(47, 13);
            this.tBxColumn.TabIndex = 1;
            this.tBxColumn.Text = "Columns";
            // 
            // dgvSudok
            // 
            this.dgvSudok.AllowUserToAddRows = false;
            this.dgvSudok.AllowUserToDeleteRows = false;
            this.dgvSudok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudok.ColumnHeadersVisible = false;
            this.dgvSudok.Location = new System.Drawing.Point(13, 39);
            this.dgvSudok.Name = "dgvSudok";
            this.dgvSudok.RowHeadersVisible = false;
            this.dgvSudok.Size = new System.Drawing.Size(775, 399);
            this.dgvSudok.TabIndex = 2;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(380, 10);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(713, 9);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.dgvSudok);
            this.Controls.Add(this.tBxColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tBxRow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBxRow;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tBxColumn;
        private System.Windows.Forms.DataGridView dgvSudok;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnSolve;
    }
}

