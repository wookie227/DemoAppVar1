using DemoApp.Data;
using DemoAppVar1.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DemoAppVar1
{
    public partial class Main : Form
    {
        private readonly Auth _auth;
        private readonly CreateForm _createServicePage;
        public Main(Auth auth)
        {
            _auth = auth;
            InitializeComponent();
            LoadData();
        }


        public void LoadData()
        {
            using (var db = new AppDbContext())
            {
                var services = db.Services.ToList();
                DataService.DataSource = services;
                DataService.Columns["Client"].Visible = false;
                DataService.Columns["Employee"].Visible = false;
                DataService.Columns["Device"].Visible = false;
                DataService.Columns["StatusUpdates"].Visible = false;
                DataService.Columns["ServiceDetails"].Visible = false;
                DataService.Columns["Comments"].Visible = false;
            }
        }

        public void LoadDataClicked(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var create = new CreateForm();
            create.CreateButtonClicked += LoadDataClicked;
            create.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            _auth.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            var service = (ServiceModel)DataService.SelectedRows[0].DataBoundItem;
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Services.Remove(service);
                    db.SaveChanges();
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var service = (ServiceModel)DataService.SelectedRows[0].DataBoundItem;
            var create = new CreateForm(service);
            create.CreateButtonClicked += LoadDataClicked;
            create.Show();
        }
    }
}
