namespace bhoomi_ma_am
{
    partial class registration
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
            name = new Label();
            password = new Label();
            branch = new Label();
            city = new Label();
            gender = new Label();
            submit = new Button();
            name_in = new TextBox();
            pass_in = new TextBox();
            branches = new ComboBox();
            cities = new ListBox();
            male_redio = new RadioButton();
            female_radio = new RadioButton();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(20, 21);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 0;
            name.Text = "Name";
            name.Click += label1_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(20, 54);
            password.Name = "password";
            password.Size = new Size(70, 20);
            password.TabIndex = 1;
            password.Text = "Password";
            password.Click += label2_Click;
            // 
            // branch
            // 
            branch.AutoSize = true;
            branch.Location = new Point(20, 89);
            branch.Name = "branch";
            branch.Size = new Size(54, 20);
            branch.TabIndex = 2;
            branch.Text = "Branch";
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(20, 123);
            city.Name = "city";
            city.Size = new Size(34, 20);
            city.TabIndex = 3;
            city.Text = "City";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(20, 244);
            gender.Name = "gender";
            gender.Size = new Size(57, 20);
            gender.TabIndex = 4;
            gender.Text = "Gender";
            // 
            // submit
            // 
            submit.Location = new Point(150, 314);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 5;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // name_in
            // 
            name_in.Location = new Point(109, 21);
            name_in.Name = "name_in";
            name_in.Size = new Size(228, 27);
            name_in.TabIndex = 6;
            name_in.TextChanged += name_in_TextChanged;
            // 
            // pass_in
            // 
            pass_in.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass_in.Location = new Point(109, 54);
            pass_in.Name = "pass_in";
            pass_in.PasswordChar = '*';
            pass_in.Size = new Size(228, 27);
            pass_in.TabIndex = 7;
            pass_in.TextChanged += pass_in_TextChanged;
            // 
            // branches
            // 
            branches.FormattingEnabled = true;
            branches.Items.AddRange(new object[] { "CE", "IT" });
            branches.Location = new Point(109, 89);
            branches.Name = "branches";
            branches.Size = new Size(228, 28);
            branches.TabIndex = 8;
            branches.SelectedIndexChanged += branches_SelectedIndexChanged;
            // 
            // cities
            // 
            cities.FormattingEnabled = true;
            cities.Items.AddRange(new object[] { "SURAT", "RAJOKT", "AHEMDABAD", "GIR SOMNATH", "JUNAGADH" });
            cities.Location = new Point(109, 123);
            cities.Name = "cities";
            cities.Size = new Size(228, 104);
            cities.TabIndex = 9;
            cities.SelectedIndexChanged += cities_SelectedIndexChanged;
            // 
            // male_redio
            // 
            male_redio.AutoSize = true;
            male_redio.Location = new Point(109, 244);
            male_redio.Name = "male_redio";
            male_redio.Size = new Size(63, 24);
            male_redio.TabIndex = 10;
            male_redio.TabStop = true;
            male_redio.Text = "Male";
            male_redio.UseVisualStyleBackColor = true;
            male_redio.CheckedChanged += male_redio_CheckedChanged;
            // 
            // female_radio
            // 
            female_radio.AutoSize = true;
            female_radio.Location = new Point(109, 274);
            female_radio.Name = "female_radio";
            female_radio.Size = new Size(78, 24);
            female_radio.TabIndex = 11;
            female_radio.TabStop = true;
            female_radio.Text = "Female";
            female_radio.UseVisualStyleBackColor = true;
            female_radio.CheckedChanged += female_radio_CheckedChanged;
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 374);
            Controls.Add(female_radio);
            Controls.Add(male_redio);
            Controls.Add(cities);
            Controls.Add(branches);
            Controls.Add(pass_in);
            Controls.Add(name_in);
            Controls.Add(submit);
            Controls.Add(gender);
            Controls.Add(city);
            Controls.Add(branch);
            Controls.Add(password);
            Controls.Add(name);
            Name = "registration";
            Text = "Registration";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label password;
        private Label branch;
        private Label city;
        private Label gender;
        private Button submit;
        private TextBox name_in;
        private TextBox pass_in;
        private ComboBox branches;
        private ListBox cities;
        private RadioButton male_redio;
        private RadioButton female_radio;
    }
}