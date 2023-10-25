using TaxiOrderApp.Const;

namespace TaxiOrderApp.Entityes.Users
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public GenderEnum Gender { get; set; }
        public string Phone { get; set; }
        public RoleEnum Role { get; set; } // RoleEnum.CLIENT
        public float Rating { get; set; } // 5.0

    }
}
