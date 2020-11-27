﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels.ModelStateVM
{
    public class ModelStateViewModel
    {
        public bool IsValid { get; set; }
        public IDictionary<string, string> Errors { get; set; }

        public ModelStateViewModel(bool isValid, IDictionary<string, string> errors)
        {
            IsValid = isValid;
            Errors = errors;
        }
    }
}
