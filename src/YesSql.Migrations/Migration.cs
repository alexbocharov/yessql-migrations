using System;
using YesSql.Sql;

namespace YesSql.Migrations
{
    /// <summary>
    /// Represents a database migration.
    /// </summary>
    public abstract class Migration
    {
        /// <summary>
        /// Build the operations that will migrate the database 'up'.
        /// </summary>
        /// <param name="schemaBuilder">The <see cref="SchemaBuilder" /> that will build the operations.</param>
        protected abstract void Up(SchemaBuilder schemaBuilder);

        /// <summary>
        /// Build the operations that will migrate the database 'down'.
        /// </summary>
        /// <param name="schemaBuidler">The <see cref="SchemaBuilder" /> that will build the operations.</param>
        protected virtual void Down(SchemaBuilder schemaBuidler)
        {
            throw new NotImplementedException();
        }
    }
}
