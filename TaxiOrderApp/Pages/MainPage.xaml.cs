using TaxiOrderApp.Const;
using TaxiOrderApp.Entityes.Users;

namespace TaxiOrderApp
{
    public partial class MainPage : ContentPage
    {
        private string _phoneEntry { get; set; } 
        private List<UserEntity> _users = new List<UserEntity>();
        public MainPage()
        {
            InitializeComponent();
            _users.Add(new UserEntity
            {
                Id = 1,
                FIO = "Кузнецов Василий Иванович",
                Gender = GenderEnum.MALE,
                Phone = "+7 (901) 111-11-11",
                Role = RoleEnum.CLIENT,
                Rating = 3.14F
            });
        }
        private bool is_validPhoneNumber()
        {
            if (_phoneEntry.Length < 18)
            {
                DisplayAlert("", "Неверный номер телефона!", "Ок");
                return false;
            }
            return true;
        }
        private void send_Clicked(object sender, EventArgs e)
        {
            _phoneEntry = PhoneEntry.Text;
            if (is_validPhoneNumber())
            {
                CodeEntry.IsVisible = true;
            }
        }
    }
}