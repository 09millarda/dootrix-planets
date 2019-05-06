using System;
using System.Collections.Generic;
using System.Text;

namespace Dootrix.Planets.Data.SQL
{
    internal class SqlRepositoryBase
    {
        protected DbStateContext Context { get; }
        public SqlRepositoryBase(DbStateContext context) => Context = context;
    }
}
