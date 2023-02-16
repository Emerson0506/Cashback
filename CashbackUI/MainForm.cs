using Cashback.Application;
using Cashback.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CashbackUI
{
    public partial class MainForm : Form
    {
        private readonly ILogin _login;
        private readonly IProvide _provider;

        public MainForm(ILogin login, IProvide provider)
        {
            _login = login;
            _provider = provider;
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

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            _provider.Hosting.Services.GetRequiredService<RegisterForm>().Show();
        }
    }
}
