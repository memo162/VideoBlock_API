using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Respository
{
    public class RepositoryDbProvider : IRepositoryDbProvider
    {
        private readonly IConfiguration _configuration;

        public RepositoryDbProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public RepositoryDbContext GetDbContext()
        {
            return new RepositoryDbContext(_configuration.GetSection("ConnectionStrings").GetSection("ConexionText").Value);
        }
    }
}
