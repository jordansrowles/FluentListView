namespace FluentListView.Examples.Forms
{
    partial class BasicFluentListViewForm
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
            this.cListView = new Fluent.FluentListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cListView
            // 
            this.cListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cListView.ColumnWidth = 0;
            this.cListView.EnableCellEditing = false;
            this.cListView.EnableDragDropItems = false;
            this.cListView.EnableDrop = false;
            this.cListView.EnableDropFiles = false;
            this.cListView.EnableGifs = false;
            this.cListView.EnableRenaming = false;
            this.cListView.EnableTileView = false;
            this.cListView.ItemFont = null;
            this.cListView.Location = new System.Drawing.Point(75, 36);
            this.cListView.Name = "cListView";
            this.cListView.ShowColumns = false;
            this.cListView.ShowDescription = false;
            this.cListView.ShowGroups = false;
            this.cListView.ShowIcons = false;
            this.cListView.Size = new System.Drawing.Size(421, 705);
            this.cListView.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1MinSize = 15;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cListView);
            this.splitContainer1.Size = new System.Drawing.Size(841, 844);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 844);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // BasicFluentListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 844);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BasicFluentListViewForm";
            this.ShowIcon = false;
            this.Text = "Basic Fluent ListView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Fluent.FluentListView cListView;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
    }
}