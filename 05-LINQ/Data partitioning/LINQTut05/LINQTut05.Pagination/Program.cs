using LINQTut05.Shared;

namespace LINQTut05.Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int page = 1;
            int size = 10;

            Console.WriteLine("number of item per page: ");
            if (int.TryParse(Console.ReadLine(), out int resultPerPage)) 
            {
                size = resultPerPage;
            }
            Console.WriteLine("page No: ");
            if (int.TryParse(Console.ReadLine(), out int pageNo))
            {
                page = pageNo;
            }
            var emps = Repository.LoadEmployees();
            var result = emps.Paginate(page, size);
            var resultCount = result.Count();
            var starRecord = ((page - 1) * size) + 1;
            var endRecord = starRecord + resultCount - 1;
                
            result.Print($"showing employees {starRecord} - {endRecord}");
        }
    }
}
