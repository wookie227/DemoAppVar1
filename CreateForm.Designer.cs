namespace DemoAppVar1
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DescTB = new TextBox();
            ReasonTB = new TextBox();
            PriceTB = new TextBox();
            ClientCB = new ComboBox();
            DeviceCB = new ComboBox();
            EmployeeCB = new ComboBox();
            SaveBtn = new Button();
            IdTB = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PriorityCB = new ComboBox();
            TypeCB = new ComboBox();
            StatusCB = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DescTB
            // 
            DescTB.Location = new Point(3, 90);
            DescTB.Multiline = true;
            DescTB.Name = "DescTB";
            DescTB.PlaceholderText = "Описание";
            DescTB.Size = new Size(165, 54);
            DescTB.TabIndex = 1;
            // 
            // ReasonTB
            // 
            ReasonTB.Location = new Point(3, 150);
            ReasonTB.Multiline = true;
            ReasonTB.Name = "ReasonTB";
            ReasonTB.PlaceholderText = "Причина";
            ReasonTB.Size = new Size(165, 61);
            ReasonTB.TabIndex = 2;
            // 
            // PriceTB
            // 
            PriceTB.Location = new Point(3, 217);
            PriceTB.Name = "PriceTB";
            PriceTB.PlaceholderText = "Цена";
            PriceTB.Size = new Size(100, 23);
            PriceTB.TabIndex = 3;
            // 
            // ClientCB
            // 
            ClientCB.FormattingEnabled = true;
            ClientCB.Location = new Point(3, 246);
            ClientCB.Name = "ClientCB";
            ClientCB.Size = new Size(121, 23);
            ClientCB.TabIndex = 5;
            // 
            // DeviceCB
            // 
            DeviceCB.FormattingEnabled = true;
            DeviceCB.Location = new Point(3, 275);
            DeviceCB.Name = "DeviceCB";
            DeviceCB.Size = new Size(121, 23);
            DeviceCB.TabIndex = 6;
            // 
            // EmployeeCB
            // 
            EmployeeCB.FormattingEnabled = true;
            EmployeeCB.Location = new Point(3, 304);
            EmployeeCB.Name = "EmployeeCB";
            EmployeeCB.Size = new Size(121, 23);
            EmployeeCB.TabIndex = 7;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(136, 409);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // IdTB
            // 
            IdTB.Location = new Point(3, 3);
            IdTB.Name = "IdTB";
            IdTB.ReadOnly = true;
            IdTB.Size = new Size(100, 23);
            IdTB.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(IdTB);
            flowLayoutPanel1.Controls.Add(PriorityCB);
            flowLayoutPanel1.Controls.Add(TypeCB);
            flowLayoutPanel1.Controls.Add(DescTB);
            flowLayoutPanel1.Controls.Add(ReasonTB);
            flowLayoutPanel1.Controls.Add(PriceTB);
            flowLayoutPanel1.Controls.Add(ClientCB);
            flowLayoutPanel1.Controls.Add(DeviceCB);
            flowLayoutPanel1.Controls.Add(EmployeeCB);
            flowLayoutPanel1.Controls.Add(StatusCB);
            flowLayoutPanel1.Location = new Point(77, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 382);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // PriorityCB
            // 
            PriorityCB.FormattingEnabled = true;
            PriorityCB.Items.AddRange(new object[] { "нет", "низкий", "ниже среднего", "средний", "выше среднего", "высокий" });
            PriorityCB.Location = new Point(3, 32);
            PriorityCB.Name = "PriorityCB";
            PriorityCB.Size = new Size(121, 23);
            PriorityCB.TabIndex = 4;
            // 
            // TypeCB
            // 
            TypeCB.FormattingEnabled = true;
            TypeCB.Items.AddRange(new object[] { "Средняя поломка", "Малая поломка", "Потеря работоспособности", "Крупная поломка", "Индивидуальное" });
            TypeCB.Location = new Point(3, 61);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new Size(121, 23);
            TypeCB.TabIndex = 10;
            // 
            // StatusCB
            // 
            StatusCB.FormattingEnabled = true;
            StatusCB.Location = new Point(3, 333);
            StatusCB.Name = "StatusCB";
            StatusCB.Size = new Size(121, 23);
            StatusCB.TabIndex = 11;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 489);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SaveBtn);
            Name = "CreateForm";
            Text = "CreateForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox DescTB;
        private TextBox ReasonTB;
        private TextBox PriceTB;
        private ComboBox ClientCB;
        private ComboBox DeviceCB;
        private ComboBox EmployeeCB;
        private Button SaveBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        public TextBox IdTB;
        private ComboBox TypeCB;
        private ComboBox StatusCB;
        private ComboBox PriorityCB;
    }
}