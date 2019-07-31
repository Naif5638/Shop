﻿using Shop.UIForms.Interfaces;
using Shop.UIForms.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Shop.UIForms.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept => Resource.Accept;

        public static string Error => Resource.Error;

        public static string EmailError => Resource.EmailError;

        public static string PasswordError => Resource.PasswordError;

        public static string LoginError => Resource.LoginError;

        public static string Login => Resource.Login;

        public static string Password => Resource.Password;

        public static string EmailPlaceHolder => Resource.EmailPlaceHolder;

        public static string PasswordPlaceHolder => Resource.PasswordPlaceHolder;

        public static string RememberDevice => Resource.RememberDevice;

        public static string Cancel => Resource.Cancel;

        public static string FromGallery => Resource.FromGallery;

        public static string FromCamera => Resource.FromCamera;

        public static string TakePhoto => Resource.TakePhoto;

        public static string ErrorPrice => Resource.ErrorPrice;

        public static string ErrorName => Resource.ErrorName;

        public static string ErrorPriceZero => Resource.ErrorPriceZero;

        public static string RegisterNewUser => Resource.RegisterNewUser;

        public static string ForgotPassword => Resource.ForgotPassword;
    }
}
