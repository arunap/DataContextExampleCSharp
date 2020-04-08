using DataContextExampleCSharp.DataContexts;
using DataContextExampleCSharp.Repositoty;
using System;

namespace DataContextExampleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDataContext dataContext = new DataContext();
            IUnitOfWork unitOfWork = new UnitOfWork(dataContext);

            unitOfWork.CallExtractionProgressers.Insert(new Models.CallExtractionProgress { CallIdStatusLog = "", ScheduleId = Guid.NewGuid(), });
            unitOfWork.CommitAsync().Wait();
        }
    }
}
