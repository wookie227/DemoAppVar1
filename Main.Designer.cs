namespace DemoAppVar1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataService = new DataGridView();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DataService).BeginInit();
            SuspendLayout();
            // 
            // DataService
            // 
            DataService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataService.Location = new Point(163, 82);
            DataService.Name = "DataService";
            DataService.Size = new Size(460, 267);
            DataService.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(239, 371);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(344, 371);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(91, 23);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Редактировать";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(468, 371);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(DataService);
            Name = "Main";
            Text = "Form1";
            FormClosed += Main_FormClosed;
            ((System.ComponentModel.ISupportInitialize)DataService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataService;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}
