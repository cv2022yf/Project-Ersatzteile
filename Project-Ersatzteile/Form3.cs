using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Ersatzteile
{
    public partial class Form3 : Form
    {
        public Teile[] rrr = new Teile[100];
        public int ggi;
        public int ggn;
        public Byte[] bbtemp;
        public Byte[] btemp1;

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Teile[] yyy, int ggi2)
        {
            if (rrr[ggi2] == null)
                rrr[ggi2] = new Teile();

            rrr[ggi2].e_id = yyy[ggi2].e_id;
            rrr[ggi2].teilename = yyy[ggi2].teilename;
            rrr[ggi2].teilevolume = yyy[ggi2].teilevolume;
            rrr[ggi2].teileproduktionszeit = yyy[ggi2].teileproduktionszeit;
            rrr[ggi2].teilebild = yyy[ggi2].teilebild;
            rrr[ggi2].teilebildausrichtung = yyy[ggi2].teilebildausrichtung;
            rrr[ggi2].teilecaddatei = yyy[ggi2].teilecaddatei;
            rrr[ggi2].teilekonfiguration = yyy[ggi2].teilekonfiguration;
            InitializeComponent();
        }
        void form3update()
        {
            txtTeilname3.Text = rrr[ggi].teilename;
            lblCadfile3.Text = rrr[ggi].teilename + ".stl";
            txtVolume3.Text = rrr[ggi].teilevolume.ToString();
            txtTeilezeit3.Text = rrr[ggi].teileproduktionszeit.ToString();
            ImageConverter converter = new ImageConverter();
            pbTeil.Image = (Image)converter.ConvertFrom(rrr[ggi].teilebild);
            pbPosition.Image = (Image)converter.ConvertFrom(rrr[ggi].teilebildausrichtung);
            if (rrr[ggi].teilecaddatei == null)
                lblCadfile3.Text = "leer";

            lstPakete.Items.Clear();
            string eingabe = rrr[ggi].teilekonfiguration;
            if (eingabe != "leer")
            {
                string[] teil = eingabe.Split(";");
                for (int i = 0; i < teil.Length; i++)
                {
                    if (teil[i]!="")
                        lstPakete.Items.Add(teil[i]);
                }
            }
            else
                lstPakete.Items.Add(eingabe);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            form3update();
        }

        private void cmdNewteil_Click(object sender, EventArgs e)
        {
            ggn++;//weil bei neu max ist +1
            rrr[ggn] = new Teile();
            Teile.e_id_last++;//static var from class
            rrr[ggn].e_id = Teile.e_id_last;//neu e_id
            rrr[ggn].teilename = txtTeilname3.Text;
            rrr[ggn].teilevolume = Convert.ToDouble(txtVolume3.Text);
            rrr[ggn].teileproduktionszeit = Convert.ToDouble(txtTeilezeit3.Text);
            MemoryStream ms = new MemoryStream();
            pbTeil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            rrr[ggn].teilebild = ms.ToArray();
            MemoryStream ms1 = new MemoryStream();
            pbPosition.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            rrr[ggn].teilebildausrichtung = ms1.ToArray();
            rrr[ggn].teilecaddatei = bbtemp;
            if (bbtemp == null)
                MessageBox.Show("Bitte CAD datei hochladen. Neues Teil wird nicht erstellt");
            rrr[ggn].teilekonfiguration = rrr[ggi].teilekonfiguration;
            ggi = ggn;//sehr wichtig pos on max
            Close();
        }

        private void cmdTeiledit_Click(object sender, EventArgs e)
        {
            rrr[ggi].teilename = txtTeilname3.Text;
            rrr[ggi].teilevolume = Convert.ToDouble(txtVolume3.Text);
            rrr[ggi].teileproduktionszeit = Convert.ToDouble(txtTeilezeit3.Text);
            MemoryStream ms = new MemoryStream();
            pbTeil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            rrr[ggi].teilebild = ms.ToArray();
            MemoryStream ms1 = new MemoryStream();
            pbPosition.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            rrr[ggi].teilebildausrichtung = ms1.ToArray();

            if (bbtemp != null)
                rrr[ggi].teilecaddatei = bbtemp;

            Close();
        }

        private void cmdTeildelete_Click(object sender, EventArgs e)
        {
            if (ggn > 1)
                ggn = 0;//als flagge fuer delete
            else
                MessageBox.Show("Datenbank ist zu klein");
            Close();
        }

        private void cmdCadupload_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            bbtemp = File.ReadAllBytes(filePath);
            lblCadfile3.Text = txtTeilname3.Text + ".stl";
        }

        private void cmdTeilpicupload_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            pbTeil.Image = Image.FromFile(filePath);
        }

        private void cmdPositionpicfileupload_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            pbPosition.Image = Image.FromFile(filePath);
        }

        private void cmdConfigdelete_Click(object sender, EventArgs e)
        {
            if (rrr[ggi].teilekonfiguration == "leer")
                return;
            
            lstPakete.Items.RemoveAt(lstPakete.SelectedIndex);
            lstPakete.SelectedItems.Clear();
            rrr[ggi].teilekonfiguration = string.Empty;
            if (lstPakete.Items.Count < 1)
            {
                lstPakete.Items.Clear();
                lstPakete.Items.Add("leer");
                rrr[ggi].teilekonfiguration = "leer";
                return;
            }

            for (int i = 0; i < lstPakete.Items.Count; i++)
                rrr[ggi].teilekonfiguration += lstPakete.Items[i].ToString() + ";";
        }

        private void cmdConfigupload_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var justname = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    justname = openFileDialog.SafeFileName;
                }
            }
            btemp1 = null;
            btemp1 = File.ReadAllBytes(filePath);

            File.WriteAllBytes("C://temp/" + justname, btemp1);

            if (rrr[ggi].teilekonfiguration != "leer")
            {
                lstPakete.Items.Add(justname);
                rrr[ggi].teilekonfiguration += justname + ";";
                return;
            }
            else
            {
                lstPakete.Items.Clear();
                lstPakete.Items.Add(justname);
                rrr[ggi].teilekonfiguration = justname + ";";
            }
        }
    }
}
