﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSyncKit.Templates.Interface
{
    /// <summary>
    /// Defines methods for generating SQL queries and handling query-related operations.
    /// </summary>
    public interface IQueryGenerator : IDisposable
    {
        /// <summary>
        /// Generates a SELECT query for retrieving data from a database table.
        /// </summary>
        /// <param name="tableName">The name of the database table.</param>
        /// <param name="ListOfColumns">The list of columns to be selected.</param>
        /// <param name="schemaName">The schema name of the database table.</param>
        /// <returns>A string representing the generated SELECT query.</returns>
        string GenerateSelectQuery<T>(string tableName, List<string> ListOfColumns, string schemaName);

        /// <summary>
        /// Generates an UPDATE query for updating data in a database table.
        /// </summary>
        /// <param name="DataContract">The entity with the updated data.</param>
        /// <param name="keyColumns">The list of key columns used for updating.</param>
        /// <param name="excludedColumns">The list of columns to be excluded from the update.</param>
        /// <param name="editedProperties">A dictionary representing the properties and their new values to be updated.</param>
        /// <returns>A string representing the generated UPDATE query.</returns>
        string GenerateUpdateQuery<T>(T DataContract, List<string> keyColumns, List<string> excludedColumns, (string propName, object propValue)[] editedProperties);

        /// <summary>
        /// Generates a DELETE query for deleting data from a database table.
        /// </summary>
        /// <param name="entity">The entity representing the data to be deleted.</param>
        /// <param name="keyColumns">The list of key columns used for deletion.</param>
        /// <returns>A string representing the generated DELETE query.</returns>
        string GenerateDeleteQuery<T>(T entity, List<string> keyColumns);

        /// <summary>
        /// Generates an INSERT query for inserting data into a database table.
        /// </summary>
        /// <param name="entity">The entity representing the data to be inserted.</param>
        /// <param name="keyColumns">The list of key columns used for insertion.</param>
        /// <param name="excludedColumns">The list of columns to be excluded from the insertion.</param>
        /// <returns>A string representing the generated INSERT query.</returns>
        string GenerateInsertQuery<T>(T entity, List<string> keyColumns, List<string> excludedColumns);

        /// <summary>
        /// Generates a SQL comment.
        /// </summary>
        /// <param name="comment">The comment text.</param>
        /// <returns>A string representing the generated comment.</returns>
        string GenerateComment(string comment);

        /// <summary>
        /// Gets a condition for use in a SQL WHERE clause based on the entity and key columns.
        /// </summary>
        /// <param name="entity">The entity for which the condition is generated.</param>
        /// <param name="keyColumns">The list of key columns used to create the condition.</param>
        /// <returns>A string representing the generated condition for a SQL WHERE clause.</returns>
        List<string> GetCondition<T>(T entity, List<string> keyColumns);

        /// <summary>
        /// Escapes special characters in the input to make it SQL-safe.
        /// </summary>
        /// <param name="input">The input object or string to be escaped.</param>
        /// <returns>The escaped object or string.</returns>
        object? EscapeValue(object? input);

        /// <summary>
        /// Escapes the input column name to be used safely in SQL queries.
        /// </summary>
        /// <param name="input">The input column name to be escaped.</param>
        /// <returns>The escaped column name.</returns>
        string EscapeColumn(string? input);

        /// <summary>
        /// Generates a SQL batch separator ('GO' statement in SQL Server) used to execute batches of SQL statements.
        /// </summary>
        /// <returns>A string representing the generated batch separator.</returns>
        string GenerateBatchSeparator();
    }
}
