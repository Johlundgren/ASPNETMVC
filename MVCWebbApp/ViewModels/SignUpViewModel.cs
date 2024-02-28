﻿using Infrastructure.Models;

namespace MVCWebbApp.ViewModels;

public class SignUpViewModel
{
    public string Title { get; set; } = "Sign up";
    public SignUpModel Form { get; set; } = new SignUpModel();

    public bool TermsAndConditions { get; set; } = false;
}
