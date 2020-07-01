using CaStreetStyle.CaStreetStyleDbContext;
using CaStreetStyle.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaStreetStyle.Services
{
    public class ArticuloServices
    {
        public async Task<List<Articulo>> GetAllArticulosAsync()
        {
            AppDbContext context = new AppDbContext();

            try
            {
                return await context.Articulos.ToListAsync();
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
        public async Task<Articulo> GetArticuloByIdAsync(int id)
        {
            AppDbContext context = new AppDbContext();

            try
            {
                return await context.Articulos.FindAsync(id);
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
        public async Task<Articulo> SaveArticuloAsync(Articulo articulo)
        {
            AppDbContext context = new AppDbContext();

            try
            {
                if (articulo != null)
                {
                    context.Articulos.Add(articulo);
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

            return articulo;
        }
        public async Task<Articulo> ModifyArticuloAsycn(Articulo articulo)
        {
            AppDbContext context = new AppDbContext();

            try
            {
                if (articulo != null)
                {
                    context.Entry(articulo).State = EntityState.Modified;
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

            return articulo;
        }
        public async Task<Articulo> DeleteArticuloAsync(int id)
        {
            AppDbContext context = new AppDbContext();
            var articulo = await context.Articulos.FindAsync(id);

            try
            {
                if(articulo != null)
                {
                    context.Articulos.Remove(articulo);
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

            return articulo;
        }
        public async Task<Articulo> MonedaExistAsync(int id)
        {
            using (var context = new AppDbContext())
            {
                return await context.Articulos.FindAsync(id);
            }
        }
        public async Task GuardarTotal(int id, double precio, double ganancia, double articuloMoneda)
        {
            AppDbContext context = new AppDbContext();
            var articuloEncontrado = context.Articulos.FindAsync(id);
            Articulo articulo = new Articulo();

            try
            {
                if (articuloEncontrado != null)
                {
                    articulo.MontoTotal = CalcularTotal(precio, ganancia, articuloMoneda);
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
        }
        public double CalcularTotal(double precio, double ganancia, double moneda)
        {
            double total = 0;

            total = ((precio * moneda) + ganancia);

            return total;
        }
    }
}
