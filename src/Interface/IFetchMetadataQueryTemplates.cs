using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSyncKit.Templates.Interface
{
    /// <summary>
    /// Serves as a blueprint for classes defining queries 
    /// which fetch metadata from the database
    /// </summary>
    public interface IFetchMetadataQueryTemplates
    {

        /// <summary>
        /// Stores query to fetch all user defined data types from the database
        /// </summary>
        public Lazy<string> GET_USERDATATYPES { get; }

        /// <summary>
        /// Stores query to fetch all user defined table types from the database
        /// </summary>
        public Lazy<string> GET_USERTABLETYPES { get; }

        /// <summary>
        /// Stores query to fetch all tables from the database
        /// </summary>
        public Lazy<string> GET_TABLES { get; }

        /// <summary>
        /// Stores query to fetch all columns from the database
        /// </summary>
        public Lazy<string> GET_COLUMNS { get; }

        /// <summary>
        /// Stores query to fetch all identities/sequences/auto-increments from the database
        /// </summary>
        public Lazy<string> GET_IDENTITIES { get; }

        /// <summary>
        /// Stores query to fetch all primary keys from the database
        /// </summary>
        public Lazy<string> GET_PRIMARYKEYS { get; }

        /// <summary>
        /// Stores query to fetch all foreign keys from the database
        /// </summary>
        public Lazy<string> GET_FOREIGNKEYS { get; }

        /// <summary>
        /// Stores query to fetch all unique keys from the database
        /// </summary>
        public Lazy<string> GET_UNIQUEKEYS { get; }

        /// <summary>
        /// Stores query to fetch all default constraints from the database
        /// </summary>
        public Lazy<string> GET_DEFAULTCONSTRAINTS { get; }

        /// <summary>
        /// Stores query to fetch all check constraints from the database
        /// </summary>
        public Lazy<string> GET_CHECKCONSTRAINTS { get; }

        /// <summary>
        /// Stores query to fetch all indices from the database
        /// </summary>
        public Lazy<string> GET_INDICES { get; }

    }
}
