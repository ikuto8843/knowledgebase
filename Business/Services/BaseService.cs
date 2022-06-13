using DatabaseExtension;
using MicroResolver;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KnowledgeBase.Business
{
    public class BaseService
    {
        /// <summary>
        /// データアクセスマネージャー
        /// </summary>
        public IDataAccessManager DataAccessManager { get; set; }

        /// <summary>
        /// ロガー
        /// </summary>
        protected Logger Logger { get; set; }

        public BaseService()
        {
            // Create a new container
            var resolver = ObjectResolver.Create();

            // Register interface->type map, default is transient(instantiate every request)
            resolver.Register<IDataAccessManager, DataAccessManager>();

            // Compile and Verify container(this is required step)
            resolver.Compile();

            // Get instance from container
            DataAccessManager = resolver.Resolve<IDataAccessManager>();
        }
    }
}
