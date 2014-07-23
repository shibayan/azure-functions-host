﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.Azure.Jobs.Host.Blobs;
using Microsoft.WindowsAzure.Storage;

namespace Microsoft.Azure.Jobs.Host.Bindings
{
    internal class BindingContext
    {
        private readonly FunctionBindingContext _functionContext;
        private readonly IReadOnlyDictionary<string, object> _bindingData;

        public BindingContext(FunctionBindingContext functionContext, IReadOnlyDictionary<string, object> bindingData)
        {
            _functionContext = functionContext;
            _bindingData = bindingData;
        }

        public FunctionBindingContext FunctionContext
        {
            get { return _functionContext; }
        }

        public IBindingProvider BindingProvider
        {
            get { return _functionContext.BindingProvider; }
        }

        public CancellationToken HostCancellationToken
        {
            get { return _functionContext.HostCancellationToken; }
        }

        public INameResolver NameResolver
        {
            get { return _functionContext.NameResolver; }
        }

        public CloudStorageAccount StorageAccount
        {
            get { return _functionContext.StorageAccount; }
        }

        public string ServiceBusConnectionString
        {
            get { return _functionContext.ServiceBusConnectionString; }
        }

        public IBlobWrittenWatcher BlobWrittenWatcher
        {
            get { return _functionContext.BlobWrittenWatcher; }
        }

        public Guid FunctionInstanceId
        {
            get { return _functionContext.FunctionInstanceId; }
        }

        public TextWriter ConsoleOutput
        {
            get { return _functionContext.ConsoleOutput; }
        }

        public CancellationToken CancellationToken
        {
            get { return _functionContext.CancellationToken; }
        }

        public IReadOnlyDictionary<string, object> BindingData
        {
            get { return _bindingData; }
        }
    }
}
