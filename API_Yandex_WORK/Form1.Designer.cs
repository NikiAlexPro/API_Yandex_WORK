namespace API_Yandex_WORK
{
    partial class Form1
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
            this.button_search = new System.Windows.Forms.Button();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowserNow = new System.Windows.Forms.WebBrowser();
            this.labelNameCity = new System.Windows.Forms.Label();
            this.labelWindDirection = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelCloudness = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelPressureMm = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.groupBoxTommorow = new System.Windows.Forms.GroupBox();
            this.webBrowserTommorow = new System.Windows.Forms.WebBrowser();
            this.labelTemperatureTomw = new System.Windows.Forms.Label();
            this.labelWindSpeedTomw = new System.Windows.Forms.Label();
            this.labelPressureMmTomw = new System.Windows.Forms.Label();
            this.labelConditionTomw = new System.Windows.Forms.Label();
            this.labelWindDirectionTomw = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.webBrowserAfTommorow = new System.Windows.Forms.WebBrowser();
            this.labelTemperatureAfTomw = new System.Windows.Forms.Label();
            this.labelWindSpeedAfTomw = new System.Windows.Forms.Label();
            this.labelWindDirectionAfTomw = new System.Windows.Forms.Label();
            this.labelPressureMmAfTomw = new System.Windows.Forms.Label();
            this.labelConditionAfTomw = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxTommorow.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(244, 302);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(85, 29);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperature.Location = new System.Drawing.Point(215, 30);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(87, 15);
            this.labelTemperature.TabIndex = 3;
            this.labelTemperature.Text = "Температура: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.webBrowserNow);
            this.groupBox1.Controls.Add(this.labelNameCity);
            this.groupBox1.Controls.Add(this.labelWindDirection);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.labelCondition);
            this.groupBox1.Controls.Add(this.labelCloudness);
            this.groupBox1.Controls.Add(this.labelHumidity);
            this.groupBox1.Controls.Add(this.labelPressureMm);
            this.groupBox1.Controls.Add(this.labelWindSpeed);
            this.groupBox1.Controls.Add(this.labelTemperature);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 358);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Погода на сегодня";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // webBrowserNow
            // 
            this.webBrowserNow.Location = new System.Drawing.Point(6, 25);
            this.webBrowserNow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNow.Name = "webBrowserNow";
            this.webBrowserNow.ScrollBarsEnabled = false;
            this.webBrowserNow.Size = new System.Drawing.Size(194, 140);
            this.webBrowserNow.TabIndex = 6;
            // 
            // labelNameCity
            // 
            this.labelNameCity.AutoSize = true;
            this.labelNameCity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCity.Location = new System.Drawing.Point(6, 268);
            this.labelNameCity.Name = "labelNameCity";
            this.labelNameCity.Size = new System.Drawing.Size(111, 15);
            this.labelNameCity.TabIndex = 12;
            this.labelNameCity.Text = "Местоположение: ";
            // 
            // labelWindDirection
            // 
            this.labelWindDirection.AutoSize = true;
            this.labelWindDirection.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindDirection.Location = new System.Drawing.Point(214, 93);
            this.labelWindDirection.Name = "labelWindDirection";
            this.labelWindDirection.Size = new System.Drawing.Size(119, 15);
            this.labelWindDirection.TabIndex = 11;
            this.labelWindDirection.Text = "Направление ветра: ";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.Location = new System.Drawing.Point(215, 155);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(123, 15);
            this.labelCondition.TabIndex = 10;
            this.labelCondition.Text = "Погодное описание: ";
            // 
            // labelCloudness
            // 
            this.labelCloudness.AutoSize = true;
            this.labelCloudness.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCloudness.Location = new System.Drawing.Point(6, 198);
            this.labelCloudness.Name = "labelCloudness";
            this.labelCloudness.Size = new System.Drawing.Size(78, 15);
            this.labelCloudness.TabIndex = 9;
            this.labelCloudness.Text = "Облачность: ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHumidity.Location = new System.Drawing.Point(6, 233);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(118, 15);
            this.labelHumidity.TabIndex = 6;
            this.labelHumidity.Text = "Влажность воздуха: ";
            // 
            // labelPressureMm
            // 
            this.labelPressureMm.AutoSize = true;
            this.labelPressureMm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPressureMm.Location = new System.Drawing.Point(215, 124);
            this.labelPressureMm.Name = "labelPressureMm";
            this.labelPressureMm.Size = new System.Drawing.Size(66, 15);
            this.labelPressureMm.TabIndex = 5;
            this.labelPressureMm.Text = "Давление: ";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindSpeed.Location = new System.Drawing.Point(215, 60);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(97, 15);
            this.labelWindSpeed.TabIndex = 4;
            this.labelWindSpeed.Text = "Скорость ветра: ";
            // 
            // groupBoxTommorow
            // 
            this.groupBoxTommorow.Controls.Add(this.labelWindDirectionTomw);
            this.groupBoxTommorow.Controls.Add(this.labelConditionTomw);
            this.groupBoxTommorow.Controls.Add(this.labelPressureMmTomw);
            this.groupBoxTommorow.Controls.Add(this.labelWindSpeedTomw);
            this.groupBoxTommorow.Controls.Add(this.labelTemperatureTomw);
            this.groupBoxTommorow.Controls.Add(this.webBrowserTommorow);
            this.groupBoxTommorow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTommorow.Location = new System.Drawing.Point(498, 12);
            this.groupBoxTommorow.Name = "groupBoxTommorow";
            this.groupBoxTommorow.Size = new System.Drawing.Size(503, 176);
            this.groupBoxTommorow.TabIndex = 5;
            this.groupBoxTommorow.TabStop = false;
            this.groupBoxTommorow.Text = "Погода на завтра";
            // 
            // webBrowserTommorow
            // 
            this.webBrowserTommorow.Location = new System.Drawing.Point(6, 25);
            this.webBrowserTommorow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTommorow.Name = "webBrowserTommorow";
            this.webBrowserTommorow.ScrollBarsEnabled = false;
            this.webBrowserTommorow.Size = new System.Drawing.Size(194, 140);
            this.webBrowserTommorow.TabIndex = 6;
            // 
            // labelTemperatureTomw
            // 
            this.labelTemperatureTomw.AutoSize = true;
            this.labelTemperatureTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperatureTomw.Location = new System.Drawing.Point(223, 35);
            this.labelTemperatureTomw.Name = "labelTemperatureTomw";
            this.labelTemperatureTomw.Size = new System.Drawing.Size(87, 15);
            this.labelTemperatureTomw.TabIndex = 7;
            this.labelTemperatureTomw.Text = "Температура: ";
            // 
            // labelWindSpeedTomw
            // 
            this.labelWindSpeedTomw.AutoSize = true;
            this.labelWindSpeedTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindSpeedTomw.Location = new System.Drawing.Point(223, 63);
            this.labelWindSpeedTomw.Name = "labelWindSpeedTomw";
            this.labelWindSpeedTomw.Size = new System.Drawing.Size(97, 15);
            this.labelWindSpeedTomw.TabIndex = 8;
            this.labelWindSpeedTomw.Text = "Скорость ветра: ";
            // 
            // labelPressureMmTomw
            // 
            this.labelPressureMmTomw.AutoSize = true;
            this.labelPressureMmTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPressureMmTomw.Location = new System.Drawing.Point(223, 122);
            this.labelPressureMmTomw.Name = "labelPressureMmTomw";
            this.labelPressureMmTomw.Size = new System.Drawing.Size(66, 15);
            this.labelPressureMmTomw.TabIndex = 9;
            this.labelPressureMmTomw.Text = "Давление: ";
            // 
            // labelConditionTomw
            // 
            this.labelConditionTomw.AutoSize = true;
            this.labelConditionTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConditionTomw.Location = new System.Drawing.Point(223, 150);
            this.labelConditionTomw.Name = "labelConditionTomw";
            this.labelConditionTomw.Size = new System.Drawing.Size(123, 15);
            this.labelConditionTomw.TabIndex = 10;
            this.labelConditionTomw.Text = "Погодное описание: ";
            // 
            // labelWindDirectionTomw
            // 
            this.labelWindDirectionTomw.AutoSize = true;
            this.labelWindDirectionTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindDirectionTomw.Location = new System.Drawing.Point(223, 93);
            this.labelWindDirectionTomw.Name = "labelWindDirectionTomw";
            this.labelWindDirectionTomw.Size = new System.Drawing.Size(119, 15);
            this.labelWindDirectionTomw.TabIndex = 11;
            this.labelWindDirectionTomw.Text = "Направление ветра: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelConditionAfTomw);
            this.groupBox2.Controls.Add(this.labelPressureMmAfTomw);
            this.groupBox2.Controls.Add(this.labelWindDirectionAfTomw);
            this.groupBox2.Controls.Add(this.labelWindSpeedAfTomw);
            this.groupBox2.Controls.Add(this.labelTemperatureAfTomw);
            this.groupBox2.Controls.Add(this.webBrowserAfTommorow);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(498, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 176);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Погода на послезавтра";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 302);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 29);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // webBrowserAfTommorow
            // 
            this.webBrowserAfTommorow.Location = new System.Drawing.Point(6, 19);
            this.webBrowserAfTommorow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserAfTommorow.Name = "webBrowserAfTommorow";
            this.webBrowserAfTommorow.ScrollBarsEnabled = false;
            this.webBrowserAfTommorow.Size = new System.Drawing.Size(194, 140);
            this.webBrowserAfTommorow.TabIndex = 7;
            // 
            // labelTemperatureAfTomw
            // 
            this.labelTemperatureAfTomw.AutoSize = true;
            this.labelTemperatureAfTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemperatureAfTomw.Location = new System.Drawing.Point(226, 29);
            this.labelTemperatureAfTomw.Name = "labelTemperatureAfTomw";
            this.labelTemperatureAfTomw.Size = new System.Drawing.Size(87, 15);
            this.labelTemperatureAfTomw.TabIndex = 8;
            this.labelTemperatureAfTomw.Text = "Температура: ";
            // 
            // labelWindSpeedAfTomw
            // 
            this.labelWindSpeedAfTomw.AutoSize = true;
            this.labelWindSpeedAfTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindSpeedAfTomw.Location = new System.Drawing.Point(226, 57);
            this.labelWindSpeedAfTomw.Name = "labelWindSpeedAfTomw";
            this.labelWindSpeedAfTomw.Size = new System.Drawing.Size(97, 15);
            this.labelWindSpeedAfTomw.TabIndex = 9;
            this.labelWindSpeedAfTomw.Text = "Скорость ветра: ";
            // 
            // labelWindDirectionAfTomw
            // 
            this.labelWindDirectionAfTomw.AutoSize = true;
            this.labelWindDirectionAfTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindDirectionAfTomw.Location = new System.Drawing.Point(226, 85);
            this.labelWindDirectionAfTomw.Name = "labelWindDirectionAfTomw";
            this.labelWindDirectionAfTomw.Size = new System.Drawing.Size(119, 15);
            this.labelWindDirectionAfTomw.TabIndex = 10;
            this.labelWindDirectionAfTomw.Text = "Направление ветра: ";
            // 
            // labelPressureMmAfTomw
            // 
            this.labelPressureMmAfTomw.AutoSize = true;
            this.labelPressureMmAfTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPressureMmAfTomw.Location = new System.Drawing.Point(226, 115);
            this.labelPressureMmAfTomw.Name = "labelPressureMmAfTomw";
            this.labelPressureMmAfTomw.Size = new System.Drawing.Size(66, 15);
            this.labelPressureMmAfTomw.TabIndex = 11;
            this.labelPressureMmAfTomw.Text = "Давление: ";
            // 
            // labelConditionAfTomw
            // 
            this.labelConditionAfTomw.AutoSize = true;
            this.labelConditionAfTomw.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConditionAfTomw.Location = new System.Drawing.Point(226, 143);
            this.labelConditionAfTomw.Name = "labelConditionAfTomw";
            this.labelConditionAfTomw.Size = new System.Drawing.Size(123, 15);
            this.labelConditionAfTomw.TabIndex = 12;
            this.labelConditionAfTomw.Text = "Погодное описание: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxTommorow);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Яндекс.Погода";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTommorow.ResumeLayout(false);
            this.groupBoxTommorow.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWindDirection;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelCloudness;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelPressureMm;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelNameCity;
        private System.Windows.Forms.GroupBox groupBoxTommorow;
        private System.Windows.Forms.WebBrowser webBrowserNow;
        private System.Windows.Forms.WebBrowser webBrowserTommorow;
        private System.Windows.Forms.Label labelWindDirectionTomw;
        private System.Windows.Forms.Label labelConditionTomw;
        private System.Windows.Forms.Label labelPressureMmTomw;
        private System.Windows.Forms.Label labelWindSpeedTomw;
        private System.Windows.Forms.Label labelTemperatureTomw;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowserAfTommorow;
        private System.Windows.Forms.Label labelConditionAfTomw;
        private System.Windows.Forms.Label labelPressureMmAfTomw;
        private System.Windows.Forms.Label labelWindDirectionAfTomw;
        private System.Windows.Forms.Label labelWindSpeedAfTomw;
        private System.Windows.Forms.Label labelTemperatureAfTomw;
    }
}

