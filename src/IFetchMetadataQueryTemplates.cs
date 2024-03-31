using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbSyncKit.Templates
{
    public interface IFetchMetadataQueryTemplates
    {
        public Lazy<string> GET_USERDATATYPES { get; }

        public Lazy<string> GET_USERTABLETYPES { get; }

        public Lazy<string> GET_TABLES { get; }

        public Lazy<string> GET_COLUMNS { get; }

        public Lazy<string> GET_IDENTITIES { get; }

        public Lazy<string> GET_PRIMARYKEYS { get; }

        public Lazy<string> GET_FOREIGNKEYS { get; }

        public Lazy<string> GET_UNIQUEKEYS { get; }

        public Lazy<string> GET_DEFAULTCONSTRAINTS { get; }

        public Lazy<string> GET_CHECKCONSTRAINTS { get; }

        public Lazy<string> GET_INDICES { get; }

    }
}
