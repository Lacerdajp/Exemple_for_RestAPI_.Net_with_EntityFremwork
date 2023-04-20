﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aula8.Models
{
    [Table("users")]
    public class User
    {
        
            [Key]
            [Column ("id")]
            public int Id { get; set; }
            [Column ("user_name")]
            public string UserName { get; set; }
            [Column ("full_name")]
            public int FullName { get; set; }
            [Column("password")]
            public string Password { get; set; }
            [Column("refresh_token")]
            public string RefreshToken { get; set; }
            [Column("refresh_token_expiry_time")]
            public DateTime RefreshTokenExpiryTime { get; set; }
        
    }
}