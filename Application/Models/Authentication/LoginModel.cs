﻿using System.ComponentModel.DataAnnotations;

namespace Application.Models.Authentication;

public class LoginModel
{
    [Required] public string Email { get; set; }
    [Required] public string Password { get; set; }
}