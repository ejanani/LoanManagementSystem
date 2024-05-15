using LoanManagement.Model;
using LoanManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Service
{
    internal interface ILoanService
    {

        void GetAllLoan();
        void GetLoanByID();
        void ApplyLoan();
        void calculateInterest();
        void calculateEMI();
        void loanRepayment();
        void loanStatus();
    }
    }

