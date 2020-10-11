using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

namespace Aquarium
{
    public partial class Form2 : Form
	{
		private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["aquarium"].ConnectionString);
		private List<Fish>
			database = new List<Fish>(),
			aquarium = new List<Fish>();
		private Random random = new Random();
		public Form2()
		{
			InitializeComponent();
			try
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand("SELECT [Name], [MaxVelocity] FROM [Fish];", connection))
				{
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						Fish fish = new Fish(random, reader[0] as string, (int)reader[1]);
						database.Add(fish);
						databaseComboBox.Items.Add(fish);
					}
				}
			}
			catch
			{
				using (SqlCommand command = new SqlCommand(
					"CREATE TABLE [Fish] ([Id] INT IDENTITY PRIMARY KEY, [Name] NVARCHAR(64) NOT NULL UNIQUE CHECK ([Name] <> ''), [MaxVelocity] INT NOT NULL CHECK ([MaxVelocity] BETWEEN 1 AND 7));",
					connection))
				{
					command.ExecuteNonQuery();
				}
			}
			finally
			{
				connection.Close();
			}
		}
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			(comboBox == databaseComboBox ? removeDatabaseButton : removeAquariumButton).Enabled = comboBox.SelectedIndex != -1;
			if (comboBox.SelectedIndex != -1)
			{
				Fish fish = (comboBox == databaseComboBox ? database : aquarium)[comboBox.SelectedIndex];
				nameTextBox.Text = fish.Name;
				speedNumericUpDown.Value = fish.MaxVelocity;
			}
		}
        private void removeButton_Click(object sender, EventArgs e)
        {
			if (sender == removeAquariumButton)
            {
				aquarium.RemoveAt(aquariumComboBox.SelectedIndex);
				aquariumComboBox.Items.RemoveAt(aquariumComboBox.SelectedIndex);
				removeAquariumButton.Enabled = false;
            }
			else
            {
				try
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand($"DELETE FROM [Fish] WHERE [Name] = @p1;", connection))
					{
						command.Parameters.Add("@p1", SqlDbType.NVarChar).Value = database[databaseComboBox.SelectedIndex].Name;
						command.ExecuteNonQuery();
						database.RemoveAt(databaseComboBox.SelectedIndex);
						databaseComboBox.Items.RemoveAt(databaseComboBox.SelectedIndex);
						removeDatabaseButton.Enabled = false;
					}
				}
				finally
				{
					connection.Close();
				}
			}
        }
		private void addButton_Click(object sender, EventArgs e)
		{
			Fish fish = new Fish(random, nameTextBox.Text, (int)speedNumericUpDown.Value);
			if (sender == addAquariumButton)
			{
				aquarium.Add(fish);
				aquariumComboBox.Items.Add(fish);
			}
			else
			{
				try
				{
					connection.Open();
					using (SqlCommand command = new SqlCommand("INSERT INTO [Fish] ([Name], [MaxVelocity]) VALUES (@p1, @p2);", connection))
					{
						command.Parameters.Add("@p1", SqlDbType.NVarChar).Value = nameTextBox.Text;
						command.Parameters.Add("@p2", SqlDbType.Int).Value = speedNumericUpDown.Value;
						command.ExecuteNonQuery();
					}
					database.Add(fish);
					databaseComboBox.Items.Add(fish);
				}
				catch
				{
					MessageBox.Show("Could not add this fish\n(maybe the name is empty or not unique)");
				}
				finally
				{
					connection.Close();
				}
			}
		}
        private void showButton_Click(object sender, EventArgs e)
        {
			List<Fish> fish = new List<Fish>();
			foreach (Fish f in aquarium)
				fish.Add(new Fish(random, f.Name, f.MaxVelocity));

			Form1 form1 = new Form1(random, fish);
			form1.ShowDialog();
        }
	}
}
