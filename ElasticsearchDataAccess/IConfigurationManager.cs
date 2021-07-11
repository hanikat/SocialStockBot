using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchDataAccess
{
    public interface IConfigurationManager
    {
        string ElasticsearchURL { get; }

        string ElasticsearchUsername { get; }

        string ElasticsearchPassword { get; }
    }
}
