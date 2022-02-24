﻿
namespace CalCalculator.PresentationLayer
{
    partial class ViewWorkoutsForm
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
            this.listViewWorkouts = new System.Windows.Forms.ListView();
            this.WorkoutName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkoutEnergy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.labelViewProducts.TabIndex = 3;
            this.labelViewProducts.Text = "View workouts";
            this.labelViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewWorkouts
            // 
            this.listViewWorkouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WorkoutName,
            this.WorkoutEnergy});
            this.listViewWorkouts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewWorkouts.FullRowSelect = true;
            this.listViewWorkouts.HideSelection = false;
            this.listViewWorkouts.Location = new System.Drawing.Point(0, 96);
            this.listViewWorkouts.Name = "listViewWorkouts";
            this.listViewWorkouts.Size = new System.Drawing.Size(932, 324);
            this.listViewWorkouts.TabIndex = 4;
            this.listViewWorkouts.UseCompatibleStateImageBehavior = false;
            this.listViewWorkouts.View = System.Windows.Forms.View.Details;
            // 
            // WorkoutName
            // 
            this.WorkoutName.Text = "Name";
            this.WorkoutName.Width = 422;
            // 
            // WorkoutEnergy
            // 
            this.WorkoutEnergy.Text = "Energy for workout";
            this.WorkoutEnergy.Width = 393;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(552, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(286, 460);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ViewWorkoutsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listViewWorkouts);
            this.Controls.Add(this.labelViewProducts);
            this.Name = "ViewWorkoutsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewWorkoutsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelViewProducts;
        private System.Windows.Forms.ListView listViewWorkouts;
        private System.Windows.Forms.ColumnHeader WorkoutName;
        private System.Windows.Forms.ColumnHeader WorkoutEnergy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}