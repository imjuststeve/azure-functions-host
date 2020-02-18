// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Microsoft.Azure.WebJobs.Script.Description
{
    public interface IFunctionIndexer
    {
        /// <summary>
        /// Gets any indexing error for all functions that may be in errors
        /// </summary>
        /// <returns> A mapping of function name to the list of errors</returns>
        IDictionary<string, ICollection<string>> GetFunctionErrors();

        /// <summary>
        /// Gets all function metadata that this indexer knows about
        /// </summary>
        /// <returns>A list of indexed FunctionMetadata</returns>
        IEnumerable<FunctionMetadata> GetFunctionMetadata();
    }
}
