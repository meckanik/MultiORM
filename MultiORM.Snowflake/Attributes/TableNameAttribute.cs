﻿using MultiORM.Snowflake.Attributes.Interfaces;

namespace MultiORM.Snowflake.Attributes;

/// <summary>
///     Attribute class for specifying a table name.
/// </summary>
[AttributeUsage(AttributeTargets.Class,  AllowMultiple = false)]
public sealed class TableNameAttribute : Attribute, ITableNameAttribute
{
    private readonly string _tableName;

    /// <summary>
    ///     Initializes a new instance of the <see cref="TableNameAttribute"/> class.
    /// </summary>
    /// <param name="tableName">The name of the table.</param>
    public TableNameAttribute(string tableName) { _tableName = tableName; }

    /// <summary>
    ///     Gets the TGableName value.
    /// </summary>
    public string TableName => _tableName;
}
