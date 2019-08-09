using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class Validator
    {

        public static bool IsValidEmail(String email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidName(String Name)
        {
            if (String.IsNullOrEmpty(Name))
                return false;

            String pattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(Name, pattern);
        }

        public static bool IsValidVehicleNumber(String v_number)
        {
            if (String.IsNullOrEmpty(v_number))
                return false;

            String pattern = @"^(?:[A-Z]{2,3})-[0-9]{4}(?<!0{4})$";
            return Regex.IsMatch(v_number, pattern);
        }

        public static bool IsValidErrorCode(String error_code)
        {
            if (String.IsNullOrEmpty(error_code))
                return false;

            String pattern = @"^[A-Z]{1}([0-9]{3,4})$";
            return Regex.IsMatch(error_code, pattern);
        }

        public static bool IsValidPrimaryCode(String error_code, String ch)
        {
            if (String.IsNullOrEmpty(error_code))
                return false;

            String pattern = @"^["+ch+"]{1}([0-9]{4})$";
            return Regex.IsMatch(error_code, pattern);
        }

        public static bool IsValidCharges(String charges)
        {
            if (String.IsNullOrEmpty(charges))
                return false;

            String pattern = @"^\d{0,8}(\.\d{1,4})?$";
            return Regex.IsMatch(charges, pattern);
        }

        public static bool IsValidNumber(String number)
        {
            if (String.IsNullOrEmpty(number))
                return false;

            String pattern = @"^[1-9]\d*(\d+)?$";
            return Regex.IsMatch(number, pattern);
        }

        public static bool IsValidFutureDate(String date)
        {
            DateTime dateTimeObj = Convert.ToDateTime(date);
            return (dateTimeObj > DateTime.Today);
        }

        public static bool IsValidPastDate(String date)
        {
            DateTime dateTimeObj = Convert.ToDateTime(date);
            return (dateTimeObj <= DateTime.Today);
        }

        //Ishara

        public static bool IsValidPhonenumber(String phonenumber)
        {
            if (String.IsNullOrEmpty(phonenumber))
                return false;

            String pattern = @"^((0|\+94|94)7(0|1|2|5|6|7|8))\d{7}$";
            return Regex.IsMatch(phonenumber, pattern);
        }

        public static bool IsValidPrice(String price)
        {
            if (String.IsNullOrEmpty(price))
                return false;
            String pattern = @"^\d{0,8}(\.\d{1,4})?$";
            //String pattern = @"^\d*(\.|,)\d{2}$";
            return Regex.IsMatch(price, pattern);
        }


        //Lahiru
        public static bool IsValidNameWithSpaces(String Name)
        {
            if (String.IsNullOrEmpty(Name))
                return false;

            String pattern = @"^[A-Za-z ]+$";
            return Regex.IsMatch(Name, pattern);
        }

        public static bool IsValidFutureDate(DateTime dateTimeObj)
        {
            return (dateTimeObj > DateTime.Today);
        }

        public static bool IsValidIntNumber(String number)
        {
            if (String.IsNullOrEmpty(number))
                return false;

            String pattern = @"^[1-9]\d*(\d+)?$";
            return Regex.IsMatch(number, pattern);
        }

        public static bool IsValidBeforeOrTodayDate(DateTime dateTimeObj)
        {
            return (dateTimeObj <= DateTime.Today);
        }

        public static bool IsValidDescription(String number)
        {
            if (String.IsNullOrEmpty(number))
                return false;

            String pattern = @"^[a-zA-Z0-9 ]+$";
            return Regex.IsMatch(number, pattern);
        }

        //Sameer
        public bool IsBillTypeInvalid(string data)
        {
            if (data == "Electricity")
                return false;
            else if (data == "Internet")
                return false;
            else if (data == "Water")
                return false;
            else if (data == "Select Type")
                return true;
            else
                return true;
        }

        public static bool IsValidPrice1(string price)
        {
            if (string.IsNullOrEmpty(price))
                return false;
            string pattern = @"^\d{0,8}(\.\d{1,2})?$";
            return Regex.IsMatch(price, pattern);
        }

        public static bool isValidPeriod(string period)
        {
            if (string.IsNullOrEmpty(period))
                return false;
            string pattern = "^[0-9]{1,3}$";
            return Regex.IsMatch(period, pattern);
        }

        public static bool isValidRate(string rate)
        {
            if (string.IsNullOrEmpty(rate))
                return false;
            string pattern = @"^\d{1,2}(\.\d{1,2})?$";
            return Regex.IsMatch(rate, pattern);
        }
    }
}
