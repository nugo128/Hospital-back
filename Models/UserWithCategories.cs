﻿namespace Hospital.Models
{
    public class UserWithCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public byte[] Image { get; set; }
        public int Rating { get; set; }
        public List<Category> Categories { get; set; }


    }
}
