using Cashback.Application.Services;

namespace CashbackUI
{
    public partial class RegisterForm : Form
    {
        private readonly RegisterService _registerService;
        public RegisterForm(RegisterService registerService)
        {
            _registerService = registerService;
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            var alert = _registerService.User(inputNameText.Text, inputEmailText.Text, inputPasswordText.Text,
            inputPhoneText.Text);

            MessageBox.Show(alert._Message);

        }
    }
}
