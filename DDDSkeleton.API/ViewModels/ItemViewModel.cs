using System;
using System.ComponentModel.DataAnnotations;

namespace DDDSkeleton.API.ViewModels
{
    public class ItemViewModel
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(40, ErrorMessage = "Max 40 characters")]
        public string name { get; set; }

        public DateTime created_at {
            get { return created_at; }
            set { value = DateTime.Now; }
        }
    }
}
