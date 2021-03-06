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
using JetBrains.Annotations;

namespace FlexiMvvm.Weak.Delegates
{
    public sealed class WeakAction : WeakDelegate, IWeakAction
    {
        public WeakAction([NotNull] Action action)
            : base(action)
        {
        }

        public void Invoke(object target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            base.Invoke(target);
        }
    }

    public sealed class WeakAction<T> : WeakDelegate, IWeakAction<T>
    {
        public WeakAction([NotNull] Action<T> action)
            : base(action)
        {
        }

        public void Invoke(object target, T arg)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            base.Invoke(target, arg);
        }
    }

    public sealed class WeakAction<T1, T2> : WeakDelegate, IWeakAction<T1, T2>
    {
        public WeakAction([NotNull] Action<T1, T2> action)
            : base(action)
        {
        }

        public void Invoke(object target, T1 arg1, T2 arg2)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            base.Invoke(target, arg1, arg2);
        }
    }

    public sealed class WeakAction<T1, T2, T3> : WeakDelegate, IWeakAction<T1, T2, T3>
    {
        public WeakAction([NotNull] Action<T1, T2, T3> action)
            : base(action)
        {
        }

        public void Invoke(object target, T1 arg1, T2 arg2, T3 arg3)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            base.Invoke(target, arg1, arg2, arg3);
        }
    }

    public sealed class WeakAction<T1, T2, T3, T4> : WeakDelegate, IWeakAction<T1, T2, T3, T4>
    {
        public WeakAction([NotNull] Action<T1, T2, T3, T4> action)
            : base(action)
        {
        }

        public void Invoke(object target, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            base.Invoke(target, arg1, arg2, arg3, arg4);
        }
    }

    public sealed class WeakAction<T1, T2, T3, T4, T5> : WeakDelegate, IWeakAction<T1, T2, T3, T4, T5>
    {
        public WeakAction([NotNull] Action<T1, T2, T3, T4, T5> action)
            : base(action)
        {
        }

        public void Invoke(object target, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            base.Invoke(target, arg1, arg2, arg3, arg4, arg5);
        }
    }
}
