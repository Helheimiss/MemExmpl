namespace MemExmpl
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
            Box_info = new GroupBox();
            label_Hunger = new Label();
            label_HP = new Label();
            label_Stamina = new Label();
            button_refresh = new Button();
            checkBox1 = new CheckBox();
            Box_menu = new GroupBox();
            button_SETMAXStamina = new Button();
            textBox_MAXStamina = new TextBox();
            button_SETMAXHunger = new Button();
            textBox_MAXHunger = new TextBox();
            button_SETMAXHP = new Button();
            textBox_MAXHP = new TextBox();
            button_SETStamina = new Button();
            textBox_Stamina = new TextBox();
            button_SETHunger = new Button();
            textBox_Hunger = new TextBox();
            button_SETHP = new Button();
            textBox_HP = new TextBox();
            checkBox2 = new CheckBox();
            button_Clear = new Button();
            Box_info.SuspendLayout();
            Box_menu.SuspendLayout();
            SuspendLayout();
            // 
            // Box_info
            // 
            Box_info.Controls.Add(label_Hunger);
            Box_info.Controls.Add(label_HP);
            Box_info.Controls.Add(label_Stamina);
            Box_info.Location = new Point(12, 12);
            Box_info.Name = "Box_info";
            Box_info.Size = new Size(300, 150);
            Box_info.TabIndex = 1;
            Box_info.TabStop = false;
            Box_info.Text = "info";
            // 
            // label_Hunger
            // 
            label_Hunger.AutoSize = true;
            label_Hunger.Location = new Point(6, 52);
            label_Hunger.Name = "label_Hunger";
            label_Hunger.Size = new Size(75, 25);
            label_Hunger.TabIndex = 2;
            label_Hunger.Text = "Hunger:";
            // 
            // label_HP
            // 
            label_HP.AutoSize = true;
            label_HP.Location = new Point(6, 27);
            label_HP.Name = "label_HP";
            label_HP.Size = new Size(39, 25);
            label_HP.TabIndex = 1;
            label_HP.Text = "HP:";
            // 
            // label_Stamina
            // 
            label_Stamina.AutoSize = true;
            label_Stamina.Location = new Point(6, 77);
            label_Stamina.Name = "label_Stamina";
            label_Stamina.Size = new Size(84, 25);
            label_Stamina.TabIndex = 0;
            label_Stamina.Text = "Stamina: ";
            // 
            // button_refresh
            // 
            button_refresh.Location = new Point(12, 168);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(112, 34);
            button_refresh.TabIndex = 2;
            button_refresh.TabStop = false;
            button_refresh.Text = "Refresh";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(130, 172);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 29);
            checkBox1.TabIndex = 3;
            checkBox1.TabStop = false;
            checkBox1.Text = "auto refresh";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Box_menu
            // 
            Box_menu.Controls.Add(button_Clear);
            Box_menu.Controls.Add(button_SETMAXStamina);
            Box_menu.Controls.Add(textBox_MAXStamina);
            Box_menu.Controls.Add(button_SETMAXHunger);
            Box_menu.Controls.Add(textBox_MAXHunger);
            Box_menu.Controls.Add(button_SETMAXHP);
            Box_menu.Controls.Add(textBox_MAXHP);
            Box_menu.Controls.Add(button_SETStamina);
            Box_menu.Controls.Add(textBox_Stamina);
            Box_menu.Controls.Add(button_SETHunger);
            Box_menu.Controls.Add(textBox_Hunger);
            Box_menu.Controls.Add(button_SETHP);
            Box_menu.Controls.Add(textBox_HP);
            Box_menu.Location = new Point(318, 12);
            Box_menu.Name = "Box_menu";
            Box_menu.Size = new Size(470, 426);
            Box_menu.TabIndex = 4;
            Box_menu.TabStop = false;
            Box_menu.Text = "menu";
            // 
            // button_SETMAXStamina
            // 
            button_SETMAXStamina.Location = new Point(162, 236);
            button_SETMAXStamina.Name = "button_SETMAXStamina";
            button_SETMAXStamina.Size = new Size(165, 34);
            button_SETMAXStamina.TabIndex = 11;
            button_SETMAXStamina.TabStop = false;
            button_SETMAXStamina.Text = "Set Max Stamina";
            button_SETMAXStamina.UseVisualStyleBackColor = true;
            button_SETMAXStamina.Click += button_SETMAXStamina_Click;
            // 
            // textBox_MAXStamina
            // 
            textBox_MAXStamina.Location = new Point(6, 238);
            textBox_MAXStamina.MaxLength = 15;
            textBox_MAXStamina.Name = "textBox_MAXStamina";
            textBox_MAXStamina.Size = new Size(150, 31);
            textBox_MAXStamina.TabIndex = 10;
            textBox_MAXStamina.TabStop = false;
            // 
            // button_SETMAXHunger
            // 
            button_SETMAXHunger.Location = new Point(162, 196);
            button_SETMAXHunger.Name = "button_SETMAXHunger";
            button_SETMAXHunger.Size = new Size(165, 34);
            button_SETMAXHunger.TabIndex = 9;
            button_SETMAXHunger.TabStop = false;
            button_SETMAXHunger.Text = "Set Max Hunger";
            button_SETMAXHunger.UseVisualStyleBackColor = true;
            button_SETMAXHunger.Click += button_SETMAXHunger_Click;
            // 
            // textBox_MAXHunger
            // 
            textBox_MAXHunger.Location = new Point(6, 198);
            textBox_MAXHunger.MaxLength = 15;
            textBox_MAXHunger.Name = "textBox_MAXHunger";
            textBox_MAXHunger.Size = new Size(150, 31);
            textBox_MAXHunger.TabIndex = 8;
            textBox_MAXHunger.TabStop = false;
            // 
            // button_SETMAXHP
            // 
            button_SETMAXHP.Location = new Point(162, 156);
            button_SETMAXHP.Name = "button_SETMAXHP";
            button_SETMAXHP.Size = new Size(165, 34);
            button_SETMAXHP.TabIndex = 7;
            button_SETMAXHP.TabStop = false;
            button_SETMAXHP.Text = "Set Max HP";
            button_SETMAXHP.UseVisualStyleBackColor = true;
            button_SETMAXHP.Click += button_SETMAXHP_Click;
            // 
            // textBox_MAXHP
            // 
            textBox_MAXHP.Location = new Point(6, 158);
            textBox_MAXHP.MaxLength = 15;
            textBox_MAXHP.Name = "textBox_MAXHP";
            textBox_MAXHP.Size = new Size(150, 31);
            textBox_MAXHP.TabIndex = 6;
            textBox_MAXHP.TabStop = false;
            textBox_MAXHP.Tag = "f";
            // 
            // button_SETStamina
            // 
            button_SETStamina.Location = new Point(162, 102);
            button_SETStamina.Name = "button_SETStamina";
            button_SETStamina.Size = new Size(165, 34);
            button_SETStamina.TabIndex = 5;
            button_SETStamina.TabStop = false;
            button_SETStamina.Text = "Set Stamina";
            button_SETStamina.UseVisualStyleBackColor = true;
            button_SETStamina.Click += button_SETStamina_Click;
            // 
            // textBox_Stamina
            // 
            textBox_Stamina.Location = new Point(6, 104);
            textBox_Stamina.MaxLength = 15;
            textBox_Stamina.Name = "textBox_Stamina";
            textBox_Stamina.Size = new Size(150, 31);
            textBox_Stamina.TabIndex = 4;
            textBox_Stamina.TabStop = false;
            // 
            // button_SETHunger
            // 
            button_SETHunger.Location = new Point(162, 62);
            button_SETHunger.Name = "button_SETHunger";
            button_SETHunger.Size = new Size(165, 34);
            button_SETHunger.TabIndex = 3;
            button_SETHunger.TabStop = false;
            button_SETHunger.Text = "Set Hunger";
            button_SETHunger.UseVisualStyleBackColor = true;
            button_SETHunger.Click += button_SETHunger_Click;
            // 
            // textBox_Hunger
            // 
            textBox_Hunger.Location = new Point(6, 64);
            textBox_Hunger.MaxLength = 15;
            textBox_Hunger.Name = "textBox_Hunger";
            textBox_Hunger.Size = new Size(150, 31);
            textBox_Hunger.TabIndex = 2;
            textBox_Hunger.TabStop = false;
            // 
            // button_SETHP
            // 
            button_SETHP.Location = new Point(162, 22);
            button_SETHP.Name = "button_SETHP";
            button_SETHP.Size = new Size(165, 34);
            button_SETHP.TabIndex = 1;
            button_SETHP.TabStop = false;
            button_SETHP.Text = "Set HP";
            button_SETHP.UseVisualStyleBackColor = true;
            button_SETHP.Click += button_SETHP_Click;
            // 
            // textBox_HP
            // 
            textBox_HP.Location = new Point(6, 24);
            textBox_HP.MaxLength = 15;
            textBox_HP.Name = "textBox_HP";
            textBox_HP.Size = new Size(150, 31);
            textBox_HP.TabIndex = 0;
            textBox_HP.TabStop = false;
            textBox_HP.Tag = "f";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 409);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(113, 29);
            checkBox2.TabIndex = 5;
            checkBox2.TabStop = false;
            checkBox2.Text = "Top Most";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(352, 386);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(112, 34);
            button_Clear.TabIndex = 12;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(Box_menu);
            Controls.Add(checkBox1);
            Controls.Add(button_refresh);
            Controls.Add(Box_info);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Muck MemExmpl";
            Load += Form1_Load;
            Box_info.ResumeLayout(false);
            Box_info.PerformLayout();
            Box_menu.ResumeLayout(false);
            Box_menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox Box_info;
        private Button button_refresh;
        private CheckBox checkBox1;
        private Label label_Stamina;
        private Label label_Hunger;
        private Label label_HP;
        private GroupBox Box_menu;
        private Button button_SETStamina;
        private TextBox textBox_Stamina;
        private Button button_SETHunger;
        private TextBox textBox_Hunger;
        private Button button_SETHP;
        private TextBox textBox_HP;
        private CheckBox checkBox2;
        private Button button_SETMAXStamina;
        private TextBox textBox_MAXStamina;
        private Button button_SETMAXHunger;
        private TextBox textBox_MAXHunger;
        private Button button_SETMAXHP;
        private TextBox textBox_MAXHP;
        private Button button_Clear;
    }
}
