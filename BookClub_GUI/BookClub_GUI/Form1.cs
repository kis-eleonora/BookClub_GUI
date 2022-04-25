using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookClub_GUI
{
    public partial class Form1 : Form

    {
        List<Tag> tag = new List<Tag>();
        MySqlCommand sql = null;
        MySqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Beolvasas();
        }

        private void Beolvasas()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.Database = "bookclub";
            sb.UserID = "root";
            sb.Password = "";
            sb.CharacterSet = "utf8";

            connection = new MySqlConnection(sb.ConnectionString);
            sql = connection.CreateCommand();

            try
            {
                connection.Open();
                sql.CommandText = "SELECT `id`, `csaladnev`, `utonev` FROM `tagok` WHERE 1 ORDER BY `csaladnev`;";
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Tag ujtag = new Tag(dr.GetString("csaladnev"), dr.GetInt32("id"), dr.GetString("utonev"));
                        comboBox_nev.Items.Add(ujtag);
                    }
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void button_rogzit_Click(object sender, EventArgs e)
        {
            if (comboBox_nev.SelectedIndex < 0)
            {
                return;
            }
            Tag tag = (Tag)comboBox_nev.SelectedItem;
            int id = tag.Id;
            string datum = dateTimePicker_datum.Value.ToString("yyyy-MM-dd");
            int osszeg = (int)numericUpDown_osszeg.Value;
            connection.Open();
            sql.CommandText = "INSERT INTO `befizetes`(`id`, `datum`, `befizetes`) VALUES (@id, @datum, @osszeg);";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@id", id);
            sql.Parameters.AddWithValue("@datum", datum);
            sql.Parameters.AddWithValue("@osszeg", osszeg);
            if (sql.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Sikeres rögzítés!", "Visszajelzés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Sikertelen rögzítés!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.Close();
            comboBox_nev.SelectedIndex = -1;
            numericUpDown_osszeg.Value = numericUpDown_osszeg.Minimum;

        }
    }
}
