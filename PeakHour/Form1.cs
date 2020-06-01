using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using PeakHour.Data;
using PeakHour.Repository;
using PeakHour.Models;
using System.Net.Mime;
using System.Windows.Media.Media3D;

namespace PeakHour
{
    public partial class Main : MaterialForm
    {
        PeakHourEntities context = new PeakHourEntities();

        public Main()
        {

            InitializeComponent();
                
            var matSkinManager = MaterialSkinManager.Instance;
            matSkinManager.AddFormToManage(this);
            matSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            matSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label1.Hide();
            //lblToday.Text = DateTime.Now.ToShortDateString();
            //var model = context.tblPeakHours.Count();
            var model = context.tblPeakHours.Where(d => d.DateToday == DateTime.Today);
            if(model != null)
            {
                var count = model.Count();
                if(count == 5)
                {
                    cmbSession.Enabled = false;
                    btnEnergetic.Enabled = false;
                    btnNeutral.Enabled = false;
                    btnOkay.Enabled = false;
                    btnStressed.Enabled = false;
                    label1.Show();
                }
            }
        }

        private void btnStressed_Click(object sender, EventArgs e)
        {

            if (cmbSession.SelectedItem == null)
            {
                MessageBox.Show("Select Session");
            }
            else
            {
                var session = cmbSession.SelectedItem.ToString();
                var mood = "Stressed";
                var message = AddDataToDB(session, mood);
                MessageBox.Show(message);
            }

        }

        private void btnMetrics_Click(object sender, EventArgs e)
        {
            Metrics metricsForm = new Metrics();
            metricsForm.Show();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (cmbSession.SelectedItem == null)
            {
                MessageBox.Show("Select Session");
            }
            else
            {
                var session = cmbSession.SelectedItem.ToString();
                var mood = "Okay";
                var message = AddDataToDB(session, mood);
                MessageBox.Show(message);
            }
        }

        public string AddDataToDB(string session, string mood)
        {
            var sI = cmbSession.SelectedIndex;
            tblPeakHour hour = new tblPeakHour();
            hour.DateToday = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            hour.Session = session;
            hour.Mood = mood;
            if (hour.DateToday == DateTime.Today)
            {
                var model = context.tblPeakHours.Where(d => d.DateToday == DateTime.Today);
                if (model != null)
                {
                    var checkSession = context.tblPeakHours.Where(s => s.Session == session).Count();
                    if (checkSession >= 1)
                    {
                        return "Session already captured";
                    }
                    else
                    {
                        context.tblPeakHours.Add(hour);
                    }
                }
            }


            int res = context.SaveChanges();
            if (res >= 1)
            {

                return "Saved Successfully!";
            }
            else
            {
                return "Item Not Saved";
            }
        }

        private void btnNeutral_Click(object sender, EventArgs e)
        {
            if (cmbSession.SelectedItem == null)
            {
                MessageBox.Show("Select Session");
            }
            else
            {
                var session = cmbSession.SelectedItem.ToString();
                var mood = "Neutral";
                var message = AddDataToDB(session, mood);
                MessageBox.Show(message);
            }
        }

        private void btnEnergetic_Click(object sender, EventArgs e)
        {
            if (cmbSession.SelectedItem == null)
            {
                MessageBox.Show("Select Session");
            }
            else
            {
                var session = cmbSession.SelectedItem.ToString();
                var mood = "Energetic";
                var message = AddDataToDB(session, mood);
                MessageBox.Show(message);
            }
        }

        private void cmbSession_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
