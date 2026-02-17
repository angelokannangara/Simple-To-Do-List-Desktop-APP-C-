using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;


namespace To_Do_list
{
    public partial class Form1 : Form
    {
        string filePath = "tasks.txt";
        public Form1()
        {
            InitializeComponent();
            LoadTasksFromFile();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
                txtTask.Focus();
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstTasks.SelectedIndex != -1)
            {
                lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> tasks = new List<string>();
            foreach (var item in lstTasks.Items)
            {
                tasks.Add(item.ToString());

            }
            File.WriteAllLines(filePath, tasks);
            MessageBox.Show("Tasks saved successfully!");
        }
        private void LoadTasksFromFile()
        {
            if(File.Exists(filePath))
            {
                string[] loadedTasks = File.ReadAllLines(filePath);
                lstTasks.Items.AddRange(loadedTasks);
            }
        }
    }
}
