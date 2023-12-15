using Ramos14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ramos14
{
    public class CompraService
    {
        private readonly AppDbContext _context;

        public CompraService() => _context = App.GetContext();


        public bool Create(Compra item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Compras.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Compra> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Compras.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Compra> Get()
        {
            return _context.Compras.ToList();
        }


        public List<Compra> GetByText(string text)
        {
            return _context.Compras.Where(x => x.Cliente.Contains(text)).ToList();
        }



    }
}
