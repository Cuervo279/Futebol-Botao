namespace PrjFutebolBotao
{
    public partial class frmNovoJogo : Form
    {
        int time1Index = 0;
        int time2Index = 1;

        public frmNovoJogo()
        {
            InitializeComponent();
            SelecionaTime1(time1Index);
            SelecionaTime2(time2Index);
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            frmPartida novaPartida = new frmPartida();
            novaPartida.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelecionaTime1(int index)
        {
            switch (index)
            {
                case (0):
                    lblTime1.Text = "Santos";
                    imgTime1.BackgroundImage = Properties.Resources.Santos;
                    break;
                case (1):
                    lblTime1.Text = "São Paulo";
                    imgTime1.BackgroundImage = Properties.Resources.Sao_Paulo;
                    break;
                case (2):
                    lblTime1.Text = "Palmeiras";
                    imgTime1.BackgroundImage = Properties.Resources.Palmeiras;
                    break;
                case (3):
                    lblTime1.Text = "Corinthians";
                    imgTime1.BackgroundImage = Properties.Resources.Corinthians;
                    break;
            }

        }

        private void SelecionaTime2(int index)
        {
            switch (index)
            {
                case (0):
                    lblTime2.Text = "Santos";
                    imgTime2.BackgroundImage = Properties.Resources.Santos;
                    break;
                case (1):
                    lblTime2.Text = "São Paulo";
                    imgTime2.BackgroundImage = Properties.Resources.Sao_Paulo;
                    break;
                case (2):
                    lblTime2.Text = "Palmeiras";
                    imgTime2.BackgroundImage = Properties.Resources.Palmeiras;
                    break;
                case (3):
                    lblTime2.Text = "Corinthians";
                    imgTime2.BackgroundImage = Properties.Resources.Corinthians;
                    break;
                case (4):
                    index = 0;
                    return;
            }

        }


        private void btnSelectTime1minus_MouseClick(object sender, MouseEventArgs e)
        {
            time1Index--;
            SelecionaTime1(time1Index);
        }

        private void btnSelectTime1plus_MouseClick(object sender, MouseEventArgs e)
        {
            time1Index++;
            SelecionaTime1(time1Index);
        }
    }
}
