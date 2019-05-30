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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNameCity = new System.Windows.Forms.Label();
            this.labelWindDirection = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelCloudness = new System.Windows.Forms.Label();
            this.labelPrecStrength = new System.Windows.Forms.Label();
            this.labelPrecType = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelPressureMm = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.groupBoxTommorow = new System.Windows.Forms.GroupBox();
            this.webBrowserNow = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(256, 410);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(71, 20);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 410);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(217, 36);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(80, 13);
            this.labelTemperature.TabIndex = 3;
            this.labelTemperature.Text = "Температура: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowserNow);
            this.groupBox1.Controls.Add(this.labelNameCity);
            this.groupBox1.Controls.Add(this.labelWindDirection);
            this.groupBox1.Controls.Add(this.labelCondition);
            this.groupBox1.Controls.Add(this.labelCloudness);
            this.groupBox1.Controls.Add(this.labelPrecStrength);
            this.groupBox1.Controls.Add(this.labelPrecType);
            this.groupBox1.Controls.Add(this.labelHumidity);
            this.groupBox1.Controls.Add(this.labelPressureMm);
            this.groupBox1.Controls.Add(this.labelWindSpeed);
            this.groupBox1.Controls.Add(this.labelTemperature);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 386);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Погода на сегодня";
            // 
            // labelNameCity
            // 
            this.labelNameCity.AutoSize = true;
            this.labelNameCity.Location = new System.Drawing.Point(217, 175);
            this.labelNameCity.Name = "labelNameCity";
            this.labelNameCity.Size = new System.Drawing.Size(101, 13);
            this.labelNameCity.TabIndex = 12;
            this.labelNameCity.Text = "Местоположение: ";
            // 
            // labelWindDirection
            // 
            this.labelWindDirection.AutoSize = true;
            this.labelWindDirection.Location = new System.Drawing.Point(6, 327);
            this.labelWindDirection.Name = "labelWindDirection";
            this.labelWindDirection.Size = new System.Drawing.Size(113, 13);
            this.labelWindDirection.TabIndex = 11;
            this.labelWindDirection.Text = "Направление ветра: ";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(6, 294);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(113, 13);
            this.labelCondition.TabIndex = 10;
            this.labelCondition.Text = "Погодное описание: ";
            // 
            // labelCloudness
            // 
            this.labelCloudness.AutoSize = true;
            this.labelCloudness.Location = new System.Drawing.Point(6, 260);
            this.labelCloudness.Name = "labelCloudness";
            this.labelCloudness.Size = new System.Drawing.Size(73, 13);
            this.labelCloudness.TabIndex = 9;
            this.labelCloudness.Text = "Облачность: ";
            // 
            // labelPrecStrength
            // 
            this.labelPrecStrength.AutoSize = true;
            this.labelPrecStrength.Location = new System.Drawing.Point(6, 223);
            this.labelPrecStrength.Name = "labelPrecStrength";
            this.labelPrecStrength.Size = new System.Drawing.Size(83, 13);
            this.labelPrecStrength.TabIndex = 8;
            this.labelPrecStrength.Text = "Сила осадков: ";
            // 
            // labelPrecType
            // 
            this.labelPrecType.AutoSize = true;
            this.labelPrecType.Location = new System.Drawing.Point(6, 186);
            this.labelPrecType.Name = "labelPrecType";
            this.labelPrecType.Size = new System.Drawing.Size(77, 13);
            this.labelPrecType.TabIndex = 7;
            this.labelPrecType.Text = "Тип осадков: ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(217, 140);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(112, 13);
            this.labelHumidity.TabIndex = 6;
            this.labelHumidity.Text = "Влажность воздуха: ";
            // 
            // labelPressureMm
            // 
            this.labelPressureMm.AutoSize = true;
            this.labelPressureMm.Location = new System.Drawing.Point(217, 105);
            this.labelPressureMm.Name = "labelPressureMm";
            this.labelPressureMm.Size = new System.Drawing.Size(64, 13);
            this.labelPressureMm.TabIndex = 5;
            this.labelPressureMm.Text = "Давление: ";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Location = new System.Drawing.Point(217, 69);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(93, 13);
            this.labelWindSpeed.TabIndex = 4;
            this.labelWindSpeed.Text = "Скорость ветра: ";
            // 
            // groupBoxTommorow
            // 
            this.groupBoxTommorow.Location = new System.Drawing.Point(460, 12);
            this.groupBoxTommorow.Name = "groupBoxTommorow";
            this.groupBoxTommorow.Size = new System.Drawing.Size(561, 386);
            this.groupBoxTommorow.TabIndex = 5;
            this.groupBoxTommorow.TabStop = false;
            this.groupBoxTommorow.Text = "Погода на завтра";
            // 
            // webBrowserNow
            // 
            this.webBrowserNow.Location = new System.Drawing.Point(6, 34);
            this.webBrowserNow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNow.Name = "webBrowserNow";
            this.webBrowserNow.ScrollBarsEnabled = false;
            this.webBrowserNow.Size = new System.Drawing.Size(194, 140);
            this.webBrowserNow.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 447);
            this.Controls.Add(this.groupBoxTommorow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_search);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Яндекс.Погода";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWindDirection;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelCloudness;
        private System.Windows.Forms.Label labelPrecStrength;
        private System.Windows.Forms.Label labelPrecType;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelPressureMm;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelNameCity;
        private System.Windows.Forms.GroupBox groupBoxTommorow;
        private System.Windows.Forms.WebBrowser webBrowserNow;
    }
}

