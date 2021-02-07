namespace BuiltinFilters.Model
{
    using System.ComponentModel.DataAnnotations;
    public class UserMaster
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Address { get; set; }
    }
}
