using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting.Hosting;
using Microsoft.CodeAnalysis.Scripting;
using PdfSharp.Drawing;
using FastColoredTextBoxNS;
using System.Drawing.Drawing2D;

namespace PdfSharpLivePreview
{
    public partial class FormPdfSharLivePreview : Form
    {
        WavyLineStyle errorStyle = new WavyLineStyle(255, Color.Red);

        int errorLine = -1;
        Range errorRange;
        string currentFilename;

        public FormPdfSharLivePreview()
        {
            InitializeComponent();
        }

        public void Render()
        {
            preview.SetRenderEvent(renderScript);
        }

        private void renderScript(XGraphics gfx)
        {
            errorLine = -1;
            if (errorRange != null)
                errorRange.ClearStyle(errorStyle);
            
            try
            {
                // Prepare all the assemblies that could be needed by our scripts
                var opts = ScriptOptions.Default.WithReferences(
                    typeof(PdfSharp.Drawing.XGraphics).Assembly,
                    typeof(System.Drawing.FontFamily).Assembly
                );

                CSharpScript.EvaluateAsync(editor.Text, opts, globals: new Globals{ gfx = gfx });
                textBox1.Text = "Compiled successfully!";
            }
            catch (CompilationErrorException x)
            {
                foreach(var d in x.Diagnostics)
                {
                    var ls = d.Location.GetLineSpan();
                    errorRange = editor.GetRange(new Place(ls.StartLinePosition.Character, ls.StartLinePosition.Line),
                        new Place(ls.EndLinePosition.Character, ls.EndLinePosition.Line));
                    errorLine = ls.StartLinePosition.Line;
                    errorRange.SetStyle(errorStyle);

                    // Break here instead of keeping track of all the places where there are errors for performance reasons
                    break; 
                }
                textBox1.Text = x.Message;
            }
            catch (Exception x)
            {
                textBox1.Text = $"[{x.GetType().Name}] {x.Message} {Environment.NewLine}";
            }
        }

        private void FormPdfSharLivePreview_Load(object sender, EventArgs e)
        {
            Width = 1200;
            Height = 700;
            editor.PaintLine += Editor_PaintLine;

            var scriptFiles = Directory.EnumerateFiles(".", "*.csx").ToList();
            scriptFiles.Sort();
            foreach (var file in scriptFiles)
            {
                var tsmi = new ToolStripMenuItem();

                tsmi.Tag = file;

                // Replace underscores with spaces to allow nicer names and remove leading underscores for easier sorting
                tsmi.Text = Path.GetFileNameWithoutExtension(file).Replace('_',' ').Trim();
                tsmi.Click += (s, _) => {
                    LoadFile((s as ToolStripMenuItem).Tag.ToString());
                };

                tsddbLoadExample.DropDownItems.Add(tsmi);
            }

            LoadFile("Default.csx");
        }

        private void LoadFile(string file)
        {
            editor.Text = File.ReadAllText(file);
        }

        private void Editor_PaintLine(object sender, PaintLineEventArgs e)
        {
            if (e.LineIndex == errorLine)
                using (var brush = new SolidBrush(Color.Red))
                    e.Graphics.FillPolygon(brush, new PointF[] { // Draw a triangle
                        new PointF( 2, e.LineRect.Top + 3 ),
                        new PointF( 10, e.LineRect.Top + 8),
                        new PointF( 2, e.LineRect.Top + 13)
                    });
        }

        private void tsbRender_Click(object sender, EventArgs e)
        {
            Render();
        }

        private void tAutoRender_Tick(object sender, EventArgs e)
        {
            Render();
        }

        private void editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            tAutoRender.Stop(); // Resets the timer
            tAutoRender.Start();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                LoadFile(ofdOpenFile.FileName);
            }
        }

        private void tsbAutorender_Click(object sender, EventArgs e)
        {
            tAutoRender.Enabled = tsbAutorender.Checked;
        }

        private void tsmiAutoIntervalSec_Click(object sender, EventArgs e)
        {
            foreach(ToolStripItem item in tsmiAutorenderInterval.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                    (item as ToolStripMenuItem).Checked = false;
            }
            var tsmi = sender as ToolStripMenuItem;
            tAutoRender.Interval = int.Parse(tsmi.Tag.ToString()) * 1000;
            tsmi.Checked = true;
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void tssbSave_ButtonClick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(currentFilename))
            {
                SaveFileAs();
            }
            else
            {
                SaveFile();
            }
        }

        private void SaveFileAs()
        {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                currentFilename = sfdSaveFile.FileName;
                SaveFile();
            }
        }

        private void SaveFile()
        {
            File.WriteAllText(currentFilename, editor.Text);
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }
    }

    public class Globals
    {
        public XGraphics gfx;
    }
}
