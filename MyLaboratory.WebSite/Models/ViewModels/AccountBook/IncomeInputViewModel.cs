﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyLaboratory.WebSite.Models.ViewModels.AccountBook
{
    public class IncomeInputViewModel
    {
        [Required(ErrorMessage = "Please enter Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter MainClass")]
        [Display(Name = "MainClass")]
        public string MainClass { get; set; }
        [Required(ErrorMessage = "Please enter SubClass")]
        [Display(Name = "SubClass")]
        public string SubClass { get; set; }
        [Required(ErrorMessage = "Please enter Contents")]
        [Display(Name = "Contents")]
        public string Contents { get; set; }
        [Required(ErrorMessage = "Please enter Amount")]
        [Display(Name = "Amount")]
        public long Amount { get; set; }
        [Required(ErrorMessage = "Please enter DepositMyAssetProductName")]
        [Display(Name = "DepositMyAssetProductName")]
        public string DepositMyAssetProductName { get; set; }
        [Display(Name = "Note")]
        public string Note { get; set; }
    }
}