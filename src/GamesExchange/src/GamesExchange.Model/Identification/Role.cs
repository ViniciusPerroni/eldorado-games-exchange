using System.ComponentModel.DataAnnotations;

namespace GamesExchange.Model.Identification
{
    public enum Role
    {
        [Display(Name = "Administrator")]
        Administrator = 1,
        [Display(Name = "Common User")]
        CommonUser = 2
    }
}
