using Cashback.Application.Interfaces;

namespace CashbackUI
{
    public partial class MainForm : Form
    {
        private readonly ILogin _login;

        public MainForm(ILogin login)
        {
            _login = login;
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var result = _login.ExecuteLogin(inputEmailText.Text, inputPasswordText.Text);

            if (result._Condition)
            {
                // levar para a home
            }

            MessageBox.Show(result._Message);
        }
    }
}
