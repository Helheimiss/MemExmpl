namespace MemExmpl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateInfo();
        }


        private void refershInfo()
        {
            Data.GetHP();
            Data.GetHunger();
            Data.GetStamina();

            Data.GetMaxHP();
            Data.GetMaxHunger();
            Data.GetMaxStamina();

            label_HP.Text = $"HP: {Data.hp} / {Data.max_hp}";
            label_Hunger.Text = $"Hunger: {Data.hunger} / {Data.max_hunger}";
            label_Stamina.Text = $"Stamina: {Data.stamina} / {Data.max_stamina}";
        }


        private async void updateInfo()
        {
            while (true)
            {
                await Task.Delay(500);

                if (checkBox1.Checked)
                    refershInfo();
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.button_refresh.Enabled = !checkBox1.Checked;
        }


        private void button_refresh_Click(object sender, EventArgs e)
        {
            refershInfo();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox2.Checked;
        }

        private void button_SETHP_Click(object sender, EventArgs e)
        {
            try
            {
                Data.SetHP(float.Parse(textBox_HP.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_SETHunger_Click(object sender, EventArgs e)
        {
            try
            {
                Data.SetHunger(float.Parse(textBox_Hunger.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_SETStamina_Click(object sender, EventArgs e)
        {
            try
            {
                Data.SetStamina(float.Parse(textBox_Stamina.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_SETMAXHP_Click(object sender, EventArgs e)
        {
            try
            {
                Data.SetMaxHP(int.Parse(textBox_MAXHP.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_SETMAXHunger_Click(object sender, EventArgs e)
        {
            try
            {
                Data.SetMaxHunger(float.Parse(textBox_MAXHunger.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_SETMAXStamina_Click(object sender, EventArgs e)
        {
            try
            {
                Data.SetMaxStamina(float.Parse(textBox_MAXStamina.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("incorrect input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_HP.Text = "";
            textBox_Hunger.Text = "";
            textBox_Stamina.Text = "";

            textBox_MAXHP.Text = "";
            textBox_MAXHunger.Text = "";
            textBox_MAXStamina.Text = "";
        }
    }
}
