namespace PdfSharpLivePreview
{
    partial class FormPdfSharLivePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPdfSharLivePreview));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.preview = new PdfSharp.Forms.PagePreview();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsddbLoadExample = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tssbSave = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRender = new System.Windows.Forms.ToolStripButton();
            this.tsbAutorender = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiAutorenderInterval = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoIntervalSec1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoIntervalSec2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoIntervalSec3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoIntervalSec4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoIntervalSec5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tAutoRender = new System.Windows.Forms.Timer(this.components);
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.preview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(992, 571);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 0;
            // 
            // preview
            // 
            this.preview.DesktopColor = System.Drawing.SystemColors.ControlDark;
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Location = new System.Drawing.Point(0, 0);
            this.preview.Name = "preview";
            this.preview.PageColor = System.Drawing.Color.GhostWhite;
            this.preview.PageSize = ((PdfSharp.Drawing.XSize)(resources.GetObject("preview.PageSize")));
            this.preview.PageSizeF = new System.Drawing.Size(595, 842);
            this.preview.ShowScrollbars = false;
            this.preview.Size = new System.Drawing.Size(380, 571);
            this.preview.TabIndex = 0;
            this.preview.ZoomPercent = 46;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.editor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(608, 571);
            this.splitContainer2.SplitterDistance = 500;
            this.splitContainer2.TabIndex = 1;
            // 
            // editor
            // 
            this.editor.AutoScrollMinSize = new System.Drawing.Size(35, 15);
            this.editor.BackBrush = null;
            this.editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Language = FastColoredTextBoxNS.Language.CSharp;
            this.editor.LeftPadding = 10;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Name = "editor";
            this.editor.Paddings = new System.Windows.Forms.Padding(0);
            this.editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editor.Size = new System.Drawing.Size(608, 500);
            this.editor.TabIndex = 0;
            this.editor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.editor_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(608, 67);
            this.textBox1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbLoadExample,
            this.tsbOpen,
            this.tssbSave,
            this.toolStripSeparator1,
            this.tsbRender,
            this.tsbAutorender,
            this.toolStripSeparator2,
            this.tsddbSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsddbLoadExample
            // 
            this.tsddbLoadExample.Image = ((System.Drawing.Image)(resources.GetObject("tsddbLoadExample.Image")));
            this.tsddbLoadExample.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbLoadExample.Name = "tsddbLoadExample";
            this.tsddbLoadExample.Size = new System.Drawing.Size(109, 22);
            this.tsddbLoadExample.Text = "Load Example";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 22);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tssbSave
            // 
            this.tssbSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveAs});
            this.tssbSave.Image = ((System.Drawing.Image)(resources.GetObject("tssbSave.Image")));
            this.tssbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbSave.Name = "tssbSave";
            this.tssbSave.Size = new System.Drawing.Size(63, 22);
            this.tssbSave.Text = "Save";
            this.tssbSave.ButtonClick += new System.EventHandler(this.tssbSave_ButtonClick);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Image = global::PdfSharpLivePreview.Properties.Resources.save_as_25px;
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(152, 22);
            this.tsmiSaveAs.Text = "Save as..";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRender
            // 
            this.tsbRender.Image = ((System.Drawing.Image)(resources.GetObject("tsbRender.Image")));
            this.tsbRender.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRender.Name = "tsbRender";
            this.tsbRender.Size = new System.Drawing.Size(64, 22);
            this.tsbRender.Text = "Render";
            this.tsbRender.Click += new System.EventHandler(this.tsbRender_Click);
            // 
            // tsbAutorender
            // 
            this.tsbAutorender.Checked = true;
            this.tsbAutorender.CheckOnClick = true;
            this.tsbAutorender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbAutorender.Image = ((System.Drawing.Image)(resources.GetObject("tsbAutorender.Image")));
            this.tsbAutorender.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAutorender.Name = "tsbAutorender";
            this.tsbAutorender.Size = new System.Drawing.Size(87, 22);
            this.tsbAutorender.Text = "Autorender";
            this.tsbAutorender.Click += new System.EventHandler(this.tsbAutorender_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbSettings
            // 
            this.tsddbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutorenderInterval,
            this.toolStripMenuItem2,
            this.tsmiAbout});
            this.tsddbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsddbSettings.Image")));
            this.tsddbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbSettings.Name = "tsddbSettings";
            this.tsddbSettings.Size = new System.Drawing.Size(78, 22);
            this.tsddbSettings.Text = "Settings";
            // 
            // tsmiAutorenderInterval
            // 
            this.tsmiAutorenderInterval.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutoIntervalSec1,
            this.tsmiAutoIntervalSec2,
            this.tsmiAutoIntervalSec3,
            this.tsmiAutoIntervalSec4,
            this.tsmiAutoIntervalSec5});
            this.tsmiAutorenderInterval.Image = global::PdfSharpLivePreview.Properties.Resources.timer_25px;
            this.tsmiAutorenderInterval.Name = "tsmiAutorenderInterval";
            this.tsmiAutorenderInterval.Size = new System.Drawing.Size(176, 22);
            this.tsmiAutorenderInterval.Text = "Autorender interval";
            // 
            // tsmiAutoIntervalSec1
            // 
            this.tsmiAutoIntervalSec1.Name = "tsmiAutoIntervalSec1";
            this.tsmiAutoIntervalSec1.Size = new System.Drawing.Size(126, 22);
            this.tsmiAutoIntervalSec1.Tag = "1";
            this.tsmiAutoIntervalSec1.Text = "1 second";
            this.tsmiAutoIntervalSec1.Click += new System.EventHandler(this.tsmiAutoIntervalSec_Click);
            // 
            // tsmiAutoIntervalSec2
            // 
            this.tsmiAutoIntervalSec2.Checked = true;
            this.tsmiAutoIntervalSec2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiAutoIntervalSec2.Name = "tsmiAutoIntervalSec2";
            this.tsmiAutoIntervalSec2.Size = new System.Drawing.Size(126, 22);
            this.tsmiAutoIntervalSec2.Tag = "2";
            this.tsmiAutoIntervalSec2.Text = "2 seconds";
            // 
            // tsmiAutoIntervalSec3
            // 
            this.tsmiAutoIntervalSec3.Name = "tsmiAutoIntervalSec3";
            this.tsmiAutoIntervalSec3.Size = new System.Drawing.Size(126, 22);
            this.tsmiAutoIntervalSec3.Tag = "3";
            this.tsmiAutoIntervalSec3.Text = "3 seconds";
            // 
            // tsmiAutoIntervalSec4
            // 
            this.tsmiAutoIntervalSec4.Name = "tsmiAutoIntervalSec4";
            this.tsmiAutoIntervalSec4.Size = new System.Drawing.Size(126, 22);
            this.tsmiAutoIntervalSec4.Tag = "4";
            this.tsmiAutoIntervalSec4.Text = "4 seconds";
            // 
            // tsmiAutoIntervalSec5
            // 
            this.tsmiAutoIntervalSec5.Name = "tsmiAutoIntervalSec5";
            this.tsmiAutoIntervalSec5.Size = new System.Drawing.Size(126, 22);
            this.tsmiAutoIntervalSec5.Tag = "5";
            this.tsmiAutoIntervalSec5.Text = "5 seconds";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Image = global::PdfSharpLivePreview.Properties.Resources.info_25px;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(176, 22);
            this.tsmiAbout.Text = "About...";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tAutoRender
            // 
            this.tAutoRender.Enabled = true;
            this.tAutoRender.Interval = 2000;
            this.tAutoRender.Tick += new System.EventHandler(this.tAutoRender_Tick);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.Filter = "C# scripts|*.csx|All files|*.*";
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.FileName = "PdfSharpScript.csx";
            this.sfdSaveFile.Filter = "C# scripts|*.csx|All files|*.*";
            // 
            // FormPdfSharLivePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 596);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPdfSharLivePreview";
            this.Text = "PDFSharp Live Preview";
            this.Load += new System.EventHandler(this.FormPdfSharLivePreview_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FastColoredTextBoxNS.FastColoredTextBox editor;
        private PdfSharp.Forms.PagePreview preview;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRender;
        private System.Windows.Forms.ToolStripButton tsbAutorender;
        private System.Windows.Forms.Timer tAutoRender;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLoadExample;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsddbSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutorenderInterval;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoIntervalSec1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoIntervalSec5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSplitButton tssbSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoIntervalSec2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoIntervalSec3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoIntervalSec4;
    }
}

