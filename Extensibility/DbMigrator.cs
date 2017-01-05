using System;

namespace Extensibility
{
    //Open Closed Principle [OCP]
    //Software entities should be open for extension but closed for modification.
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)//Dependencies Injection
        {
            _logger = logger;
        }   

        public void Migrate()
        {
            _logger.LogInfo("Migrating started at:" + DateTime.Now);

            //Details of migrating the database

            _logger.LogInfo("Migrating finished at:" + DateTime.Now.AddMinutes(1));
        }
    }
}