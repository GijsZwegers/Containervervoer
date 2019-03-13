namespace Containervervoer
{
    partial class ConatainerVervoerForm
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
            this.btStandardLoading = new System.Windows.Forms.Button();
            this.lvContainers = new System.Windows.Forms.ListView();
            this.ContainerType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContainerWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbtotalweight = new System.Windows.Forms.Label();
            this.lbContainerCount = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.nmShipLength = new System.Windows.Forms.NumericUpDown();
            this.nmShipHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbShipCapacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmShipLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmShipHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btStandardLoading
            // 
            this.btStandardLoading.Location = new System.Drawing.Point(624, 8);
            this.btStandardLoading.Margin = new System.Windows.Forms.Padding(2);
            this.btStandardLoading.Name = "btStandardLoading";
            this.btStandardLoading.Size = new System.Drawing.Size(96, 49);
            this.btStandardLoading.TabIndex = 0;
            this.btStandardLoading.Text = "Standaard container lading";
            this.btStandardLoading.UseVisualStyleBackColor = true;
            this.btStandardLoading.Click += new System.EventHandler(this.btStandardLoading_Click);
            // 
            // lvContainers
            // 
            this.lvContainers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvContainers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContainerType,
            this.ContainerWeight});
            this.lvContainers.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvContainers.FullRowSelect = true;
            this.lvContainers.GridLines = true;
            this.lvContainers.Location = new System.Drawing.Point(724, 8);
            this.lvContainers.Margin = new System.Windows.Forms.Padding(2);
            this.lvContainers.Name = "lvContainers";
            this.lvContainers.Size = new System.Drawing.Size(375, 558);
            this.lvContainers.TabIndex = 1;
            this.lvContainers.UseCompatibleStateImageBehavior = false;
            this.lvContainers.View = System.Windows.Forms.View.Details;
            this.lvContainers.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.lvContainers_ControlAdded);
            // 
            // ContainerType
            // 
            this.ContainerType.Tag = "Type";
            this.ContainerType.Text = "Container Type";
            this.ContainerType.Width = 127;
            // 
            // ContainerWeight
            // 
            this.ContainerWeight.Tag = "Weight";
            this.ContainerWeight.Text = "Container Gewicht";
            this.ContainerWeight.Width = 141;
            // 
            // lbtotalweight
            // 
            this.lbtotalweight.AutoSize = true;
            this.lbtotalweight.Location = new System.Drawing.Point(871, 580);
            this.lbtotalweight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtotalweight.Name = "lbtotalweight";
            this.lbtotalweight.Size = new System.Drawing.Size(72, 13);
            this.lbtotalweight.TabIndex = 2;
            this.lbtotalweight.Text = "lb total weight";
            // 
            // lbContainerCount
            // 
            this.lbContainerCount.AutoSize = true;
            this.lbContainerCount.Location = new System.Drawing.Point(721, 580);
            this.lbContainerCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContainerCount.Name = "lbContainerCount";
            this.lbContainerCount.Size = new System.Drawing.Size(92, 13);
            this.lbContainerCount.TabIndex = 3;
            this.lbContainerCount.Text = "lb container count";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(612, 517);
            this.btStart.Margin = new System.Windows.Forms.Padding(2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(96, 49);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Probeer oplossing";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // nmShipLength
            // 
            this.nmShipLength.Location = new System.Drawing.Point(625, 81);
            this.nmShipLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmShipLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmShipLength.Name = "nmShipLength";
            this.nmShipLength.Size = new System.Drawing.Size(95, 20);
            this.nmShipLength.TabIndex = 5;
            this.nmShipLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmShipLength.ValueChanged += new System.EventHandler(this.CorrectShipWeight);
            // 
            // nmShipHeight
            // 
            this.nmShipHeight.Location = new System.Drawing.Point(624, 124);
            this.nmShipHeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmShipHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmShipHeight.Name = "nmShipHeight";
            this.nmShipHeight.Size = new System.Drawing.Size(96, 20);
            this.nmShipHeight.TabIndex = 6;
            this.nmShipHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmShipHeight.ValueChanged += new System.EventHandler(this.CorrectShipWeight);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Schip Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ship Height";
            // 
            // lbShipCapacity
            // 
            this.lbShipCapacity.AutoSize = true;
            this.lbShipCapacity.Location = new System.Drawing.Point(539, 147);
            this.lbShipCapacity.Name = "lbShipCapacity";
            this.lbShipCapacity.Size = new System.Drawing.Size(86, 13);
            this.lbShipCapacity.TabIndex = 9;
            this.lbShipCapacity.Text = "Schip capaciteit:";
            // 
            // ShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 611);
            this.Controls.Add(this.lbShipCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmShipHeight);
            this.Controls.Add(this.nmShipLength);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbContainerCount);
            this.Controls.Add(this.lbtotalweight);
            this.Controls.Add(this.lvContainers);
            this.Controls.Add(this.btStandardLoading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShipForm";
            this.Text = "Containervervoer";
            ((System.ComponentModel.ISupportInitialize)(this.nmShipLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmShipHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStandardLoading;
        private System.Windows.Forms.ListView lvContainers;
        private System.Windows.Forms.ColumnHeader ContainerType;
        private System.Windows.Forms.ColumnHeader ContainerWeight;
        private System.Windows.Forms.Label lbtotalweight;
        private System.Windows.Forms.Label lbContainerCount;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown nmShipLength;
        private System.Windows.Forms.NumericUpDown nmShipHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbShipCapacity;
    }
}

