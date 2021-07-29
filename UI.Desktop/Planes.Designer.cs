
namespace UI.Desktop
{
    partial class Planes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planes));
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.btnUpdatePlanes = new System.Windows.Forms.Button();
            this.btnClosePlanes = new System.Windows.Forms.Button();
            this.tsPlanes = new System.Windows.Forms.ToolStrip();
            this.btnAddPlan = new System.Windows.Forms.ToolStripButton();
            this.btnEditEsp = new System.Windows.Forms.ToolStripButton();
            this.btnDeletePlan = new System.Windows.Forms.ToolStripButton();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.tsPlanes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlpEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(941, 528);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(941, 561);
            this.tscEspecialidades.TabIndex = 0;
            this.tscEspecialidades.Text = "toolStripContainer1";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.Controls.Add(this.tsPlanes);
            // 
            // tlpEspecialidades
            // 
            this.tlpEspecialidades.ColumnCount = 2;
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEspecialidades.Controls.Add(this.dgvPlanes, 0, 0);
            this.tlpEspecialidades.Controls.Add(this.btnUpdatePlanes, 0, 1);
            this.tlpEspecialidades.Controls.Add(this.btnClosePlanes, 1, 1);
            this.tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidades.Name = "tlpEspecialidades";
            this.tlpEspecialidades.RowCount = 2;
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidades.Size = new System.Drawing.Size(941, 528);
            this.tlpEspecialidades.TabIndex = 0;
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.AllowUserToAddRows = false;
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.AllowUserToOrderColumns = true;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpEspecialidades.SetColumnSpan(this.dgvPlanes, 2);
            this.dgvPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanes.Location = new System.Drawing.Point(3, 3);
            this.dgvPlanes.MultiSelect = false;
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.RowHeadersWidth = 62;
            this.dgvPlanes.RowTemplate.Height = 28;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(935, 448);
            this.dgvPlanes.TabIndex = 0;
            // 
            // btnUpdatePlanes
            // 
            this.btnUpdatePlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatePlanes.BackgroundImage = global::UI.Desktop.Properties.Resources.updated;
            this.btnUpdatePlanes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePlanes.Font = new System.Drawing.Font("Niagara Engraved", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlanes.Location = new System.Drawing.Point(538, 457);
            this.btnUpdatePlanes.Name = "btnUpdatePlanes";
            this.btnUpdatePlanes.Size = new System.Drawing.Size(183, 68);
            this.btnUpdatePlanes.TabIndex = 1;
            this.btnUpdatePlanes.UseVisualStyleBackColor = true;
            this.btnUpdatePlanes.Click += new System.EventHandler(this.btnUpdatePlanes_Click);
            // 
            // btnClosePlanes
            // 
            this.btnClosePlanes.BackColor = System.Drawing.Color.Red;
            this.btnClosePlanes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClosePlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePlanes.ForeColor = System.Drawing.Color.White;
            this.btnClosePlanes.Location = new System.Drawing.Point(727, 457);
            this.btnClosePlanes.Name = "btnClosePlanes";
            this.btnClosePlanes.Size = new System.Drawing.Size(211, 68);
            this.btnClosePlanes.TabIndex = 2;
            this.btnClosePlanes.Text = "Salir";
            this.btnClosePlanes.UseVisualStyleBackColor = false;
            this.btnClosePlanes.Click += new System.EventHandler(this.btnClosePlanes_Click);
            // 
            // tsPlanes
            // 
            this.tsPlanes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPlanes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsPlanes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPlan,
            this.btnEditEsp,
            this.btnDeletePlan});
            this.tsPlanes.Location = new System.Drawing.Point(6, 0);
            this.tsPlanes.Name = "tsPlanes";
            this.tsPlanes.Size = new System.Drawing.Size(166, 33);
            this.tsPlanes.TabIndex = 0;
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPlan.Image")));
            this.btnAddPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(34, 28);
            this.btnAddPlan.Text = "Agregar Plan";
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // btnEditEsp
            // 
            this.btnEditEsp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditEsp.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEsp.Image")));
            this.btnEditEsp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditEsp.Name = "btnEditEsp";
            this.btnEditEsp.Size = new System.Drawing.Size(34, 28);
            this.btnEditEsp.Text = "editar Especialidad";
            this.btnEditEsp.Click += new System.EventHandler(this.btnEditEsp_Click);
            // 
            // btnDeletePlan
            // 
            this.btnDeletePlan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeletePlan.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePlan.Image")));
            this.btnDeletePlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePlan.Name = "btnDeletePlan";
            this.btnDeletePlan.Size = new System.Drawing.Size(34, 28);
            this.btnDeletePlan.Text = "Borrar Plan";
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 561);
            this.Controls.Add(this.tscEspecialidades);
            this.Name = "Planes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.Planes_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.tsPlanes.ResumeLayout(false);
            this.tsPlanes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.ToolStrip tsPlanes;
        private System.Windows.Forms.ToolStripButton btnAddPlan;
        private System.Windows.Forms.ToolStripButton btnEditEsp;
        private System.Windows.Forms.ToolStripButton btnDeletePlan;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnUpdatePlanes;
        private System.Windows.Forms.Button btnClosePlanes;
    }
}