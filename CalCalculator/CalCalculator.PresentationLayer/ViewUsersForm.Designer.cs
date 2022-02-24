
namespace CalCalculator.PresentationLayer
{
    partial class ViewUsersForm
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
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserEnergy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.labelViewProducts.Text = "View users";
            this.labelViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.UserHeight,
            this.UserWeight,
            this.UserGender,
            this.UserAge,
            this.UserEnergy});
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(0, 96);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(932, 324);
            this.listViewUsers.TabIndex = 3;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "Name";
            this.UserName.Width = 83;
            // 
            // UserHeight
            // 
            this.UserHeight.Text = "Height";
            this.UserHeight.Width = 90;
            // 
            // UserWeight
            // 
            this.UserWeight.Text = "Weight";
            this.UserWeight.Width = 90;
            // 
            // UserGender
            // 
            this.UserGender.Text = "Gender";
            this.UserGender.Width = 90;
            // 
            // UserAge
            // 
            this.UserAge.Text = "Age";
            this.UserAge.Width = 75;
            // 
            // UserEnergy
            // 
            this.UserEnergy.Text = "Energy balance";
            this.UserEnergy.Width = 115;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(288, 466);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(534, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.labelViewProducts);
            this.Name = "ViewUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewUsersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelViewProducts;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader UserHeight;
        private System.Windows.Forms.ColumnHeader UserWeight;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader UserGender;
        private System.Windows.Forms.ColumnHeader UserAge;
        private System.Windows.Forms.ColumnHeader UserEnergy;
    }
}