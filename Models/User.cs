﻿using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";

        public string IDNumber { get; set; } = "";
        public string Email { get; set; } = "";

        public byte[] PasswordHash { get; set; } = new byte[32];

        public byte[] PasswordSalt { get; set; } = new byte[32];

        public bool IsActive { get; set; } = false;

        public string? VerificationToken { get; set; } = "";
        public DateTime? VeriviedAt { get; set; }
        public string? PasswordResetToken { get; set; } = "";

        public DateTime? ActivationCodeExpiration { get; set; } 

     }
}
