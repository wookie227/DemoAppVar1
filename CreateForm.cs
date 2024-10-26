using DemoApp.Data;
using DemoAppVar1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppVar1
{
    public partial class CreateForm : Form
    {
        public event EventHandler CreateButtonClicked;
        private readonly ServiceModel _service;
        public CreateForm(ServiceModel? service = null)
        {
            _service = service;
            InitializeComponent();
            LoadData();
            if (_service == null)
            {
                IdTB.Visible = false;
                StatusCB.Visible = false;
            }
            else
            {

            }
            PriorityCB.SelectedIndex = 0;
            TypeCB.SelectedIndex = 0;
        }

        public void LoadData()
        {
            if (_service != null)
            {
                IdTB.Text = _service.Id.ToString();
                PriorityCB.SelectedItem = _service.Priority.ToString();
                TypeCB.SelectedItem = _service.Type.ToString();
                DescTB.Text = _service.Desc.ToString();
                ReasonTB.Text = _service.Reason.ToString();
                PriceTB.Text = _service.Price.ToString();
                ClientCB.SelectedValue = _service.ClientId;
                EmployeeCB.SelectedValue = _service.EmployeeId;
                DeviceCB.SelectedValue = _service.DeviceId;
            }
            else
            {
                IdTB.Clear();
                PriorityCB.SelectedIndex = 0;
                TypeCB.SelectedIndex = 0;
                DescTB.Clear();
                ReasonTB.Clear();
                PriceTB.Clear();
                ClientCB.SelectedIndex = -1;
                EmployeeCB.SelectedIndex = -1;
                DeviceCB.SelectedIndex = -1;
            }

            using (var db = new AppDbContext())
            {
                var clients = db.Clients.ToList();
                var employees = db.Employees.ToList();
                var devices = db.Devices.ToList();
                var statuses = db.Statuses.ToList();

                StatusCB.DataSource = statuses;
                StatusCB.DisplayMember = "Name";
                StatusCB.ValueMember = "Id";

                ClientCB.DataSource = clients;
                ClientCB.DisplayMember = "Name";
                ClientCB.ValueMember = "Id";

                EmployeeCB.DataSource = employees;
                EmployeeCB.DisplayMember = "FullName";
                EmployeeCB.ValueMember = "Id";

                DeviceCB.DataSource = devices;
                DeviceCB.DisplayMember = "Name";
                DeviceCB.ValueMember = "Id";
            }
        }

        public void CreateService()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var type = TypeCB.SelectedItem.ToString();
                    var priority = PriorityCB.SelectedItem.ToString();
                    var desc = DescTB.Text;
                    var reason = ReasonTB.Text;
                    var createdAt = DateTime.UtcNow;
                    var price = Convert.ToInt32(PriceTB.Text);
                    var clientId = Convert.ToInt32(ClientCB.SelectedValue);
                    var employeeId = Convert.ToInt32(EmployeeCB.SelectedValue);
                    var deviceId = DeviceCB.SelectedValue.ToString();


                    ServiceModel newService = new ServiceModel
                    {
                        Priority = priority,
                        Type = type,
                        Desc = desc,
                        Reason = reason,
                        CreatedAt = createdAt,
                        Price = price,
                        ClientId = clientId,
                        EmployeeId = employeeId,
                        DeviceId = deviceId
                    };

                    db.Services.Add(newService);
                    db.SaveChanges();

                    var status = db.Statuses.FirstOrDefault(x => x.Name == "Не выполнено");

                    StatusUpdateModel statusUpdateModel = new StatusUpdateModel
                    {
                        ServiceId = newService.Id,
                        UpdatedAt = createdAt,
                        StatusId = status.Id
                    };

                    db.StatusUpdates.Add(statusUpdateModel);
                    db.SaveChanges();

                    CreateButtonClicked?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Заявка добавлена");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void UpdateService()
        {
            using (var db = new AppDbContext())
            {
                var currentService = db.Services.FirstOrDefault(x => x.Id == _service.Id);

                var type = TypeCB.SelectedItem.ToString();
                var priority = PriorityCB.SelectedItem.ToString();
                var desc = DescTB.Text;
                var reason = ReasonTB.Text;
                var createdAt = DateTime.UtcNow;
                var price = Convert.ToInt32(PriceTB.Text);
                var clientId = Convert.ToInt32(ClientCB.SelectedValue);
                var employeeId = Convert.ToInt32(EmployeeCB.SelectedValue);
                var deviceId = DeviceCB.SelectedValue.ToString();


                currentService.Type = type;
                currentService.Priority = priority;
                currentService.Desc = desc;
                currentService.Price = price;
                currentService.ClientId = clientId;
                currentService.EmployeeId = employeeId;
                currentService.DeviceId = deviceId;

                var status = db.Statuses.FirstOrDefault(x => x.Id == Convert.ToInt32(StatusCB.SelectedValue));

                StatusUpdateModel statusUpdateModel = new StatusUpdateModel
                {
                    ServiceId = currentService.Id,
                    UpdatedAt = createdAt,
                    StatusId = status.Id
                };

                db.StatusUpdates.Add(statusUpdateModel);
                db.SaveChanges();

                db.Services.Update(currentService);
                db.SaveChanges();

                CreateButtonClicked?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Заявка обновлена");
                this.Close();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (_service == null)
            {
                CreateService();
            }
            else
            {
                UpdateService();
            }

        }

    }
}
