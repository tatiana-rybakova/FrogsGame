namespace FrogsWinFormsApp
{
    public partial class MainForm : Form
    {
        int minimumSteps = 24;
        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
            if ((PictureBox)sender != emptyPictureBox)
            {
                stepLabel.Text = (int.Parse(stepLabel.Text) + 1).ToString();
            }
            else
            {
                MessageBox.Show("Так нельзя!");
            }
            if (EndGame())
            {
                if (InMinimumSteps())
                {
                    MessageBox.Show("Победа! Вы справились за минимальное количество ходов!");
                }
                else
                {
                    var result = MessageBox.Show("Победа! Но можно лучше. Попробовать еще раз?", "Конец игры", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }
        }

        private bool InMinimumSteps()
        {
            return int.Parse(stepLabel.Text) == minimumSteps;
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distantion = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;
            if (distantion > 2)
            {
                MessageBox.Show("Так нельзя!");
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
            }
        }

        private bool EndGame()
        {
            var startLocationEmptyPictureBox = 440;
            if (leftPictureBox1.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox2.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox3.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox4.Location.X > emptyPictureBox.Location.X &&
                emptyPictureBox.Location.X == startLocationEmptyPictureBox)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoolsForm roolsForm = new RoolsForm();
            roolsForm.Show();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
