namespace WinFormSubcategories
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbSubcategories = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubcategory = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblSelectionViewer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(152, 45);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(151, 28);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // cmbSubcategories
            // 
            this.cmbSubcategories.FormattingEnabled = true;
            this.cmbSubcategories.Location = new System.Drawing.Point(152, 89);
            this.cmbSubcategories.Name = "cmbSubcategories";
            this.cmbSubcategories.Size = new System.Drawing.Size(151, 28);
            this.cmbSubcategories.TabIndex = 1;
            this.cmbSubcategories.SelectedIndexChanged += new System.EventHandler(this.cmbSubcategories_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(46, 48);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            //this.lblCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.AutoSize = true;
            this.lblSubcategory.Location = new System.Drawing.Point(46, 92);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(92, 20);
            this.lblSubcategory.TabIndex = 3;
            this.lblSubcategory.Text = "Subcategory";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(46, 135);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(70, 20);
            this.lblSelection.TabIndex = 4;
            this.lblSelection.Text = "Selection";
            // 
            // lblSelectionViewer
            // 
            this.lblSelectionViewer.AutoSize = true;
            this.lblSelectionViewer.Location = new System.Drawing.Point(152, 135);
            this.lblSelectionViewer.Name = "lblSelectionViewer";
            this.lblSelectionViewer.Size = new System.Drawing.Size(148, 20);
            this.lblSelectionViewer.TabIndex = 5;
            this.lblSelectionViewer.Text = "Nothing Selected Yet";
            //this.lblSelectionViewer.Click += new System.EventHandler(this.lblSelectionViewer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 199);
            this.Controls.Add(this.lblSelectionViewer);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblSubcategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbSubcategories);
            this.Controls.Add(this.cmbCategories);
            this.MaximumSize = new System.Drawing.Size(382, 246);
            this.MinimumSize = new System.Drawing.Size(382, 246);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbCategories;
        private ComboBox cmbSubcategories;
        private Label lblCategory;
        private Label lblSubcategory;
        private Label lblSelection;
        private Label lblSelectionViewer;
    }
}