namespace arkusz_inf_04_2023
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
            groupBox1 = new GroupBox();
            stanowisko_comboBox = new ComboBox();
            nazwisko_textbox = new TextBox();
            imie_textbox = new TextBox();
            Stanowisko = new Label();
            nazwisko = new Label();
            Imie = new Label();
            groupBox2 = new GroupBox();
            genhaslo_button = new Button();
            ileznakow_textBox = new TextBox();
            znaki_specjalne_checkBox = new CheckBox();
            cyfry_checkBox = new CheckBox();
            litery_checkBox = new CheckBox();
            znaki = new Label();
            zatwierdz_button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stanowisko_comboBox);
            groupBox1.Controls.Add(nazwisko_textbox);
            groupBox1.Controls.Add(imie_textbox);
            groupBox1.Controls.Add(Stanowisko);
            groupBox1.Controls.Add(nazwisko);
            groupBox1.Controls.Add(Imie);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(71, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            // 
            // stanowisko_comboBox
            // 
            stanowisko_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stanowisko_comboBox.FormattingEnabled = true;
            stanowisko_comboBox.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            stanowisko_comboBox.Location = new Point(136, 149);
            stanowisko_comboBox.Name = "stanowisko_comboBox";
            stanowisko_comboBox.Size = new Size(148, 23);
            stanowisko_comboBox.TabIndex = 5;
            // 
            // nazwisko_textbox
            // 
            nazwisko_textbox.Location = new Point(136, 94);
            nazwisko_textbox.Name = "nazwisko_textbox";
            nazwisko_textbox.Size = new Size(148, 23);
            nazwisko_textbox.TabIndex = 4;
            // 
            // imie_textbox
            // 
            imie_textbox.Location = new Point(136, 51);
            imie_textbox.Name = "imie_textbox";
            imie_textbox.Size = new Size(148, 23);
            imie_textbox.TabIndex = 3;
            // 
            // Stanowisko
            // 
            Stanowisko.AutoSize = true;
            Stanowisko.Location = new Point(27, 152);
            Stanowisko.Name = "Stanowisko";
            Stanowisko.Size = new Size(67, 15);
            Stanowisko.TabIndex = 2;
            Stanowisko.Text = "Stanowisko";
            // 
            // nazwisko
            // 
            nazwisko.AutoSize = true;
            nazwisko.Location = new Point(27, 97);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(57, 15);
            nazwisko.TabIndex = 1;
            nazwisko.Text = "Nazwisko";
            // 
            // Imie
            // 
            Imie.AutoSize = true;
            Imie.Location = new Point(27, 47);
            Imie.Name = "Imie";
            Imie.Size = new Size(30, 15);
            Imie.TabIndex = 0;
            Imie.Text = "Imię";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(genhaslo_button);
            groupBox2.Controls.Add(ileznakow_textBox);
            groupBox2.Controls.Add(znaki_specjalne_checkBox);
            groupBox2.Controls.Add(cyfry_checkBox);
            groupBox2.Controls.Add(litery_checkBox);
            groupBox2.Controls.Add(znaki);
            groupBox2.Location = new Point(460, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 237);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // genhaslo_button
            // 
            genhaslo_button.BackColor = Color.SteelBlue;
            genhaslo_button.ForeColor = Color.White;
            genhaslo_button.Location = new Point(112, 184);
            genhaslo_button.Name = "genhaslo_button";
            genhaslo_button.Size = new Size(97, 23);
            genhaslo_button.TabIndex = 5;
            genhaslo_button.Text = "Generuj hasło";
            genhaslo_button.UseVisualStyleBackColor = false;
            genhaslo_button.Click += genhaslo_button_Click;
            // 
            // ileznakow_textBox
            // 
            ileznakow_textBox.Location = new Point(132, 33);
            ileznakow_textBox.Name = "ileznakow_textBox";
            ileznakow_textBox.Size = new Size(148, 23);
            ileznakow_textBox.TabIndex = 4;
            // 
            // znaki_specjalne_checkBox
            // 
            znaki_specjalne_checkBox.AutoSize = true;
            znaki_specjalne_checkBox.Location = new Point(48, 148);
            znaki_specjalne_checkBox.Name = "znaki_specjalne_checkBox";
            znaki_specjalne_checkBox.Size = new Size(107, 19);
            znaki_specjalne_checkBox.TabIndex = 3;
            znaki_specjalne_checkBox.Text = "Znaki specjalne";
            znaki_specjalne_checkBox.UseVisualStyleBackColor = true;
            // 
            // cyfry_checkBox
            // 
            cyfry_checkBox.AutoSize = true;
            cyfry_checkBox.Location = new Point(48, 111);
            cyfry_checkBox.Name = "cyfry_checkBox";
            cyfry_checkBox.Size = new Size(54, 19);
            cyfry_checkBox.TabIndex = 2;
            cyfry_checkBox.Text = "Cyfry";
            cyfry_checkBox.UseVisualStyleBackColor = true;
            // 
            // litery_checkBox
            // 
            litery_checkBox.AutoSize = true;
            litery_checkBox.Checked = true;
            litery_checkBox.CheckState = CheckState.Checked;
            litery_checkBox.Location = new Point(48, 73);
            litery_checkBox.Name = "litery_checkBox";
            litery_checkBox.Size = new Size(123, 19);
            litery_checkBox.TabIndex = 1;
            litery_checkBox.Text = "Małe i wielkie ltery";
            litery_checkBox.UseVisualStyleBackColor = true;
            // 
            // znaki
            // 
            znaki.AutoSize = true;
            znaki.Location = new Point(48, 36);
            znaki.Name = "znaki";
            znaki.Size = new Size(67, 15);
            znaki.TabIndex = 0;
            znaki.Text = "Ile znaków?";
            // 
            // zatwierdz_button
            // 
            zatwierdz_button.BackColor = Color.SteelBlue;
            zatwierdz_button.ForeColor = Color.White;
            zatwierdz_button.Location = new Point(256, 372);
            zatwierdz_button.Name = "zatwierdz_button";
            zatwierdz_button.Size = new Size(335, 33);
            zatwierdz_button.TabIndex = 6;
            zatwierdz_button.Text = "Zatwierdź";
            zatwierdz_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(zatwierdz_button);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj pracownika";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox nazwisko_textbox;
        private TextBox imie_textbox;
        private Label Stanowisko;
        private Label nazwisko;
        private Label Imie;
        private ComboBox stanowisko_comboBox;
        private Label znaki;
        private Button genhaslo_button;
        private TextBox ileznakow_textBox;
        private CheckBox znaki_specjalne_checkBox;
        private CheckBox cyfry_checkBox;
        private CheckBox litery_checkBox;
        private Button zatwierdz_button;
    }
}