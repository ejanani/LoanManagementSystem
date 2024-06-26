﻿using LoanManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Repository
{
    internal interface ILoanRepository
    {

        List<Loan> GetAllLoan();
        List<Loan> GetLoanByID(int loanId);
        int ApplyLoan(Loan loan);
        decimal calculateInterest(int loanId);
        decimal calculateEMI(int loanId);

        int loanStatus(int loanId);
        int loanRepayment(int loanId, decimal amount);
    }
}
