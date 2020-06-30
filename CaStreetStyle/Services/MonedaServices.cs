using CaStreetStyle.CaStreetStyleDbContext;
using CaStreetStyle.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaStreetStyle.Services
{
    public class MonedaServices
    {
        public async Task<List<Moneda>> GetAllMonedasAsync()
        {
            AppDbContext context = new AppDbContext();

            try
            {
                return await context.Monedas.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }
        }
        public async Task<Moneda> GetMonedaByIdAsync(int id)
        {
            AppDbContext context = new AppDbContext();

            try
            {
                return await context.Monedas.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }
        }
        public async Task<Moneda> SaveMonedaAsync(Moneda moneda)
        {
            AppDbContext context = new AppDbContext();

            try
            {
                if (moneda != null)
                {
                    context.Monedas.Add(moneda);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

            return moneda;
        }
        public async Task<Moneda> ModifyMonedaAsycn(Moneda moneda)
        {
            AppDbContext context = new AppDbContext();

            try
            {
                if (moneda != null)
                {
                    context.Entry(moneda).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

            return moneda;
        }
        public async Task<Moneda> DeleteMonedaAsync(int id)
        {
            AppDbContext context = new AppDbContext();
            var moneda = await context.Monedas.FindAsync(id);

            try
            {
                if (moneda != null)
                {
                    context.Monedas.Remove(moneda);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                context.Dispose();
            }

            return moneda;
        }
        public async Task<Moneda> MonedaExistAsync(int id)
        {
            using (var context = new AppDbContext())
            {
                return await context.Monedas.FindAsync(id);
            }
        }
    }
}
