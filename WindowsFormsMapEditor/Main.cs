using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Framework.Main;
using Framework;
using System.IO;

namespace WindowsFormsMapEditor
{
    public partial class Main : Form
    {
        private Point size = new Point(0, 0);
        private string tilesPath = "../../../Image/Tiles";
        private string filestyle = ".MSF";

        public Main()
        {
            InitializeComponent();

            MainGame.GetT.mainDX = new DxBasic.DXInform();
            MainGame.GetT.tileDX = new DxBasic.DXInform();
            MainGame.GetT.mainDX.MakeDevice(this.Panel_Render);
            MainGame.GetT.tileDX.MakeDevice(this.Tiles_Panel);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] files = GetFileNames(tilesPath, "*.png");
            for(int i = 0; i < files.Length; i++)
            {
                TileManager.GetT.AddSelectTile(
                    ResourceManager.GetT.GetTexture(tilesPath + "/" + files[i], MainGame.GetT.tileDX.Dx_device),
                    tilesPath + "/" + files[i], files[i]);
            }
        }

        private static string[] GetFileNames(string path, string filter)
        {
            string[] files = Directory.GetFiles(path, filter);
            for (int i = 0; i < files.Length; i++) files[i] = Path.GetFileName(files[i]);
            return files;
        }

        private void Main_KeyPress(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, EventArgs e)
        {

        }

        private void Panel_Render_Paint(object sender, EventArgs e)
        {

        }

        private void Panel_Render_MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    TileManager.GetT.TileClick();
                    break;
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case 'w':
                    ScrollManager.GetT.ScrollUp();
                    break;
                case 'a':
                    ScrollManager.GetT.ScrollLeft();
                    break;
                case 's':
                    ScrollManager.GetT.ScrollDown();
                    break;
                case 'd':
                    ScrollManager.GetT.ScrollRight();
                    break;
                case 'q':
                    TileManager.GetT.TileClick();
                    break;
                case 'e':
                    TileManager.GetT.DestroyClick();
                    break;
            }
        }

        private void Tiles_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    TileManager.GetT.SelectTileClick();
                    break;
            }
        }

        private void SubControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            int subSpeed = 10;
            Point point = ScrollManager.GetT.SubScrollPoint;
            switch (e.KeyChar)
            {
                case 'w':
                    point.Y += subSpeed;
                    ScrollManager.GetT.SubScrollPoint = point;
                    break;
                case 'a':
                    point.X += subSpeed;
                    ScrollManager.GetT.SubScrollPoint = point;
                    break;
                case 's':
                    point.Y -= subSpeed;
                    ScrollManager.GetT.SubScrollPoint = point;
                    break;
                case 'd':
                    point.X -= subSpeed;
                    ScrollManager.GetT.SubScrollPoint = point;
                    break;
            }
        }

        public void UtilityUpdate()
        {
            MainGame.GetT.FormPosition = this.Location;
        }

        private void sizeChange_Click(object sender, EventArgs e)
        {
            TileManager.GetT.SetTileScale(size);
        }

        private void tilesizeY_TextChanged(object sender, EventArgs e)
        {
            int y = 0;
            if (Int32.TryParse(this.tilesizeY.Text, out y))
            {
                size.Y = y;
            }
        }

        private void tilesizeX_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (Int32.TryParse(this.tilesizeX.Text, out x))
            {
                size.X = x;
            }
        }

        private void openOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "MSF files (*.MSF)|*.MSF|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = "../../../Image/";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                string a = "a";
                size = InputManager.GetT.GetStreamPoint(streamReader, ref a);
                TileManager.GetT.SetTileScale(size);
                streamReader.Close();
            }
        }

        private void saveSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter  = "MSF files (*.MSF)|*.MSF|All files(*.*)|*.*";
            saveFileDialog.InitialDirectory = "../../../Image/";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(size + "/");
                TileManager.GetT.SaveFile(saveFileDialog.FileName + filestyle, streamWriter);
                streamWriter.Close();
            }
        }

        private void openOToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
