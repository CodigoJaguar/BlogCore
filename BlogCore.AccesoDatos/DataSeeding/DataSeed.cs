using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogCore.Data;
using BlogCore.Models;
using BlogCore.Utilidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlogCore.AccesoDatos.DataSeeding
{
    public class DataSeed : IDataSeed
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public DataSeed(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public void Inicializar()
        {
            try
            {
                if(_dbContext.Database.GetPendingMigrations().Count() > 0)
                {
                    _dbContext.Database.Migrate();
                }
            }
            catch
            {

            }

            if(_dbContext.Roles.Any(r => r.Name == CNT.Administrador)) return;

            // Creacion de roles
            _roleManager.CreateAsync(new IdentityRole(CNT.Administrador)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(CNT.Registrado)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(CNT.Cliente)).GetAwaiter().GetResult();

            // Creacion de usuario Administrador
            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "santandermz@codigojaguar.com",
                Email = "santandermz@codigojaguar.com",
                EmailConfirmed = true,
                Nombre = "Jean-Claude Vann Damme",
            }, "Admin1234*").GetAwaiter().GetResult();

            // Obtener user para asignarle el rol de administrador
            ApplicationUser user = _dbContext.ApplicationUser.
                Where(us => us.Email == "santandermz@codigojaguar.com").FirstOrDefault();

            if (user != null)
            {
                _userManager.AddToRoleAsync(user, CNT.Administrador).GetAwaiter().GetResult();
            }

        }
    }
}
