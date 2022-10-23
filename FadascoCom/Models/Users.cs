using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;
using System.Security.Cryptography;

namespace FadascoCom.Models
{
    public class Users
    {
        [Key]
        public int userId { get; set; }

        public string email { get; set; } = string.Empty;

        public string firstName { get; set; } = string.Empty;

        public string middleInitial { get; set; } = string.Empty;

        public string lastName { get; set; } = string.Empty;

        public string recoveryEmail { get; set; } = string.Empty;

        public int twoFactorAuthenticationEnabledFlag { get; set; }

        public int recoveryQuestionId { get; set; }

        public string recoveryAnswer { get; set; } = string.Empty;

        public int recoveryEmailSetFlag { get; set; }

        public string passwordHash { get; set; } = string.Empty;

        public int passwordSaltId { get; set; } 


        public string phoneNumber { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime sysDate { set; get; }

        public int subscriptionId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime lastLogIn { set; get; }

        public int bannedId { get; set; }

        public int accountActiveFlag { get; set; }

        public string userPath { get; set; } = string.Empty;

        public string userImage { get; set; } = string.Empty;

        public string storeLogoImage { get; set; } = string.Empty;

        public string storeBannerImage { get; set; } = string.Empty;


        public string hashPass(string password)
        {

            var sha = SHA256.Create();

            var my_bytes = Encoding.Default.GetBytes(password);

            var hashedPassword = sha.ComputeHash(my_bytes);

            return Convert.ToBase64String(hashedPassword);


        }

    }

}