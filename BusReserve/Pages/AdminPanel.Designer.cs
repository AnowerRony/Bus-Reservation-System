namespace BusReserve.Pages
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.menuSlideButton = new System.Windows.Forms.Button();
            this.fixedPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slidingPanel = new System.Windows.Forms.Panel();
            this.viewAllBusButton = new System.Windows.Forms.Button();
            this.viewCustomerButton = new System.Windows.Forms.Button();
            this.bookingDetailsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fixedPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.slidingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSlideButton
            // 
            this.menuSlideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuSlideButton.BackgroundImage")));
            this.menuSlideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuSlideButton.FlatAppearance.BorderSize = 0;
            this.menuSlideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSlideButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSlideButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(4)))));
            this.menuSlideButton.Location = new System.Drawing.Point(0, 0);
            this.menuSlideButton.Name = "menuSlideButton";
            this.menuSlideButton.Size = new System.Drawing.Size(45, 37);
            this.menuSlideButton.TabIndex = 2;
            this.menuSlideButton.Text = "\r\n";
            this.menuSlideButton.UseVisualStyleBackColor = true;
            this.menuSlideButton.Click += new System.EventHandler(this.menuSlideButton_Click);
            // 
            // fixedPanel
            // 
            this.fixedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.fixedPanel.Controls.Add(this.menuSlideButton);
            this.fixedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fixedPanel.Location = new System.Drawing.Point(0, 0);
            this.fixedPanel.Name = "fixedPanel";
            this.fixedPanel.Size = new System.Drawing.Size(45, 533);
            this.fixedPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(45, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 47);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus Reservation";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slidingPanel
            // 
            this.slidingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.slidingPanel.Controls.Add(this.bookingDetailsButton);
            this.slidingPanel.Controls.Add(this.viewCustomerButton);
            this.slidingPanel.Controls.Add(this.viewAllBusButton);
            this.slidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingPanel.Location = new System.Drawing.Point(45, 47);
            this.slidingPanel.Name = "slidingPanel";
            this.slidingPanel.Size = new System.Drawing.Size(200, 486);
            this.slidingPanel.TabIndex = 4;
            // 
            // viewAllBusButton
            // 
            this.viewAllBusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(4)))));
            this.viewAllBusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllBusButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBusButton.Location = new System.Drawing.Point(19, 84);
            this.viewAllBusButton.Name = "viewAllBusButton";
            this.viewAllBusButton.Size = new System.Drawing.Size(156, 24);
            this.viewAllBusButton.TabIndex = 5;
            this.viewAllBusButton.Text = "View All Bus";
            this.viewAllBusButton.UseVisualStyleBackColor = false;
            // 
            // viewCustomerButton
            // 
            this.viewCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(4)))));
            this.viewCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCustomerButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomerButton.Location = new System.Drawing.Point(19, 138);
            this.viewCustomerButton.Name = "viewCustomerButton";
            this.viewCustomerButton.Size = new System.Drawing.Size(156, 24);
            this.viewCustomerButton.TabIndex = 5;
            this.viewCustomerButton.Text = "View Customer";
            this.viewCustomerButton.UseVisualStyleBackColor = false;
            // 
            // bookingDetailsButton
            // 
            this.bookingDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(4)))));
            this.bookingDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingDetailsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingDetailsButton.Location = new System.Drawing.Point(19, 184);
            this.bookingDetailsButton.Name = "bookingDetailsButton";
            this.bookingDetailsButton.Size = new System.Drawing.Size(156, 24);
            this.bookingDetailsButton.TabIndex = 5;
            this.bookingDetailsButton.Text = "Booking Details";
            this.bookingDetailsButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 244);
            this.dataGridView1.TabIndex = 5;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.slidingPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fixedPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.fixedPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.slidingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button menuSlideButton;
        private System.Windows.Forms.Panel fixedPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel slidingPanel;
        private System.Windows.Forms.Button bookingDetailsButton;
        private System.Windows.Forms.Button viewCustomerButton;
        private System.Windows.Forms.Button viewAllBusButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}