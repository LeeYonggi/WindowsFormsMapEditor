namespace WindowsFormsMapEditor
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Render = new System.Windows.Forms.Panel();
            this.Control = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MapScaleY = new System.Windows.Forms.TextBox();
            this.MapScaleX = new System.Windows.Forms.TextBox();
            this.MapScale = new System.Windows.Forms.Label();
            this.Tiles_Panel = new System.Windows.Forms.Panel();
            this.SubControl = new System.Windows.Forms.Button();
            this.sizeChange = new System.Windows.Forms.Button();
            this.TileScale = new System.Windows.Forms.Label();
            this.tilesizeY = new System.Windows.Forms.TextBox();
            this.tilesizeX = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCreateNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_Image = new System.Windows.Forms.OpenFileDialog();
            this.MapSizeChange = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_Render.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Tiles_Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.Panel_Render, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1440, 851);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Panel_Render
            // 
            this.Panel_Render.AutoScroll = true;
            this.Panel_Render.Controls.Add(this.Control);
            this.Panel_Render.Location = new System.Drawing.Point(291, 4);
            this.Panel_Render.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_Render.Name = "Panel_Render";
            this.Panel_Render.Size = new System.Drawing.Size(1145, 842);
            this.Panel_Render.TabIndex = 1;
            this.Panel_Render.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Render_Paint);
            this.Panel_Render.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Render_MouseDown);
            // 
            // Control
            // 
            this.Control.Location = new System.Drawing.Point(1050, 2);
            this.Control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(94, 28);
            this.Control.TabIndex = 0;
            this.Control.Text = "Control";
            this.Control.UseVisualStyleBackColor = true;
            this.Control.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MapSizeChange);
            this.panel1.Controls.Add(this.MapScaleY);
            this.panel1.Controls.Add(this.MapScaleX);
            this.panel1.Controls.Add(this.MapScale);
            this.panel1.Controls.Add(this.Tiles_Panel);
            this.panel1.Controls.Add(this.sizeChange);
            this.panel1.Controls.Add(this.TileScale);
            this.panel1.Controls.Add(this.tilesizeY);
            this.panel1.Controls.Add(this.tilesizeX);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 834);
            this.panel1.TabIndex = 1;
            // 
            // MapScaleY
            // 
            this.MapScaleY.AcceptsReturn = true;
            this.MapScaleY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MapScaleY.Location = new System.Drawing.Point(193, 106);
            this.MapScaleY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapScaleY.Name = "MapScaleY";
            this.MapScaleY.Size = new System.Drawing.Size(86, 25);
            this.MapScaleY.TabIndex = 8;
            this.MapScaleY.TextChanged += new System.EventHandler(this.MapScaleY_TextChanged);
            // 
            // MapScaleX
            // 
            this.MapScaleX.AcceptsReturn = true;
            this.MapScaleX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MapScaleX.Location = new System.Drawing.Point(101, 106);
            this.MapScaleX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapScaleX.Name = "MapScaleX";
            this.MapScaleX.Size = new System.Drawing.Size(86, 25);
            this.MapScaleX.TabIndex = 7;
            this.MapScaleX.TextChanged += new System.EventHandler(this.MapScaleX_TextChanged);
            // 
            // MapScale
            // 
            this.MapScale.AutoSize = true;
            this.MapScale.Location = new System.Drawing.Point(12, 106);
            this.MapScale.Name = "MapScale";
            this.MapScale.Size = new System.Drawing.Size(82, 15);
            this.MapScale.TabIndex = 6;
            this.MapScale.Text = "MapScale :";
            // 
            // Tiles_Panel
            // 
            this.Tiles_Panel.Controls.Add(this.SubControl);
            this.Tiles_Panel.Location = new System.Drawing.Point(40, 135);
            this.Tiles_Panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tiles_Panel.Name = "Tiles_Panel";
            this.Tiles_Panel.Size = new System.Drawing.Size(197, 661);
            this.Tiles_Panel.TabIndex = 5;
            this.Tiles_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tiles_Panel_MouseDown);
            // 
            // SubControl
            // 
            this.SubControl.Location = new System.Drawing.Point(94, 2);
            this.SubControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubControl.Name = "SubControl";
            this.SubControl.Size = new System.Drawing.Size(102, 24);
            this.SubControl.TabIndex = 0;
            this.SubControl.Text = "SubControl";
            this.SubControl.UseVisualStyleBackColor = true;
            this.SubControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubControl_KeyPress);
            // 
            // sizeChange
            // 
            this.sizeChange.Location = new System.Drawing.Point(40, 60);
            this.sizeChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeChange.Name = "sizeChange";
            this.sizeChange.Size = new System.Drawing.Size(101, 29);
            this.sizeChange.TabIndex = 4;
            this.sizeChange.Text = "sizeChange";
            this.sizeChange.UseVisualStyleBackColor = true;
            this.sizeChange.Click += new System.EventHandler(this.sizeChange_Click);
            // 
            // TileScale
            // 
            this.TileScale.AutoSize = true;
            this.TileScale.Location = new System.Drawing.Point(18, 35);
            this.TileScale.Name = "TileScale";
            this.TileScale.Size = new System.Drawing.Size(76, 15);
            this.TileScale.TabIndex = 3;
            this.TileScale.Text = "TileScale :";
            // 
            // tilesizeY
            // 
            this.tilesizeY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tilesizeY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tilesizeY.Location = new System.Drawing.Point(193, 31);
            this.tilesizeY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tilesizeY.Name = "tilesizeY";
            this.tilesizeY.Size = new System.Drawing.Size(86, 25);
            this.tilesizeY.TabIndex = 3;
            this.tilesizeY.TextChanged += new System.EventHandler(this.tilesizeY_TextChanged);
            // 
            // tilesizeX
            // 
            this.tilesizeX.AcceptsReturn = true;
            this.tilesizeX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tilesizeX.Location = new System.Drawing.Point(101, 31);
            this.tilesizeX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tilesizeX.Name = "tilesizeX";
            this.tilesizeX.Size = new System.Drawing.Size(86, 25);
            this.tilesizeX.TabIndex = 2;
            this.tilesizeX.TextChanged += new System.EventHandler(this.tilesizeX_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.imageIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCreateNToolStripMenuItem,
            this.openOToolStripMenuItem,
            this.saveSToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileFToolStripMenuItem.Text = "File (F)";
            // 
            // newCreateNToolStripMenuItem
            // 
            this.newCreateNToolStripMenuItem.Name = "newCreateNToolStripMenuItem";
            this.newCreateNToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.newCreateNToolStripMenuItem.Text = "New Create (N)";
            this.newCreateNToolStripMenuItem.Click += new System.EventHandler(this.newCreateNToolStripMenuItem_Click);
            // 
            // openOToolStripMenuItem
            // 
            this.openOToolStripMenuItem.Name = "openOToolStripMenuItem";
            this.openOToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.openOToolStripMenuItem.Text = "Open (O)";
            this.openOToolStripMenuItem.Click += new System.EventHandler(this.openOToolStripMenuItem_Click);
            // 
            // saveSToolStripMenuItem
            // 
            this.saveSToolStripMenuItem.Name = "saveSToolStripMenuItem";
            this.saveSToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.saveSToolStripMenuItem.Text = "Save (S)";
            this.saveSToolStripMenuItem.Click += new System.EventHandler(this.saveSToolStripMenuItem_Click);
            // 
            // imageIToolStripMenuItem
            // 
            this.imageIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOToolStripMenuItem1,
            this.autoCutAToolStripMenuItem});
            this.imageIToolStripMenuItem.Name = "imageIToolStripMenuItem";
            this.imageIToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.imageIToolStripMenuItem.Text = "Image (I)";
            // 
            // openOToolStripMenuItem1
            // 
            this.openOToolStripMenuItem1.Name = "openOToolStripMenuItem1";
            this.openOToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.openOToolStripMenuItem1.Text = "Open (O)";
            this.openOToolStripMenuItem1.Click += new System.EventHandler(this.openOToolStripMenuItem1_Click);
            // 
            // autoCutAToolStripMenuItem
            // 
            this.autoCutAToolStripMenuItem.Name = "autoCutAToolStripMenuItem";
            this.autoCutAToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.autoCutAToolStripMenuItem.Text = "AutoCut (A)";
            // 
            // openFileDialog_Image
            // 
            this.openFileDialog_Image.FileName = "openFileDialog_Image";
            this.openFileDialog_Image.Filter = "이미지 파일|*.jpg;*.png;*.gif;*.bmp|모든 파일|*.*";
            // 
            // MapSizeChange
            // 
            this.MapSizeChange.Location = new System.Drawing.Point(147, 60);
            this.MapSizeChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapSizeChange.Name = "MapSizeChange";
            this.MapSizeChange.Size = new System.Drawing.Size(131, 29);
            this.MapSizeChange.TabIndex = 9;
            this.MapSizeChange.Text = "MapSizeChange";
            this.MapSizeChange.UseVisualStyleBackColor = true;
            this.MapSizeChange.Click += new System.EventHandler(this.MapSizeChange_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 851);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_Render.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tiles_Panel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Panel_Render;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Image;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCreateNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoCutAToolStripMenuItem;
        private System.Windows.Forms.TextBox tilesizeX;
        private System.Windows.Forms.Label TileScale;
        private System.Windows.Forms.TextBox tilesizeY;
        private System.Windows.Forms.Button sizeChange;
        private System.Windows.Forms.Button Control;
        private System.Windows.Forms.Panel Tiles_Panel;
        private System.Windows.Forms.Button SubControl;
        private System.Windows.Forms.Label MapScale;
        private System.Windows.Forms.TextBox MapScaleY;
        private System.Windows.Forms.TextBox MapScaleX;
        private System.Windows.Forms.Button MapSizeChange;
    }
}