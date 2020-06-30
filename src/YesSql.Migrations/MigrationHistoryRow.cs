namespace YesSql.Migrations
{
    /// <summary>
    /// An entity type that represents a row in the Migrations history table.
    /// </summary>

    public class MigrationHistoryRow
    {
        /// <summary>
        /// Gets or sets a class for the database migration.
        /// </summary>
        public string MigrationClass { get; set; }

        /// <summary>
        /// Gets or sets the migration identifier.
        /// </summary>
        public string MigrationId { get; set; }
    }
}
