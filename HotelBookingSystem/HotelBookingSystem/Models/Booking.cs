using System.ComponentModel.DataAnnotations;

namespace HotelBookingSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        [Required]
        [Display(Name = "Duration (days)")]
        public int Duration { get; set; }

        // Add more fields as needed
        [Display(Name = "Room Type")]
        public string RoomType { get; set; }

        [Display(Name = "Special Requests")]
        public string SpecialRequests { get; set; }

        //Author: Open AI
        //AI Chatbot: ChatGPT
        //Date: 24 February 2025
        //Availability: https://chatgpt.com/share/67bc3701-aa34-8002-9397-b34b73662272


    }

}
