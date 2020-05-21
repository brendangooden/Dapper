using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    /// <summary>
    /// Optional Column attribute.
    /// You can use the System.ComponentModel.DataAnnotations version in its place to specify the datacolumn name of a poco object
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal class ColumnAttribute : Attribute
    {
        /// <summary>
        /// Optional Column attribute.
        /// </summary>
        /// <param name="columnName"></param>
        public ColumnAttribute(string columnName)
        {
            Name = columnName;
        }
        /// <summary>
        /// Name of the column
        /// </summary>
        public string Name { get; private set; }
    }
}
