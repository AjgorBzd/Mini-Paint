
namespace Paint2
{
    partial class MiniPaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniPaint));
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Load = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Brush = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.Thiccness = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.Chosen_color = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Language = new System.Windows.Forms.ToolStripLabel();
            this.English = new System.Windows.Forms.ToolStripButton();
            this.Polish = new System.Windows.Forms.ToolStripButton();
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            this.Colors = new System.Windows.Forms.GroupBox();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.Tools.SuspendLayout();
            this.Panel.SuspendLayout();
            this.Colors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.Tools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.Save,
            this.Load,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.Brush,
            this.Rectangle,
            this.Ellipse,
            this.Clear,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.Thiccness,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.Chosen_color,
            this.toolStripSeparator4,
            this.Language,
            this.English,
            this.Polish});
            resources.ApplyResources(this.Tools, "Tools");
            this.Tools.Name = "Tools";
            this.Tools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Tools_ItemClicked);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Load, "Load");
            this.Load.Name = "Load";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // Brush
            // 
            this.Brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Brush, "Brush");
            this.Brush.Name = "Brush";
            this.Brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Rectangle, "Rectangle");
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Ellipse, "Ellipse");
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Clear
            // 
            this.Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.Name = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            // 
            // Thiccness
            // 
            this.Thiccness.Items.AddRange(new object[] {
            resources.GetString("Thiccness.Items"),
            resources.GetString("Thiccness.Items1"),
            resources.GetString("Thiccness.Items2")});
            this.Thiccness.Name = "Thiccness";
            resources.ApplyResources(this.Thiccness, "Thiccness");
            this.Thiccness.SelectedIndexChanged += new System.EventHandler(this.Thiccness_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            resources.ApplyResources(this.toolStripLabel4, "toolStripLabel4");
            // 
            // Chosen_color
            // 
            this.Chosen_color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Chosen_color, "Chosen_color");
            this.Chosen_color.Name = "Chosen_color";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // Language
            // 
            this.Language.Name = "Language";
            resources.ApplyResources(this.Language, "Language");
            // 
            // English
            // 
            this.English.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.English, "English");
            this.English.Name = "English";
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // Polish
            // 
            this.Polish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Polish, "Polish");
            this.Polish.Name = "Polish";
            this.Polish.Click += new System.EventHandler(this.Polish_Click);
            // 
            // Panel
            // 
            resources.ApplyResources(this.Panel, "Panel");
            this.Panel.Controls.Add(this.Colors, 1, 0);
            this.Panel.Controls.Add(this.Canvas, 0, 0);
            this.Panel.Name = "Panel";
            // 
            // Colors
            // 
            this.Colors.Controls.Add(this.FlowPanel);
            resources.ApplyResources(this.Colors, "Colors");
            this.Colors.Name = "Colors";
            this.Colors.TabStop = false;
            // 
            // FlowPanel
            // 
            resources.ApplyResources(this.FlowPanel, "FlowPanel");
            this.FlowPanel.Name = "FlowPanel";
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.Canvas, "Canvas");
            this.Canvas.Name = "Canvas";
            this.Canvas.TabStop = false;
            this.Canvas.SizeChanged += new System.EventHandler(this.Canvas_SizeChanged);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // MiniPaint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Tools);
            this.Name = "MiniPaint";
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Colors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.GroupBox Colors;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton Brush;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Load;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.ToolStripButton Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox Thiccness;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton Chosen_color;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel Language;
        private System.Windows.Forms.ToolStripButton English;
        private System.Windows.Forms.ToolStripButton Polish;
    }
}

