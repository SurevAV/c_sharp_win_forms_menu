using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;


namespace MenuHR
{
    public partial class Menu : Form
    {
        public SQLiteConnection connection = new SQLiteConnection("Data Source = workers");
        public Menu()
        {     
            connection.Open();
            InitializeComponent();
        }

        private void rowsClear()
        {
            dataGridView.Rows.Clear();
            //dataGridView.Refresh();
            var cmd = new SQLiteCommand("SELECT * FROM workers", connection);
            SQLiteDataReader responce = cmd.ExecuteReader();

            while (responce.Read())
            {
               

                TimeSpan value = CalendarChange.Value.Subtract(responce.GetDateTime(2));
                double  money = 0;
                if (responce.GetString(1) == "Employee")
                {
                    money = responce.GetFloat(5) * (1 + 0.03 * Convert.ToDouble(Convert.ToInt32(value.TotalDays / 365)));
                    if (responce.GetFloat(5) * 1.3 < money)
                    {
                        money = responce.GetFloat(5) * 1.3;
                    }
                }

                if (responce.GetString(1) == "Manager")
                {
                    money = responce.GetFloat(5) * (1 + 0.05 * Convert.ToDouble(Convert.ToInt32(value.TotalDays / 365)));
                    if (responce.GetFloat(5) * 1.4 < money)
                    {
                        money = responce.GetFloat(5) * 1.3;
                    }
                }

                if (responce.GetString(1) == "Salesman")
                {
                    money = responce.GetFloat(5) * (1 + 0.01 * Convert.ToDouble(Convert.ToInt32(value.TotalDays / 365)));
                    if (responce.GetFloat(5) * 1.35 < money)
                    {
                        money = responce.GetFloat(5) * 1.3;
                    }
                }


                workersBindingSource.Add(new Workers()
                {
                    ФИО = responce.GetString(0),
                    ВступилВДолжность = responce.GetDateTime(2),
                    Зарплата = responce.GetFloat(5),
                    Начальник = responce.GetString(3),
                    Подчиненные = responce.GetString(4),
                    Тип = responce.GetString(1),
                    РасчетнаяЗарплата = money
                });
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            InputName.Text = dataGridView.Rows[row].Cells[0].Value.ToString();
            InputType.Text = dataGridView.Rows[row].Cells[1].Value.ToString();
            InputCalendar.Value = Convert.ToDateTime(dataGridView.Rows[row].Cells[2].Value.ToString());
            InputManager.Text = dataGridView.Rows[row].Cells[3].Value.ToString();
            InputUnits.Text = dataGridView.Rows[row].Cells[4].Value.ToString();
            InputMoney.Text = dataGridView.Rows[row].Cells[5].Value.ToString();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewRow_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText =
                        "INSERT INTO workers ([ФИО], [Тип], [ВступилВДолжность], [Начальник], [Подчиненные], [Зарплата]) " +
                        "VALUES (@column0, @column1, @column2, @column3, @column4, @column5);";
                    cmd.Parameters.AddWithValue("@column0", InputName.Text);
                    cmd.Parameters.AddWithValue("@column1", InputType.Text);
                    cmd.Parameters.AddWithValue("@column2", InputCalendar.Value);
                    cmd.Parameters.AddWithValue("@column3", InputManager.Text);
                    cmd.Parameters.AddWithValue("@column4", InputUnits.Text);
                    cmd.Parameters.AddWithValue("@column5", Convert.ToDouble(InputMoney.Text));
                    cmd.ExecuteNonQuery();
                    rowsClear();
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Не удалось добавить данные в базу, возможно данные внесены некоректно.", "Ошибка", MessageBoxButtons.OK);
            }
        }




        private void Update_Click(object sender, EventArgs e)
        {
            rowsClear();
        }

        private void InputCalendar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DelRow_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new SQLiteCommand("DELETE FROM workers WHERE ФИО='" + InputName.Text + "';", connection);
                cmd.ExecuteNonQuery();
                rowsClear();
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Не удалось удалить данные из базы, возможно данные внесены некоректно.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void ChangeRow_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        "update workers set ФИО = :ФИО, Тип = :Тип, ВступилВДолжность = :ВступилВДолжность, Начальник = :Начальник, Подчиненные = :Подчиненные, Зарплата = :Зарплата where ФИО = :ФИО";
                    command.Parameters.Add("ФИО", DbType.String).Value = InputName.Text;
                    command.Parameters.Add("Тип", DbType.String).Value = InputType.Text;
                    command.Parameters.Add("ВступилВДолжность", DbType.DateTime).Value = InputCalendar.Value;
                    command.Parameters.Add("Начальник", DbType.String).Value = InputManager.Text;
                    command.Parameters.Add("Подчиненные", DbType.String).Value = InputUnits.Text;
                    command.Parameters.Add("Зарплата", DbType.Double).Value = Convert.ToDouble(InputMoney.Text);
                    command.ExecuteNonQuery();
                    rowsClear();
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Не удалось изменить данные в базе, возможно данные внесены некоректно.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void InputType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoneyChange_Click(object sender, EventArgs e)
        {

        }

        private void workersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
