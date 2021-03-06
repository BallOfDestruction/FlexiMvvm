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
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace FlexiMvvm.Views.Generation.Ios
{
    public partial class BindableViewsGenerator
    {
        public BindableViewsGenerator([NotNull] string targetNamespace, [CanBeNull] params BindableViewGenerationOptions[] viewsGenerationOptions)
        {
            if (string.IsNullOrWhiteSpace(targetNamespace))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(targetNamespace));

            TargetNamespace = targetNamespace;
            ViewsGenerationOptions = viewsGenerationOptions ?? Enumerable.Empty<BindableViewGenerationOptions>();
        }

        [NotNull]
        private string TargetNamespace { get; }

        [NotNull]
        private IEnumerable<BindableViewGenerationOptions> ViewsGenerationOptions { get; }

        [NotNull]
        private string GetNamespace([NotNull] BindableViewGenerationOptions viewGenerationOptions)
        {
            return string.IsNullOrEmpty(viewGenerationOptions.TargetNamespace)
                ? TargetNamespace
                : viewGenerationOptions.TargetNamespace;
        }
    }
}
