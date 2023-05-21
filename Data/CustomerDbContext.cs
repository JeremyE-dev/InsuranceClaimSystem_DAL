using InsuranceClaimSystem_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaimSystem_DAL.Data
{
    public class CustomerDbContext : DbContext
    {

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options) 
        {
        }

        public DbSet<Customer> Customers {get; set;}    
     
    }
}
