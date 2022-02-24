
namespace CalCalculator.PresentationLayer
{
    partial class ViewMealsForm
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
            this.listViewMeals = new System.Windows.Forms.ListView();
            this.MealName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalEnergy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.labelViewProducts.TabIndex = 2;
            this.labelViewProducts.Text = "View meals";
            this.labelViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewMeals
            // 
            this.listViewMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MealName,
            this.TotalEnergy});
            this.listViewMeals.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewMeals.FullRowSelect = true;
            this.listViewMeals.HideSelection = false;
            this.listViewMeals.Location = new System.Drawing.Point(0, 96);
            this.listViewMeals.Name = "listViewMeals";
            this.listViewMeals.Size = new System.Drawing.Size(932, 324);
            this.listViewMeals.TabIndex = 3;
            this.listViewMeals.UseCompatibleStateImageBehavior = false;
            this.listViewMeals.View = System.Windows.Forms.View.Details;
            // 
            // MealName
            // 
            this.MealName.Text = "Meal name";
            this.MealName.Width = 395;
            // 
            // TotalEnergy
            // 
            this.TotalEnergy.Text = "Total Energy";
            this.TotalEnergy.Width = 480;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(270, 468);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit(details)";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(566, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewMealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listViewMeals);
            this.Controls.Add(this.labelViewProducts);
            this.Name = "ViewMealsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMealsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelViewProducts;
        private System.Windows.Forms.ListView listViewMeals;
        private System.Windows.Forms.ColumnHeader MealName;
        private System.Windows.Forms.ColumnHeader TotalEnergy;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}