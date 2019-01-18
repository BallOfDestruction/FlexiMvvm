﻿// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

using System;
using FlexiMvvm.Operations;
using JetBrains.Annotations;

namespace FlexiMvvm.ViewModels
{
    public abstract class ItemViewModel : ObservableObject
    {
        [CanBeNull]
        private readonly IOperationFactory _operationFactory;
        [CanBeNull]
        private OperationContext _operationContext;

        protected ItemViewModel()
        {
        }

        protected ItemViewModel([NotNull] IOperationFactory operationFactory)
        {
            _operationFactory = operationFactory ?? throw new ArgumentNullException(nameof(operationFactory));
        }

        [NotNull]
        protected IOperationFactory OperationFactory => _operationFactory ?? throw new InvalidOperationException(
            $"\"{nameof(OperationFactory)}\" property is \"null\". Make sure that the operation factory is passed as a constructor parameter.");

        [NotNull]
        protected OperationContext OperationContext => _operationContext ?? (_operationContext = OperationFactory.CreateContext(this));
    }
}