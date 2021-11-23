using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Data.DataAccess.FileAccess;
using Server.Data.Models;

namespace Server.Data.DataAccess.DatabaseAccess
{
    public class AdultDatabaseRepository : IAdultDatabaseRepository
    {

        public AdultDatabaseRepository()
        {            
            // ReSharper disable once AsyncVoidLambda
            Task.Run(async ()=> await LoadDataFromFileToDatabase());
        }
        public IList<Adult> GetAdults()
        {
            using var dbContext = new Assigment3DbContext();
            return dbContext.Adults.Include(j => j.JobTitle).ToList();
        }

        public async Task AddAdult(Adult adult)
        {
            await using var dbContext =new Assigment3DbContext();
            adult.Id = dbContext.Adults.Count()+1;
            await dbContext.Adults.AddAsync(adult);
            await dbContext.SaveChangesAsync();
        }
        
        private static async Task LoadDataFromFileToDatabase()
        {
            var adultRepository = new AdultRepository();
            await using var dbContext = new Assigment3DbContext();
            foreach (var adult in adultRepository.GetAdults())
            {
                dbContext.Adults.AddIfNotExists(adult, adult1 => adult1.Id == adult.Id );    
            }

            await dbContext.SaveChangesAsync();

        }
    }
}