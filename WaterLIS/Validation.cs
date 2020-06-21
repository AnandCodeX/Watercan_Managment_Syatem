using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
 

namespace WaterLIS
{
    class Validation
    {
        //======================================Customer==========================================
        
         public static string CustomerValidation(string txtname,string txtmobileno,string txtidproof,string txtnoofcan,string txtpriceofcan)
        {

            Regex re = new Regex("[a-zA-Z]");
            if (re.IsMatch(txtname) == false)
            {
                return "Invalid Name";
            }

            Regex re1 = new Regex("[0-9]");
            if (re1.IsMatch(txtmobileno) == false)
            {
                return "Invalid Mobile Number ";
            }



    
            Regex re2 = new Regex("[a-zA-Z0-9]");
            if (re2.IsMatch(txtidproof) == false)
            {
                return "Invalid ID Proof";
            }

            Regex re3 = new Regex("[0-9]");
            if (re3.IsMatch(txtnoofcan) == false)
            {
                return "Invalid Amount ";
            }
            Regex re4 = new Regex("[0-9]");
            if (re4.IsMatch(txtpriceofcan) == false)
            {
                return "Invalid Amount ";
            }
           
             return "";

        }

        //===============Employee=======================================================

        public static string EmployeeValidation(string txtname, string txtmobileno, string txtidproof, string txtsalary, string txtdesignation)
        {

            Regex re = new Regex("[a-zA-Z]");
            if (re.IsMatch(txtname) == false)
            {
                return "Invalid Name";
            }

            Regex re1 = new Regex("[0-9]");
            if (re1.IsMatch(txtmobileno) == false)
            {
                return "Invalid Mobile Number ";
            }




            Regex re2 = new Regex("[a-zA-Z0-9]");
            if (re2.IsMatch(txtidproof) == false)
            {
                return "Invalid ID Proof";
            }

            Regex re3 = new Regex("[0-9]");
            if (re3.IsMatch(txtsalary) == false)
            {
                return "Invalid Salary ";
            }
            Regex re4 = new Regex("[a-zA-Z]");
            if (re4.IsMatch(txtdesignation) == false)
            {
                return "Invalid Designation ";
            }

            return "";
            }
        //=====================Expenditure=================================================================================
        public static string ExpenditureValidation(string txtamount,string txtpaidto)
        {

            Regex re = new Regex("[0-9]");
            if (re.IsMatch(txtamount) == false)
            {
                return "Invalid Amount";
            }
            Regex re1 = new Regex("[a-zA-Z]");
            if (re1.IsMatch(txtpaidto) == false)
            {
                return "Invalid Paid To ";
            }

            return "";
        }
        //===========================Pre_Booking==================================================================================
        public static string BookingValidation(string txtname, string txtmobileno, string txtidproof, string txtnoofcan, string txtpriceofcan,string txttotalamount,string txtadvamount,string txtremainamount )
        {

            Regex re = new Regex("[a-zA-Z ]*$");
            if (re.IsMatch(txtname) == false)
            {
                return "Invalid Name";
            }

            Regex re1 = new Regex("[0-9]");
            if (re1.IsMatch(txtmobileno) == false)
            {
                return "Invalid Mobile Number ";
            }




            Regex re2 = new Regex("[a-zA-Z0-9]");
            if (re2.IsMatch(txtidproof) == false)
            {
                return "Invalid ID Proof";
            }

            Regex re3 = new Regex("[0-9]");
            if (re3.IsMatch(txtnoofcan) == false)
            {
                return "Invalid Amount(No of Cans) ";
            }
            Regex re4 = new Regex("[0-9]");
            if (re4.IsMatch(txtpriceofcan) == false)
            {
                return "Invalid Amount(Price) ";
            }

            Regex re5 = new Regex("[0-9]");
            if (re4.IsMatch(txttotalamount) == false)
            {
                return "Invalid Amount(total) ";
            }
            Regex re6 = new Regex("[0-9]");
            if (re4.IsMatch(txtadvamount) == false)
            {
                return "Invalid Amount(Adv_Amount) ";
            }
            Regex re7 = new Regex("[0-9]");
            if (re4.IsMatch(txtremainamount) == false)
            {
                return "Invalid Amount(Remaining Amount) ";
            }

            return "";
        }
        //==========================Installment======================================================


        public static string InstallmentValidation(string txtpaidamount, string txtpayee)
        {

            Regex re = new Regex("[0-9]");
            if (re.IsMatch(txtpaidamount) == false)
            {
                return "Invalid  Paid Amount";
            }
            Regex re1 = new Regex("[a-zA-Z]");
            if (re1.IsMatch(txtpayee) == false)
            {
                return "Invalid Payee ";
            }

            return "";
        }


    }
    }
