
namespace RPO_lab_2
{
    partial class Search
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
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.departure_airport_textbox = new System.Windows.Forms.TextBox();
            this.arrival_airport_textbox = new System.Windows.Forms.TextBox();
            this.departure_date_textbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.booking = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureAirport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.check_button = new System.Windows.Forms.Button();
            this.seats_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F);
            this.back_button.Location = new System.Drawing.Point(15, 496);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(200, 50);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите необходимые данные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departure_airport_textbox
            // 
            this.departure_airport_textbox.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departure_airport_textbox.Location = new System.Drawing.Point(159, 77);
            this.departure_airport_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.departure_airport_textbox.Name = "departure_airport_textbox";
            this.departure_airport_textbox.Size = new System.Drawing.Size(525, 29);
            this.departure_airport_textbox.TabIndex = 3;
            this.departure_airport_textbox.Text = "Волгоград";
            // 
            // arrival_airport_textbox
            // 
            this.arrival_airport_textbox.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrival_airport_textbox.Location = new System.Drawing.Point(159, 117);
            this.arrival_airport_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.arrival_airport_textbox.Name = "arrival_airport_textbox";
            this.arrival_airport_textbox.Size = new System.Drawing.Size(525, 29);
            this.arrival_airport_textbox.TabIndex = 4;
            this.arrival_airport_textbox.Text = "Калининград";
            // 
            // departure_date_textbox
            // 
            this.departure_date_textbox.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departure_date_textbox.Location = new System.Drawing.Point(159, 157);
            this.departure_date_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.departure_date_textbox.Name = "departure_date_textbox";
            this.departure_date_textbox.Size = new System.Drawing.Size(524, 29);
            this.departure_date_textbox.TabIndex = 8;
            this.departure_date_textbox.Text = "10-01-2022";
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F);
            this.search_button.Location = new System.Drawing.Point(246, 192);
            this.search_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(200, 50);
            this.search_button.TabIndex = 9;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // booking
            // 
            this.booking.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F);
            this.booking.Location = new System.Drawing.Point(484, 496);
            this.booking.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.booking.Name = "booking";
            this.booking.Size = new System.Drawing.Size(200, 50);
            this.booking.TabIndex = 12;
            this.booking.Text = "Забронировать";
            this.booking.UseVisualStyleBackColor = true;
            this.booking.Click += new System.EventHandler(this.booking_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFlight,
            this.number,
            this.departureDate,
            this.arrivalDate,
            this.departureAirport,
            this.plane});
            this.dataGridView1.Location = new System.Drawing.Point(15, 316);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(502, 172);
            this.dataGridView1.TabIndex = 13;
            // 
            // idFlight
            // 
            this.idFlight.HeaderText = "idFlight";
            this.idFlight.MinimumWidth = 8;
            this.idFlight.Name = "idFlight";
            this.idFlight.ReadOnly = true;
            this.idFlight.Visible = false;
            this.idFlight.Width = 150;
            // 
            // number
            // 
            this.number.HeaderText = "Номер рейса";
            this.number.MinimumWidth = 8;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 150;
            // 
            // departureDate
            // 
            this.departureDate.HeaderText = "Дата вылета";
            this.departureDate.MinimumWidth = 8;
            this.departureDate.Name = "departureDate";
            this.departureDate.ReadOnly = true;
            this.departureDate.Width = 150;
            // 
            // arrivalDate
            // 
            this.arrivalDate.HeaderText = "Дата прилета";
            this.arrivalDate.MinimumWidth = 8;
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.ReadOnly = true;
            this.arrivalDate.Width = 150;
            // 
            // departureAirport
            // 
            this.departureAirport.HeaderText = "Аэропорт вылета";
            this.departureAirport.MinimumWidth = 8;
            this.departureAirport.Name = "departureAirport";
            this.departureAirport.ReadOnly = true;
            this.departureAirport.Width = 150;
            // 
            // plane
            // 
            this.plane.HeaderText = "Наименование самолёта";
            this.plane.MinimumWidth = 8;
            this.plane.Name = "plane";
            this.plane.ReadOnly = true;
            this.plane.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Город отправления";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(11, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Город прибытия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Дата отправления";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(246, 245);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 50);
            this.label10.TabIndex = 14;
            this.label10.Text = "Выберите рейс";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // check_button
            // 
            this.check_button.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_button.Location = new System.Drawing.Point(246, 552);
            this.check_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(200, 50);
            this.check_button.TabIndex = 15;
            this.check_button.Text = "Просмотреть купленные билеты";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // seats_listbox
            // 
            this.seats_listbox.FormattingEnabled = true;
            this.seats_listbox.ItemHeight = 21;
            this.seats_listbox.Location = new System.Drawing.Point(533, 316);
            this.seats_listbox.Name = "seats_listbox";
            this.seats_listbox.Size = new System.Drawing.Size(150, 172);
            this.seats_listbox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(533, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 50);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выберите место";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 614);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seats_listbox);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.booking);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.departure_date_textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arrival_airport_textbox);
            this.Controls.Add(this.departure_airport_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Search";
            this.Text = "Бронирование";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departure_airport_textbox;
        private System.Windows.Forms.TextBox arrival_airport_textbox;
        private System.Windows.Forms.TextBox departure_date_textbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button booking;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureAirport;
        private System.Windows.Forms.DataGridViewTextBoxColumn plane;
        private System.Windows.Forms.ListBox seats_listbox;
        private System.Windows.Forms.Label label2;
    }
}