using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceLoanManager = new PersonalFinanceLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(personalFinanceLoanManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceLoanManager, vehicleLoanManager, mortgageLoanManager };

            //applicationManager.GiveCreditPreInformation(credits);
        }
    }
}
