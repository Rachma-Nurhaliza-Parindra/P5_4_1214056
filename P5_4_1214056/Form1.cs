using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214056
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        string kelas = "";
        string jadwal = "";
        private void jadwal1_CheckedChanged(object sender, EventArgs e)
        {
            if (jadwal1.Checked)
            {
                jadwal = "Senin dan Rabu, 14.00 - 16.00";
            }
            else if (jadwal2.Checked)
            {
                jadwal = "Selasa dan Kamis, 14.00 - 16.00";
            }
            else if (jadwal3.Checked)
            {
                jadwal = "Sabtu dan Minggu, 09.00 - 11.00";
            }
            else if (jadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
        }

        private void jadwal2_CheckedChanged(object sender, EventArgs e)
        {
            if (jadwal1.Checked)
            {
                jadwal = "Senin dan Rabu, 14.00 - 16.00";
            }
            else if (jadwal2.Checked)
            {
                jadwal = "Selasa dan Kamis, 14.00 - 16.00";
            }
            else if (jadwal3.Checked)
            {
                jadwal = "Sabtu dan Minggu, 09.00 - 11.00";
            }
            else if (jadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
        }

        private void jadwal3_CheckedChanged(object sender, EventArgs e)
        {
            if (jadwal1.Checked)
            {
                jadwal = "Senin dan Rabu, 14.00 - 16.00";
            }
            else if (jadwal2.Checked)
            {
                jadwal = "Selasa dan Kamis, 14.00 - 16.00";
            }
            else if (jadwal3.Checked)
            {
                jadwal = "Sabtu dan Minggu, 09.00 - 11.00";
            }
            else if (jadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
        }

        private void jadwal4_CheckedChanged(object sender, EventArgs e)
        {
            if (jadwal1.Checked)
            {
                jadwal = "Senin dan Rabu, 14.00 - 16.00";
            }
            else if (jadwal2.Checked)
            {
                jadwal = "Selasa dan Kamis, 14.00 - 16.00";
            }
            else if (jadwal3.Checked)
            {
                jadwal = "Sabtu dan Minggu, 09.00 - 11.00";
            }
            else if (jadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }
        }

        private void cbBiola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola";
            }
            if (cbDrum.Checked)
            {
                kelas = kelas + "Drum";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar";
            }
            if (cbKomposer.Checked)
            {
                kelas = kelas + "Komposer";
            }
            if (cbKonduktor.Checked)
            {
                kelas = kelas + "Konduktor";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano";
            }
            if (cbSaxophone.Checked)
            {
                kelas = kelas + "Saxophone";
            }
            if (cbVokal.Checked)
            {
                kelas = kelas + "Vokal";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbDrum_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola";
            }
            if (cbDrum.Checked)
            {
                kelas = kelas + "Drum";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar";
            }
            if (cbKomposer.Checked)
            {
                kelas = kelas + "Komposer";
            }
            if (cbKonduktor.Checked)
            {
                kelas = kelas + "Konduktor";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano";
            }
            if (cbSaxophone.Checked)
            {
                kelas = kelas + "Saxophone";
            }
            if (cbVokal.Checked)
            {
                kelas = kelas + "Vokal";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
