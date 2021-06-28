﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class RegisterViewModel
    {
            [Required]
            [EmailAddress]
            [Remote(action: "IsEmailInUse", controller: "Account")]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            [DataType(DataType.Password)]
            [Display(Name = "Confirme a senha")]
            [Compare("Password", ErrorMessage = "As senhas não conferem")]
            public string ConfirmPassword { get; set; }
            
            public string Cidade { get; set; }
    }
}
