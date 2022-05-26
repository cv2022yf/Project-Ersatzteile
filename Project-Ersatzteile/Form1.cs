using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;

namespace Project_Ersatzteile
{
    
    public partial class Form1 : Form
    {
        public Teile[] tl = new Teile[100];
        public int global_i = 0;
        public int global_pos_max = 0;

        OleDbConnection con = new("Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Ersatzteile.accdb");
        OleDbCommand cmd = new();
        private OleDbDataAdapter da = null;
        private DataTable dt = null;
        private DataView dv = null;
        private DataRowView drv = null;
        private OleDbCommandBuilder cb = null;
        private DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdTeiledit_Click(object sender, EventArgs e)
        {
                Form3 fr3 = new Form3(tl, global_i);

                fr3.ggi = global_i;
                fr3.ggn = global_pos_max;
            
                this.Hide();
                fr3.Show();
            
            //when the form3 is closed - delegate funk
            fr3.FormClosed += (sender2, e2) =>
            {
                this.Show();
                global_i = fr3.ggi;
                tl[global_i] = new Teile();//um sicher wegen neu
                tl[global_i].e_id = fr3.rrr[global_i].e_id;
                tl[global_i].teilename = fr3.rrr[global_i].teilename;
                tl[global_i].teilevolume = fr3.rrr[global_i].teilevolume;
                tl[global_i].teileproduktionszeit = fr3.rrr[global_i].teileproduktionszeit;
                tl[global_i].teilebild = fr3.rrr[global_i].teilebild;
                tl[global_i].teilebildausrichtung = fr3.rrr[global_i].teilebildausrichtung;
                tl[global_i].teilecaddatei = fr3.rrr[global_i].teilecaddatei;
                tl[global_i].teilekonfiguration = fr3.rrr[global_i].teilekonfiguration;
                
                if (fr3.ggn != 0)//0 ist flag for delete
                {
                    if (fr3.ggn > global_pos_max)
                    {
                        dbwritenew();
                        ersatzteiledatenbankload();
                        global_i = global_pos_max;
                        dgv1.Rows[global_pos_max].Selected = true;
                        dgv1.CurrentCell = dgv1.Rows[global_pos_max].Cells[0];
                    }
                    else
                        dbwriteupdate();
                }
                else
                {
                    dbwritedelete();
                    ersatzteiledatenbankload();
                    dgv1.Rows[0].Selected = true;
                    dgv1.CurrentCell = dgv1.Rows[0].Cells[0];
                }
                
                form1update();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ersatzteiledatenbankload();
            form1update();
        }

        void form1update()
        {
            txtErsatzteilename.Text = tl[global_i].teilename;
            lblCadfile.Text = tl[global_i].teilename+".stl";
            lblTeilevolume.Text = tl[global_i].teilevolume.ToString();
            lblTeileproduktionszeit.Text = tl[global_i].teileproduktionszeit.ToString();
            ImageConverter converter = new ImageConverter();
            pbTeil.Image=(Image)converter.ConvertFrom(tl[global_i].teilebild);
            pbPosition.Image = (Image)converter.ConvertFrom(tl[global_i].teilebildausrichtung);

            cmbConfig.Items.Clear();
            string eingabe = tl[global_i].teilekonfiguration;
            if (eingabe != "leer")
            {
                string[] teil = eingabe.Split(";");
                for (int i = 0; i < teil.Length; i++)
                {
                    if (teil[i] != "")
                        cmbConfig.Items.Add(teil[i]);
                }
            }
            else
                cmbConfig.Items.Add(eingabe);

            cmbConfig.SelectedIndex = 0;
        }

        void dbwritedelete()
        {
            da = new OleDbDataAdapter("SELECT * FROM ersatzteile ORDER BY e_id", con);
            cb = new OleDbCommandBuilder(da);
            dt = new DataTable("ersatzteile");
            OleDbCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM ersatzteile WHERE " +
                $"e_id = {tl[global_i].e_id.ToString()}";
            try
            {
                con.Open();
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geloescht");
                con.Close();
            }
            catch { }
            finally
            {
                con.Close();
            }
        }

        void dbwritenew()
        {
            da = new OleDbDataAdapter("SELECT * FROM ersatzteile ORDER BY e_id", con);
            cb = new OleDbCommandBuilder(da);
            dt = new DataTable("ersatzteile");
            OleDbCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandText = $"INSERT INTO ersatzteile (e_id, teilename, teilevolume, teileproduktionszeit, teilebild, teilebildorientierung, teilecaddatei, teilekonfiguration) " +
                             $"VALUES({tl[global_i].e_id.ToString()}, '{tl[global_i].teilename.ToString()}', {tl[global_i].teilevolume.ToString()}, {tl[global_i].teileproduktionszeit.ToString()}, ?, ?, ?, ?)";
            cmd.Parameters.Add("", OleDbType.VarBinary).Value = tl[global_i].teilebild;  
            cmd.Parameters.Add("", OleDbType.VarBinary).Value = tl[global_i].teilebildausrichtung;  
            cmd.Parameters.Add("", OleDbType.VarBinary).Value = tl[global_i].teilecaddatei;
            cmd.Parameters.Add("", OleDbType.VarChar).Value = tl[global_i].teilekonfiguration;

            try
            {
                con.Open();
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
                con.Close();
            }
            catch { MessageBox.Show("Nicht geklappt"); }
            finally
            {
                con.Close();
            }
        }

        void dbwriteupdate()
        {
            da = new OleDbDataAdapter("SELECT * FROM ersatzteile ORDER BY e_id", con);
            cb = new OleDbCommandBuilder(da);
            OleDbCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandText = $"UPDATE ersatzteile SET teilename = ?, " +
                $"teilevolume = ?, teileproduktionszeit = ?, teilebild = ?, teilebildorientierung = ?, teilecaddatei = ?, teilekonfiguration = ?" +
                $" WHERE e_id = {tl[global_i].e_id}";
            cmd.Parameters.Add("", OleDbType.VarChar).Value = tl[global_i].teilename;
            cmd.Parameters.Add("", OleDbType.Double).Value = tl[global_i].teilevolume;
            cmd.Parameters.Add("", OleDbType.Double).Value = tl[global_i].teileproduktionszeit;
            cmd.Parameters.Add("", OleDbType.VarBinary).Value = tl[global_i].teilebild;
            cmd.Parameters.Add("", OleDbType.VarBinary).Value = tl[global_i].teilebildausrichtung;
            cmd.Parameters.Add("", OleDbType.VarBinary).Value = tl[global_i].teilecaddatei;
            cmd.Parameters.Add("", OleDbType.VarChar).Value = tl[global_i].teilekonfiguration;
            try
            {
                con.Open();
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
                con.Close();
            }
            catch { }
            finally
            {
                con.Close();
            }

        }


        void ersatzteiledatenbankload()
        {
            da = null;
            dt = null;
            dv = null;
            drv = null;
            cb = null;
            ds = null;
            global_i = 0;

            da = new OleDbDataAdapter("SELECT * FROM ersatzteile ORDER BY e_id", con);
            cb = new OleDbCommandBuilder(da);
            dt = new DataTable("ersatzteile");
            ds = new DataSet();
            //con.Open(); komisch -fill- funktioniert trozdemm
            da.Fill(ds, "Ersatzteile");
            da.Fill(dt);
            //con.Close();

            dv = new DataView(dt);
            dgv1.DataSource = dt;

            global_pos_max = dv.Count-1;

            for (int i = 0; i <= global_pos_max; i++)
            {
                tl[i] = new Teile();
                tl[i].e_id = Convert.ToInt32(dv[i]["e_id"]);
                tl[i].teilename = Convert.ToString(dv[i]["teilename"]);
                tl[i].teilevolume = Convert.ToDouble(dv[i]["teilevolume"]);
                tl[i].teileproduktionszeit = Convert.ToDouble(dv[i]["teileproduktionszeit"]);
                tl[i].teilebild = (Byte[])(ds.Tables["Ersatzteile"].Rows[i]["Teilebild"]);
                tl[i].teilebildausrichtung = (Byte[])(ds.Tables["Ersatzteile"].Rows[i]["Teilebildorientierung"]);
                tl[i].teilecaddatei = (Byte[])(ds.Tables["Ersatzteile"].Rows[i]["Teilecaddatei"]);
                tl[i].teilekonfiguration = Convert.ToString(dv[i]["teilekonfiguration"]);
            }
            Teile.e_id_last = Convert.ToInt32(dv[global_pos_max]["e_id"]);
        }

        private void cmdForwards_Click(object sender, EventArgs e)
        {
            if (global_i == global_pos_max) return;
            global_i++;
            dgv1.Rows[dgv1.CurrentRow.Index+1].Selected = true;
            dgv1.CurrentCell = dgv1.Rows[dgv1.CurrentRow.Index + 1].Cells[0];
            form1update();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            global_i = 0;
            dgv1.Rows[0].Selected = true;
            dgv1.CurrentCell = dgv1.Rows[0].Cells[0];
            form1update();
        }

        private void cmdBackwards_Click(object sender, EventArgs e)
        {
            if (global_i == 0) return;
            global_i--;
            dgv1.Rows[dgv1.CurrentRow.Index - 1].Selected = true;
            dgv1.CurrentCell = dgv1.Rows[dgv1.CurrentRow.Index - 1].Cells[0];
            form1update();
        }

        private void cmdCaddateidownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                Title = "Datei zum Speichern auswählen"
            };
            MessageBox.Show(sfd.ShowDialog() == DialogResult.OK
                ? $"Speichern: {sfd.FileName}" : "Abbruch");

            File.WriteAllBytes(sfd.FileName, tl[global_i].teilecaddatei);
        }

        private void cmdConfigload_Click(object sender, EventArgs e)
        {
            if (tl[global_i].teilekonfiguration == "leer")
                return;

            SaveFileDialog sfd = new()
            {
                Title = "Datei zum Speichern auswählen"
            };
            MessageBox.Show(sfd.ShowDialog() == DialogResult.OK
                ? $"Speichern: {sfd.FileName}" : "Abbruch");

            string ff = cmbConfig.SelectedItem.ToString();
            ff = "C://temp/" + ff;
            Byte []btemp1;
            btemp1 = File.ReadAllBytes(ff);
            File.WriteAllBytes(sfd.FileName, btemp1);
        }
    }
}