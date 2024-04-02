namespace NNPG_2023_Uloha_4_Lukas_Bajer
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.actionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ActionLine = new System.Windows.Forms.Button();
            this.ActionRectangle = new System.Windows.Forms.Button();
            this.ActionEllipse = new System.Windows.Forms.Button();
            this.ActionBrokenLine = new System.Windows.Forms.Button();
            this.ActionDelete = new System.Windows.Forms.Button();
            this.ActionCancel = new System.Windows.Forms.Button();
            this.splitContainerBottom = new System.Windows.Forms.SplitContainer();
            this.Canvas = new System.Windows.Forms.Panel();
            this.splitContainerProperties = new System.Windows.Forms.SplitContainer();
            this.ProperiesPanelEdge = new System.Windows.Forms.GroupBox();
            this.PropertyEdgeStyle = new System.Windows.Forms.ComboBox();
            this.PropertyEdgeWidth = new System.Windows.Forms.NumericUpDown();
            this.PictureBoxEdgeColor = new System.Windows.Forms.PictureBox();
            this.PropertyEdge = new System.Windows.Forms.CheckBox();
            this.PropertiesPanelFill = new System.Windows.Forms.GroupBox();
            this.PictureBoxFillColor = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PropertyHatchStyle = new System.Windows.Forms.ComboBox();
            this.PropertyHatchFill = new System.Windows.Forms.RadioButton();
            this.PropertySolidColorFill = new System.Windows.Forms.RadioButton();
            this.PropertyNoFill = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel1.SuspendLayout();
            this.splitContainerBottom.Panel2.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProperties)).BeginInit();
            this.splitContainerProperties.Panel1.SuspendLayout();
            this.splitContainerProperties.Panel2.SuspendLayout();
            this.splitContainerProperties.SuspendLayout();
            this.ProperiesPanelEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyEdgeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEdgeColor)).BeginInit();
            this.PropertiesPanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFillColor)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            this.splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.actionsPanel);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.splitContainerBottom);
            this.splitContainerTop.Size = new System.Drawing.Size(1119, 721);
            this.splitContainerTop.SplitterDistance = 38;
            this.splitContainerTop.TabIndex = 0;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.ActionLine);
            this.actionsPanel.Controls.Add(this.ActionRectangle);
            this.actionsPanel.Controls.Add(this.ActionEllipse);
            this.actionsPanel.Controls.Add(this.ActionBrokenLine);
            this.actionsPanel.Controls.Add(this.ActionDelete);
            this.actionsPanel.Controls.Add(this.ActionCancel);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsPanel.Location = new System.Drawing.Point(0, 0);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(1119, 38);
            this.actionsPanel.TabIndex = 0;
            // 
            // ActionLine
            // 
            this.ActionLine.Location = new System.Drawing.Point(3, 3);
            this.ActionLine.Name = "ActionLine";
            this.ActionLine.Size = new System.Drawing.Size(75, 23);
            this.ActionLine.TabIndex = 0;
            this.ActionLine.Text = "Line";
            this.ActionLine.UseVisualStyleBackColor = true;
            this.ActionLine.Click += new System.EventHandler(this.ActionLine_Click);
            // 
            // ActionRectangle
            // 
            this.ActionRectangle.Location = new System.Drawing.Point(84, 3);
            this.ActionRectangle.Name = "ActionRectangle";
            this.ActionRectangle.Size = new System.Drawing.Size(75, 23);
            this.ActionRectangle.TabIndex = 1;
            this.ActionRectangle.Text = "Rectangle";
            this.ActionRectangle.UseVisualStyleBackColor = true;
            this.ActionRectangle.Click += new System.EventHandler(this.ActionRectangle_Click);
            // 
            // ActionEllipse
            // 
            this.ActionEllipse.Location = new System.Drawing.Point(165, 3);
            this.ActionEllipse.Name = "ActionEllipse";
            this.ActionEllipse.Size = new System.Drawing.Size(75, 23);
            this.ActionEllipse.TabIndex = 2;
            this.ActionEllipse.Text = "Ellispse";
            this.ActionEllipse.UseVisualStyleBackColor = true;
            this.ActionEllipse.Click += new System.EventHandler(this.ActionEllipse_Click);
            // 
            // ActionBrokenLine
            // 
            this.ActionBrokenLine.Location = new System.Drawing.Point(246, 3);
            this.ActionBrokenLine.Name = "ActionBrokenLine";
            this.ActionBrokenLine.Size = new System.Drawing.Size(75, 23);
            this.ActionBrokenLine.TabIndex = 3;
            this.ActionBrokenLine.Text = "Broken Line";
            this.ActionBrokenLine.UseVisualStyleBackColor = true;
            this.ActionBrokenLine.Click += new System.EventHandler(this.ActionBrokenLine_Click);
            // 
            // ActionDelete
            // 
            this.ActionDelete.Location = new System.Drawing.Point(327, 3);
            this.ActionDelete.Name = "ActionDelete";
            this.ActionDelete.Size = new System.Drawing.Size(75, 23);
            this.ActionDelete.TabIndex = 5;
            this.ActionDelete.Text = "Delete";
            this.ActionDelete.UseVisualStyleBackColor = true;
            this.ActionDelete.Click += new System.EventHandler(this.ActionDelete_Click);
            // 
            // ActionCancel
            // 
            this.ActionCancel.Location = new System.Drawing.Point(408, 3);
            this.ActionCancel.Name = "ActionCancel";
            this.ActionCancel.Size = new System.Drawing.Size(75, 23);
            this.ActionCancel.TabIndex = 4;
            this.ActionCancel.Text = "Cancel";
            this.ActionCancel.UseVisualStyleBackColor = true;
            this.ActionCancel.Click += new System.EventHandler(this.ActionCancel_Click);
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBottom.Name = "splitContainerBottom";
            this.splitContainerBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBottom.Panel1
            // 
            this.splitContainerBottom.Panel1.Controls.Add(this.Canvas);
            // 
            // splitContainerBottom.Panel2
            // 
            this.splitContainerBottom.Panel2.Controls.Add(this.splitContainerProperties);
            this.splitContainerBottom.Size = new System.Drawing.Size(1119, 679);
            this.splitContainerBottom.SplitterDistance = 485;
            this.splitContainerBottom.TabIndex = 0;
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1119, 485);
            this.Canvas.TabIndex = 0;
            // 
            // splitContainerProperties
            // 
            this.splitContainerProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProperties.Location = new System.Drawing.Point(0, 0);
            this.splitContainerProperties.Name = "splitContainerProperties";
            // 
            // splitContainerProperties.Panel1
            // 
            this.splitContainerProperties.Panel1.Controls.Add(this.ProperiesPanelEdge);
            // 
            // splitContainerProperties.Panel2
            // 
            this.splitContainerProperties.Panel2.Controls.Add(this.PropertiesPanelFill);
            this.splitContainerProperties.Size = new System.Drawing.Size(1119, 190);
            this.splitContainerProperties.SplitterDistance = 509;
            this.splitContainerProperties.TabIndex = 0;
            // 
            // ProperiesPanelEdge
            // 
            this.ProperiesPanelEdge.Controls.Add(this.label4);
            this.ProperiesPanelEdge.Controls.Add(this.label2);
            this.ProperiesPanelEdge.Controls.Add(this.label1);
            this.ProperiesPanelEdge.Controls.Add(this.PropertyEdgeStyle);
            this.ProperiesPanelEdge.Controls.Add(this.PropertyEdgeWidth);
            this.ProperiesPanelEdge.Controls.Add(this.PictureBoxEdgeColor);
            this.ProperiesPanelEdge.Controls.Add(this.PropertyEdge);
            this.ProperiesPanelEdge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProperiesPanelEdge.Location = new System.Drawing.Point(0, 0);
            this.ProperiesPanelEdge.Name = "ProperiesPanelEdge";
            this.ProperiesPanelEdge.Size = new System.Drawing.Size(509, 190);
            this.ProperiesPanelEdge.TabIndex = 0;
            this.ProperiesPanelEdge.TabStop = false;
            this.ProperiesPanelEdge.Text = "Okraj";
            // 
            // PropertyEdgeStyle
            // 
            this.PropertyEdgeStyle.FormattingEnabled = true;
            this.PropertyEdgeStyle.Location = new System.Drawing.Point(88, 93);
            this.PropertyEdgeStyle.Name = "PropertyEdgeStyle";
            this.PropertyEdgeStyle.Size = new System.Drawing.Size(121, 21);
            this.PropertyEdgeStyle.TabIndex = 2;
            this.PropertyEdgeStyle.SelectedIndexChanged += new System.EventHandler(this.PropertyEdgeStyle_SelectedIndexChanged);
            // 
            // PropertyEdgeWidth
            // 
            this.PropertyEdgeWidth.AccessibleName = "PropertyEdgeWidth";
            this.PropertyEdgeWidth.Location = new System.Drawing.Point(89, 136);
            this.PropertyEdgeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PropertyEdgeWidth.Name = "PropertyEdgeWidth";
            this.PropertyEdgeWidth.Size = new System.Drawing.Size(120, 20);
            this.PropertyEdgeWidth.TabIndex = 3;
            this.PropertyEdgeWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PropertyEdgeWidth.ValueChanged += new System.EventHandler(this.PropertyEdgeWidth_ValueChanged);
            // 
            // PictureBoxEdgeColor
            // 
            this.PictureBoxEdgeColor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PictureBoxEdgeColor.Location = new System.Drawing.Point(88, 47);
            this.PictureBoxEdgeColor.Name = "PictureBoxEdgeColor";
            this.PictureBoxEdgeColor.Size = new System.Drawing.Size(23, 21);
            this.PictureBoxEdgeColor.TabIndex = 4;
            this.PictureBoxEdgeColor.TabStop = false;
            this.PictureBoxEdgeColor.Click += new System.EventHandler(this.PictureBoxEdgeColor_Click);
            // 
            // PropertyEdge
            // 
            this.PropertyEdge.AutoSize = true;
            this.PropertyEdge.Location = new System.Drawing.Point(12, 19);
            this.PropertyEdge.Name = "PropertyEdge";
            this.PropertyEdge.Size = new System.Drawing.Size(83, 17);
            this.PropertyEdge.TabIndex = 0;
            this.PropertyEdge.Text = "Použít okraj";
            this.PropertyEdge.UseVisualStyleBackColor = true;
            this.PropertyEdge.CheckedChanged += new System.EventHandler(this.PropertyEdge_CheckedChanged);
            // 
            // PropertiesPanelFill
            // 
            this.PropertiesPanelFill.Controls.Add(this.label5);
            this.PropertiesPanelFill.Controls.Add(this.PictureBoxFillColor);
            this.PropertiesPanelFill.Controls.Add(this.label3);
            this.PropertiesPanelFill.Controls.Add(this.PropertyHatchStyle);
            this.PropertiesPanelFill.Controls.Add(this.PropertyHatchFill);
            this.PropertiesPanelFill.Controls.Add(this.PropertySolidColorFill);
            this.PropertiesPanelFill.Controls.Add(this.PropertyNoFill);
            this.PropertiesPanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesPanelFill.Location = new System.Drawing.Point(0, 0);
            this.PropertiesPanelFill.Name = "PropertiesPanelFill";
            this.PropertiesPanelFill.Size = new System.Drawing.Size(606, 190);
            this.PropertiesPanelFill.TabIndex = 0;
            this.PropertiesPanelFill.TabStop = false;
            this.PropertiesPanelFill.Text = "Výplň";
            // 
            // PictureBoxFillColor
            // 
            this.PictureBoxFillColor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PictureBoxFillColor.Location = new System.Drawing.Point(105, 47);
            this.PictureBoxFillColor.Name = "PictureBoxFillColor";
            this.PictureBoxFillColor.Size = new System.Drawing.Size(23, 21);
            this.PictureBoxFillColor.TabIndex = 3;
            this.PictureBoxFillColor.TabStop = false;
            this.PictureBoxFillColor.Click += new System.EventHandler(this.PictureBoxFillColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Styl pozadí:";
            // 
            // PropertyHatchStyle
            // 
            this.PropertyHatchStyle.FormattingEnabled = true;
            this.PropertyHatchStyle.Location = new System.Drawing.Point(105, 88);
            this.PropertyHatchStyle.Name = "PropertyHatchStyle";
            this.PropertyHatchStyle.Size = new System.Drawing.Size(121, 21);
            this.PropertyHatchStyle.TabIndex = 11;
            this.PropertyHatchStyle.SelectedIndexChanged += new System.EventHandler(this.PropertyHatchStyle_SelectedIndexChanged);
            // 
            // PropertyHatchFill
            // 
            this.PropertyHatchFill.AutoSize = true;
            this.PropertyHatchFill.Location = new System.Drawing.Point(229, 19);
            this.PropertyHatchFill.Name = "PropertyHatchFill";
            this.PropertyHatchFill.Size = new System.Drawing.Size(72, 17);
            this.PropertyHatchFill.TabIndex = 2;
            this.PropertyHatchFill.TabStop = true;
            this.PropertyHatchFill.Text = "Šrafování";
            this.PropertyHatchFill.UseVisualStyleBackColor = true;
            this.PropertyHatchFill.CheckedChanged += new System.EventHandler(this.PropertyHatchFill_CheckedChanged);
            // 
            // PropertySolidColorFill
            // 
            this.PropertySolidColorFill.AutoSize = true;
            this.PropertySolidColorFill.Location = new System.Drawing.Point(114, 19);
            this.PropertySolidColorFill.Name = "PropertySolidColorFill";
            this.PropertySolidColorFill.Size = new System.Drawing.Size(97, 17);
            this.PropertySolidColorFill.TabIndex = 1;
            this.PropertySolidColorFill.TabStop = true;
            this.PropertySolidColorFill.Text = "Jednolitá barva";
            this.PropertySolidColorFill.UseVisualStyleBackColor = true;
            this.PropertySolidColorFill.CheckedChanged += new System.EventHandler(this.PropertySolidColorFill_CheckedChanged);
            // 
            // PropertyNoFill
            // 
            this.PropertyNoFill.AutoSize = true;
            this.PropertyNoFill.Location = new System.Drawing.Point(17, 19);
            this.PropertyNoFill.Name = "PropertyNoFill";
            this.PropertyNoFill.Size = new System.Drawing.Size(77, 17);
            this.PropertyNoFill.TabIndex = 0;
            this.PropertyNoFill.TabStop = true;
            this.PropertyNoFill.Text = "Bez výplně";
            this.PropertyNoFill.UseVisualStyleBackColor = true;
            this.PropertyNoFill.CheckedChanged += new System.EventHandler(this.PropertyNoFill_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barva okraje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Styl okraje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Šířka okraje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Barva objektu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 721);
            this.Controls.Add(this.splitContainerTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.splitContainerBottom.Panel1.ResumeLayout(false);
            this.splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            this.splitContainerProperties.Panel1.ResumeLayout(false);
            this.splitContainerProperties.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProperties)).EndInit();
            this.splitContainerProperties.ResumeLayout(false);
            this.ProperiesPanelEdge.ResumeLayout(false);
            this.ProperiesPanelEdge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyEdgeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEdgeColor)).EndInit();
            this.PropertiesPanelFill.ResumeLayout(false);
            this.PropertiesPanelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFillColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.FlowLayoutPanel actionsPanel;
        private System.Windows.Forms.SplitContainer splitContainerBottom;
        private System.Windows.Forms.Button ActionLine;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button ActionRectangle;
        private System.Windows.Forms.Button ActionEllipse;
        private System.Windows.Forms.Button ActionBrokenLine;
        private System.Windows.Forms.Button ActionCancel;
        private System.Windows.Forms.SplitContainer splitContainerProperties;
        private System.Windows.Forms.GroupBox ProperiesPanelEdge;
        private System.Windows.Forms.GroupBox PropertiesPanelFill;
        private System.Windows.Forms.CheckBox PropertyEdge;
        private System.Windows.Forms.RadioButton PropertyNoFill;
        private System.Windows.Forms.RadioButton PropertyHatchFill;
        private System.Windows.Forms.RadioButton PropertySolidColorFill;
        private System.Windows.Forms.Button ActionDelete;
        private System.Windows.Forms.ComboBox PropertyEdgeStyle;
        private System.Windows.Forms.NumericUpDown PropertyEdgeWidth;
        private System.Windows.Forms.PictureBox PictureBoxEdgeColor;
        private System.Windows.Forms.PictureBox PictureBoxFillColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PropertyHatchStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

