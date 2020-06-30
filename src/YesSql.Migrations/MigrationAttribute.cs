using System;

namespace YesSql.Migrations
{
    /// <summary>
    /// Indicates that a class is a <see cref="Migration"/> and provides its identifier.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MigrationAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of this attribute.
        /// </summary>
        /// <param name="id">The migration identifier.</param>
        public MigrationAttribute(string id)
        {
            Id = id;
        }

        /// <summary>
        /// The migration identifier.
        /// </summary>
        public string Id { get; }
    }
}
