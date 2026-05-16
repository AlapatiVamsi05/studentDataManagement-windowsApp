using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbops_sql
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
        
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void stuData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) return;
            try
            {
                DataGridViewRow row = stuData.Rows[e.RowIndex];
                stuIdTxt.Text = row.Cells["sid"].Value?.ToString() ?? string.Empty;
                nameTxt.Text = row.Cells["name"].Value?.ToString() ?? string.Empty;
                emailTxt.Text = row.Cells["email"].Value?.ToString() ?? string.Empty;
                mobileTxt.Text = row.Cells["mobile"].Value?.ToString() ?? string.Empty;
            }
            catch
            {
                
                var row = stuData.Rows[e.RowIndex];
                if (row.Cells.Count >= 4)
                {
                    stuIdTxt.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                    nameTxt.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                    emailTxt.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                    mobileTxt.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERT

            if (string.IsNullOrWhiteSpace(stuIdTxt.Text) || string.IsNullOrWhiteSpace(nameTxt.Text)
                || string.IsNullOrWhiteSpace(emailTxt.Text) || string.IsNullOrWhiteSpace(mobileTxt.Text))
            {
                MessageBox.Show("Please fill all fields before adding a record.");
                return;
            }

            try
            {
                db.openConnection();

                using (MySqlCommand chk = new MySqlCommand("SELECT COUNT(*) FROM student WHERE sid = @sid", db.connection))
                {
                    chk.Parameters.AddWithValue("@sid", stuIdTxt.Text.Trim());
                    Int32 cnt = Convert.ToInt32(chk.ExecuteScalar());
                    if (cnt > 0)
                    {
                        MessageBox.Show("Record with this Student ID already exists.");
                        return;
                    }
                }

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO student (sid, `name`, email, mobile) VALUES (@sid, @name, @email, @mobile)", db.connection))
                {
                    cmd.Parameters.AddWithValue("@sid", stuIdTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", nameTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", emailTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@mobile", mobileTxt.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Record added successfully.");
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add record.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting the record: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //UPDATE
            if (string.IsNullOrWhiteSpace(stuIdTxt.Text))
            {
                MessageBox.Show("Please enter Student ID to update.");
                return;
            }

            try
            {
                db.openConnection();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE student SET `name` = @name, email = @email, mobile = @mobile WHERE sid = @sid", db.connection))
                {
                    cmd.Parameters.AddWithValue("@sid", stuIdTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", nameTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", emailTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@mobile", mobileTxt.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Record updated successfully.");
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Student ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating the record: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DELETE
            if (string.IsNullOrWhiteSpace(stuIdTxt.Text))
            {
                MessageBox.Show("Please enter Student ID to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                db.openConnection();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE sid = @sid", db.connection))
                {
                    cmd.Parameters.AddWithValue("@sid", stuIdTxt.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Student ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting the record: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void LoadData()
        {
            try
            {
                db.openConnection();
                using (MySqlCommand cmd = new MySqlCommand("SELECT sid, `name`, email, mobile FROM student", db.connection))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        stuData.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void ClearForm()
        {
            stuIdTxt.Text = string.Empty;
            nameTxt.Text = string.Empty;
            emailTxt.Text = string.Empty;
            mobileTxt.Text = string.Empty;
        }
    }
}
