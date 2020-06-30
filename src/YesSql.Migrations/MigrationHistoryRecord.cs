using System.Collections.Generic;

namespace YesSql.Migrations
{
    public class MigrationHistoryRecord
    {
        /// <summary>
        /// Creates a new instance of the <see cref="MigrationHistoryRecord" />.
        /// </summary>
        public MigrationHistoryRecord()
        {
            Migrations = new List<MigrationHistoryRow>();
        }

        /// <summary>
        /// Gets or sets the record identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the database migrations.
        /// </summary>
        public List<MigrationHistoryRow> Migrations { get; set; }
    }
}
