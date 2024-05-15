using LoanManagement.Service;
namespace LoanManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoanService loanService = new LoanService();
            loanService.GetAllLoan();
            //loanService.GetLoanByID();
            //loanService.ApplyLoan();
            //loanService.calculateInterest();
            //loanService.calculateEMI();
            //loanService.loanRepayment();
            //loanService.loanStatus();
           
        }
    }
}
