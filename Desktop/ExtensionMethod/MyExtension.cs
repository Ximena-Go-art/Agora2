using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.ExtensionMethod
{
    public static class MyExtension
    {
        public static void HideColumns(this DataGridView grid, params string[] columnsName)
        {
            foreach (var columnName in columnsName)
            {
                if (grid.Columns.Contains(columnName))
                {
                    grid.Columns[columnName].Visible = false;
                }
            }
        }
    }
}
