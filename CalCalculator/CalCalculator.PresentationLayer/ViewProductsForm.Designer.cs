
namespace CalCalculator.PresentationLayer
{
    partial class ViewProductsForm
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
            this.labelViewProducts = new System.Windows.Forms.Label();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.PType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PEnergyOn100 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelViewProducts
            // 
            this.labelViewProducts.BackColor = System.Drawing.Color.Black;
            this.labelViewProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelViewProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.labelViewProducts.Location = new System.Drawing.Point(0, 0);
            this.labelViewProducts.Name = "labelViewProducts";
            this.labelViewProducts.Size = new System.Drawing.Size(932, 96);
            this.labelViewProducts.TabIndex = 1;
            this.labelViewProducts.Text = "View Products";
            this.labelViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PType,
            this.PName,
            this.PEnergyOn100});
            this.listViewProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(0, 96);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(932, 324);
            this.listViewProducts.TabIndex = 2;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // PType
            // 
            this.PType.Text = "Type";
            this.PType.Width = 198;
            // 
            // PName
            // 
            this.PName.Text = "Name";
            this.PName.Width = 309;
            // 
            // PEnergyOn100
            // 
            this.PEnergyOn100.Text = "EnergyOn100";
            this.PEnergyOn100.Width = 240;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(300, 471);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(555, 471);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.labelViewProducts);
            this.Name = "ViewProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProductsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelViewProducts;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader PType;
        private System.Windows.Forms.ColumnHeader PName;
        private System.Windows.Forms.ColumnHeader PEnergyOn100;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}