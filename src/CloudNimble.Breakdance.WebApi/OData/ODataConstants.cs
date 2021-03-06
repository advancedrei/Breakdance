﻿#if NETCOREAPP3_1_OR_GREATER
namespace CloudNimble.Breakdance.AspNetCore.OData
#else
namespace CloudNimble.Breakdance.WebApi.OData
#endif
{

    /// <summary>
    /// A set of constants used by Breakdance.OData to simplify the configuration of test runs.
    /// </summary>
    public static class ODataConstants
    {

        /// <summary>
        /// Specifies the Accept HTTP header required for OData calls.
        /// </summary>
        public const string DefaultAcceptHeader = "application/json;odata.metadata=full";

        /// <summary>
        /// Specifies the Accept HTTP header required for OData calls.
        /// </summary>
        public const string MinimalAcceptHeader = "application/json;odata.metadata=minimal";

    }

}