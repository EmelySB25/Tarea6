using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tarea6.Data;


namespace Tarea6.Services
{
    public interface ITesoroService
    {
        Task<List<Tesoros>> GetAllTreasure (Guid Uid);
        Task<Tesoros> GetTreasure (Guid Tid);
        Task<bool> SetTreasure (Tesoros T);
        Task<Coordinate> GetCoordinate (Guid Tid);
        Task<List<Coordinate>> GetAllCoordinate (Guid Uid);
    }
    public class TesoroService : ITesoroService
    {
        private readonly ApplicationDbContext db ;
        public TesoroService(ApplicationDbContext _dbContext){
            db = _dbContext;
        }
        public Task<List<Coordinate>> GetAllCoordinate(Guid Uid)
        {
            List<Coordinate> coordinates = db.Coordinates
            .Where( c => c.Uid.Equals(Uid)).ToList<Coordinate>();
            return Task.FromResult(coordinates);
        }

        public async Task<List<Tesoros>> GetAllTreasure(Guid _Uid)
        {
            List<Tesoros> treasures = await db.Treasures
            .Where( t => t.Uid.Equals(_Uid) )
            .ToListAsync<Tesoros>();
            return await Task.FromResult(treasures);
        }

        public Task<Coordinate> GetCoordinate(Guid Tid)
        {
            Coordinate coordinate = db.Coordinates
            .Where( c => c.Tid.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(coordinate);
        }

        public Task<Tesoros> GetTreasure(Guid Tid)
        {
            Tesoros treasure = db.Treasures
            .Where( t => t.Id.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(treasure);
        }

        public Task<bool> SetTreasure(Tesoros T)
        {
            bool status = false;
            try{
                db.Treasures.Add(T);
                db.SaveChanges();
                status = true;
            }catch(Exception e)
            {
                status = false;
                Console.WriteLine(e.Message);
            }
            return Task.FromResult(status);
        }
    }

}