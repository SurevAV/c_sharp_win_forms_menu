
namespace MenuHR
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.РасчетнаяЗарплата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CalendarChange = new System.Windows.Forms.DateTimePicker();
            this.NewRow = new System.Windows.Forms.Button();
            this.DelRow = new System.Windows.Forms.Button();
            this.InputMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InputUnits = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InputManager = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputType = new System.Windows.Forms.ComboBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputCalendar = new System.Windows.Forms.DateTimePicker();
            this.Update = new System.Windows.Forms.Button();
            this.ChangeRow = new System.Windows.Forms.Button();
            this.MoneyChange = new System.Windows.Forms.Button();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вступилВДолжностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.начальникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.подчиненныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.вступилВДолжностьDataGridViewTextBoxColumn,
            this.начальникDataGridViewTextBoxColumn,
            this.подчиненныеDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn,
            this.РасчетнаяЗарплата});
            this.dataGridView.DataSource = this.workersBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(752, 525);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // РасчетнаяЗарплата
            // 
            this.РасчетнаяЗарплата.DataPropertyName = "РасчетнаяЗарплата";
            this.РасчетнаяЗарплата.HeaderText = "РасчетнаяЗарплата";
            this.РасчетнаяЗарплата.Name = "РасчетнаяЗарплата";
            this.РасчетнаяЗарплата.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 531);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel2.Controls.Add(this.CalendarChange, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.NewRow, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.DelRow, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.InputMoney, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.InputUnits, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.InputManager, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.InputType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.InputName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.InputCalendar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Update, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.ChangeRow, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.MoneyChange, 0, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(761, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 525);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // CalendarChange
            // 
            this.CalendarChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarChange.Location = new System.Drawing.Point(93, 501);
            this.CalendarChange.Name = "CalendarChange";
            this.CalendarChange.Size = new System.Drawing.Size(131, 20);
            this.CalendarChange.TabIndex = 29;
            // 
            // NewRow
            // 
            this.NewRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewRow.Location = new System.Drawing.Point(93, 442);
            this.NewRow.Name = "NewRow";
            this.NewRow.Size = new System.Drawing.Size(131, 24);
            this.NewRow.TabIndex = 24;
            this.NewRow.Text = "Добавить";
            this.NewRow.UseVisualStyleBackColor = true;
            this.NewRow.Click += new System.EventHandler(this.NewRow_Click);
            // 
            // DelRow
            // 
            this.DelRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelRow.Location = new System.Drawing.Point(3, 442);
            this.DelRow.Name = "DelRow";
            this.DelRow.Size = new System.Drawing.Size(84, 24);
            this.DelRow.TabIndex = 23;
            this.DelRow.Text = "Удалить";
            this.DelRow.UseVisualStyleBackColor = true;
            this.DelRow.Click += new System.EventHandler(this.DelRow_Click);
            // 
            // InputMoney
            // 
            this.InputMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputMoney.Location = new System.Drawing.Point(93, 413);
            this.InputMoney.Multiline = true;
            this.InputMoney.Name = "InputMoney";
            this.InputMoney.Size = new System.Drawing.Size(131, 23);
            this.InputMoney.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Зарплата";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputUnits
            // 
            this.InputUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputUnits.Location = new System.Drawing.Point(93, 117);
            this.InputUnits.Multiline = true;
            this.InputUnits.Name = "InputUnits";
            this.InputUnits.Size = new System.Drawing.Size(131, 290);
            this.InputUnits.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 296);
            this.label6.TabIndex = 19;
            this.label6.Text = "Подчиненные";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputManager
            // 
            this.InputManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputManager.Location = new System.Drawing.Point(93, 86);
            this.InputManager.Multiline = true;
            this.InputManager.Name = "InputManager";
            this.InputManager.Size = new System.Drawing.Size(131, 25);
            this.InputManager.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Начальник";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип зарплаты";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата приема";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputType
            // 
            this.InputType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputType.FormattingEnabled = true;
            this.InputType.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Salesman"});
            this.InputType.Location = new System.Drawing.Point(93, 33);
            this.InputType.Name = "InputType";
            this.InputType.Size = new System.Drawing.Size(131, 21);
            this.InputType.TabIndex = 8;
            this.InputType.SelectedIndexChanged += new System.EventHandler(this.InputType_SelectedIndexChanged);
            // 
            // InputName
            // 
            this.InputName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputName.Location = new System.Drawing.Point(93, 3);
            this.InputName.Multiline = true;
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(131, 24);
            this.InputName.TabIndex = 9;
            // 
            // InputCalendar
            // 
            this.InputCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputCalendar.Location = new System.Drawing.Point(93, 60);
            this.InputCalendar.Name = "InputCalendar";
            this.InputCalendar.Size = new System.Drawing.Size(131, 20);
            this.InputCalendar.TabIndex = 25;
            this.InputCalendar.ValueChanged += new System.EventHandler(this.InputCalendar_ValueChanged);
            // 
            // Update
            // 
            this.Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update.Location = new System.Drawing.Point(3, 472);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(84, 23);
            this.Update.TabIndex = 26;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ChangeRow
            // 
            this.ChangeRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeRow.Location = new System.Drawing.Point(93, 472);
            this.ChangeRow.Name = "ChangeRow";
            this.ChangeRow.Size = new System.Drawing.Size(131, 23);
            this.ChangeRow.TabIndex = 27;
            this.ChangeRow.Text = "Изменить";
            this.ChangeRow.UseVisualStyleBackColor = true;
            this.ChangeRow.Click += new System.EventHandler(this.ChangeRow_Click);
            // 
            // MoneyChange
            // 
            this.MoneyChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoneyChange.Location = new System.Drawing.Point(3, 501);
            this.MoneyChange.Name = "MoneyChange";
            this.MoneyChange.Size = new System.Drawing.Size(84, 21);
            this.MoneyChange.TabIndex = 28;
            this.MoneyChange.Text = "Расчитать";
            this.MoneyChange.UseVisualStyleBackColor = true;
            this.MoneyChange.Click += new System.EventHandler(this.MoneyChange_Click);
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вступилВДолжностьDataGridViewTextBoxColumn
            // 
            this.вступилВДолжностьDataGridViewTextBoxColumn.DataPropertyName = "ВступилВДолжность";
            this.вступилВДолжностьDataGridViewTextBoxColumn.HeaderText = "ВступилВДолжность";
            this.вступилВДолжностьDataGridViewTextBoxColumn.Name = "вступилВДолжностьDataGridViewTextBoxColumn";
            this.вступилВДолжностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // начальникDataGridViewTextBoxColumn
            // 
            this.начальникDataGridViewTextBoxColumn.DataPropertyName = "Начальник";
            this.начальникDataGridViewTextBoxColumn.HeaderText = "Начальник";
            this.начальникDataGridViewTextBoxColumn.Name = "начальникDataGridViewTextBoxColumn";
            this.начальникDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // подчиненныеDataGridViewTextBoxColumn
            // 
            this.подчиненныеDataGridViewTextBoxColumn.DataPropertyName = "Подчиненные";
            this.подчиненныеDataGridViewTextBoxColumn.HeaderText = "Подчиненные";
            this.подчиненныеDataGridViewTextBoxColumn.Name = "подчиненныеDataGridViewTextBoxColumn";
            this.подчиненныеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            this.зарплатаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataSource = typeof(MenuHR.Workers);
            this.workersBindingSource.CurrentChanged += new System.EventHandler(this.workersBindingSource_CurrentChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InputType;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Button NewRow;
        private System.Windows.Forms.Button DelRow;
        private System.Windows.Forms.TextBox InputMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InputUnits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputManager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker InputCalendar;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button ChangeRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вступилВДолжностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn начальникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn подчиненныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn РасчетнаяЗарплата;
        private System.Windows.Forms.Button MoneyChange;
        private System.Windows.Forms.DateTimePicker CalendarChange;
    }
}

