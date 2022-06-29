﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Areas.Manage.ViewModels
{
    public class AdminLoginViewModel
    {
        [Required]
        [MaxLength(25)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(25)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
    }
}
