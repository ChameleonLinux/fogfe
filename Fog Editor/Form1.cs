using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fog.Parser;
using System.IO;

namespace Fog_Editor
{
    public partial class MainWindow : Form
    {
        PrivateFontCollection pfc;
        string fname;
        Fog.Parser.File file;
        public MainWindow()
        {
            InitializeComponent();
            pfc = OpenSans();
            Font = new Font(pfc.Families[0], Font.Size);
            label_title.Font = new Font(pfc.Families[0], label_title.Font.Size);
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public PrivateFontCollection OpenSans()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.u_WUoqrET9fUeobQW7jkRRJtnKITppOI_IvcXXDNrsc.Length;
            byte[] fontdata = Properties.Resources.u_WUoqrET9fUeobQW7jkRRJtnKITppOI_IvcXXDNrsc;
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref cFonts);
            pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);
            return pfc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new string[] { "", "", "", "" });
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fname = openFileDialog1.FileName;
            file = Parser.read(fname);
            upstream.Text = file.super["upstream"];
            dataGridView1.Rows.Clear();
            foreach(Record r in file.data)
            {
                dataGridView1.Rows.Add(new string[]{ r.id, r.dest, r.type, r.fname });
            }
            Text = "Fog File Editor (" + fname + ")";
        }

        private void save_file_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            fname = saveFileDialog1.FileName;
            StreamWriter f = new StreamWriter(fname);
            file = new Fog.Parser.File();
            f.WriteLine("@upstream " + upstream.Text);
            foreach(DataGridViewRow record in dataGridView1.Rows)
            {
                try
                {
                    doNothing(record.Cells[0].Value.ToString().Length);
                } catch(Exception)
                {
                    continue;
                }
                if(record.Cells[0].Value.ToString().Length != 0 && record.Cells[1].Value.ToString().Length != 0 && record.Cells[2].Value.ToString().Length != 0 && record.Cells[3].Value.ToString().Length != 0)
                f.WriteLine("- " + record.Cells[0].Value + " " + record.Cells[1].Value + " " + record.Cells[2].Value + " " + record.Cells[3].Value);
            }
            f.Close();
            Text = "Fog File Editor (" + fname + ")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fname == null || file == null)
            {
                Application.Exit();
            } else {
                dataGridView1.Rows.Clear();
                fname = null;
                file = null;
            }
            Text = "Fog File Editor (none)";
        }
        public void doNothing(object _) { }
    }
}
