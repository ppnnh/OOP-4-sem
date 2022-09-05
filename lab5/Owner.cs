using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    [DataContract]
    internal class Owner
    {
        [DataMember]
        [Required(ErrorMessage = "Поле ФИО должно быть заполнено")]
        [RegularExpression(@"([А-я]){1,20}\s([А-я]){1,20}\s([А-я]){1,20}", ErrorMessage = "Неверный формат ФИО")]
        public string FullName { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Поле даты рождения должно быть заполнено")]
        public DateTime? Birthday { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Поле паспорт должно быть заполнено")]
        [Passport]
        public string Passport { get; set; }

        public Owner(string fullname, DateTime birthday, string passport)
        {
            FullName = fullname;
            Birthday = birthday;
            Passport = passport;
        }
    }
}
