
namespace Lab8WindowsForms
{
    partial class AddProductForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label manager_idLabel;
            System.Windows.Forms.Label p_descriptionLabel;
            System.Windows.Forms.Label p_nameLabel;
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.p_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.p_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_idComboBox = new System.Windows.Forms.ComboBox();
            categoryLabel = new System.Windows.Forms.Label();
            manager_idLabel = new System.Windows.Forms.Label();
            p_descriptionLabel = new System.Windows.Forms.Label();
            p_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(71, 104);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(148, 101);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(216, 20);
            this.categoryTextBox.TabIndex = 1;
            // 
            // manager_idLabel
            // 
            manager_idLabel.AutoSize = true;
            manager_idLabel.Location = new System.Drawing.Point(71, 130);
            manager_idLabel.Name = "manager_idLabel";
            manager_idLabel.Size = new System.Drawing.Size(63, 13);
            manager_idLabel.TabIndex = 2;
            manager_idLabel.Text = "Manager id:";
            // 
            // p_descriptionLabel
            // 
            p_descriptionLabel.AutoSize = true;
            p_descriptionLabel.Location = new System.Drawing.Point(71, 157);
            p_descriptionLabel.Name = "p_descriptionLabel";
            p_descriptionLabel.Size = new System.Drawing.Size(71, 13);
            p_descriptionLabel.TabIndex = 4;
            p_descriptionLabel.Text = "P description:";
            // 
            // p_descriptionTextBox
            // 
            this.p_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_description", true));
            this.p_descriptionTextBox.Location = new System.Drawing.Point(148, 154);
            this.p_descriptionTextBox.Multiline = true;
            this.p_descriptionTextBox.Name = "p_descriptionTextBox";
            this.p_descriptionTextBox.Size = new System.Drawing.Size(216, 83);
            this.p_descriptionTextBox.TabIndex = 5;
            // 
            // p_nameLabel
            // 
            p_nameLabel.AutoSize = true;
            p_nameLabel.Location = new System.Drawing.Point(71, 78);
            p_nameLabel.Name = "p_nameLabel";
            p_nameLabel.Size = new System.Drawing.Size(46, 13);
            p_nameLabel.TabIndex = 6;
            p_nameLabel.Text = "P name:";
            // 
            // p_nameTextBox
            // 
            this.p_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_name", true));
            this.p_nameTextBox.Location = new System.Drawing.Point(148, 75);
            this.p_nameTextBox.Name = "p_nameTextBox";
            this.p_nameTextBox.Size = new System.Drawing.Size(216, 20);
            this.p_nameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add new product";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(289, 243);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lab8WindowsForms.Product);
            // 
            // manager_idComboBox
            // 
            this.manager_idComboBox.FormattingEnabled = true;
            this.manager_idComboBox.Location = new System.Drawing.Point(148, 128);
            this.manager_idComboBox.Name = "manager_idComboBox";
            this.manager_idComboBox.Size = new System.Drawing.Size(216, 21);
            this.manager_idComboBox.TabIndex = 10;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 307);
            this.Controls.Add(this.manager_idComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(manager_idLabel);
            this.Controls.Add(p_descriptionLabel);
            this.Controls.Add(this.p_descriptionTextBox);
            this.Controls.Add(p_nameLabel);
            this.Controls.Add(this.p_nameTextBox);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product Form";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox p_descriptionTextBox;
        private System.Windows.Forms.TextBox p_nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox manager_idComboBox;
    }
}