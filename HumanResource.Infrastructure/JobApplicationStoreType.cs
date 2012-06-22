using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanResource.Infrastructure
{
    public enum JobApplicationStoreType
    {
        File,
        InMem,
        NHib,
        Sql,
        Xml,
        Oracle
    }
}
