namespace To_Do_list
{
    partial class Form1
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
            label1 = new Label();
            txtTask = new TextBox();
            btnAdd = new Button();
            lstTasks = new ListBox();
            btnDelete = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Add new task";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(31, 64);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(333, 27);
            txtTask.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(418, 65);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(31, 150);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(497, 144);
            lstTasks.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(57, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Remove Selected";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(294, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save List";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(lstTasks);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTask;
        private Button btnAdd;
        private ListBox lstTasks;
        private Button btnDelete;
        private Button btnSave;
    }
}
