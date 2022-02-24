
namespace CalCalculator.PresentationLayer
{
    partial class ViewEnergyExchangesForm
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
            this.listViewEnergyExchange = new System.Windows.Forms.ListView();
            this.EnergyTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnergyFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnergyTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnergyAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
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
            this.labelViewProducts.Text = "View energy exchanges";
            this.labelViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewEnergyExchange
            // 
            this.listViewEnergyExchange.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnergyTime,
            this.EnergyFrom,
            this.EnergyTo,
            this.EnergyAmount});
            this.listViewEnergyExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewEnergyExchange.FullRowSelect = true;
            this.listViewEnergyExchange.HideSelection = false;
            this.listViewEnergyExchange.Location = new System.Drawing.Point(0, 96);
            this.listViewEnergyExchange.Name = "listViewEnergyExchange";
            this.listViewEnergyExchange.Size = new System.Drawing.Size(932, 324);
            this.listViewEnergyExchange.TabIndex = 4;
            this.listViewEnergyExchange.UseCompatibleStateImageBehavior = false;
            this.listViewEnergyExchange.View = System.Windows.Forms.View.Details;
            // 
            // EnergyTime
            // 
            this.EnergyTime.Text = "Date";
            this.EnergyTime.Width = 166;
            // 
            // EnergyFrom
            // 
            this.EnergyFrom.Text = "Energy from";
            this.EnergyFrom.Width = 254;
            // 
            // EnergyTo
            // 
            this.EnergyTo.Text = "Energy to";
            this.EnergyTo.Width = 206;
            // 
            // EnergyAmount
            // 
            this.EnergyAmount.Text = "Energy amount";
            this.EnergyAmount.Width = 208;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(412, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewEnergyExchangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listViewEnergyExchange);
            this.Controls.Add(this.labelViewProducts);
            this.Name = "ViewEnergyExchangesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEnergyExchangesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelViewProducts;
        private System.Windows.Forms.ListView listViewEnergyExchange;
        private System.Windows.Forms.ColumnHeader EnergyTime;
        private System.Windows.Forms.ColumnHeader EnergyFrom;
        private System.Windows.Forms.ColumnHeader EnergyTo;
        private System.Windows.Forms.ColumnHeader EnergyAmount;
        private System.Windows.Forms.Button btnClose;
    }
}