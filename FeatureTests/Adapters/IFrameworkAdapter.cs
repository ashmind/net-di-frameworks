﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjection.FeatureTests.Adapters {
    public interface IFrameworkAdapter {
        string FrameworkName { get; }

        void RegisterSingleton(Type serviceType, Type implementationType);
        void RegisterTransient(Type serviceType, Type implementationType);
        void RegisterInstance(Type serviceType, object instance);

        object Resolve(Type serviceType);
        
        /// <summary>
        /// This test was run only once because there is no way to recover from StackOverflowException.
        /// </summary>
        bool CrashesOnRecursion     { get; }

        /// <summary>
        /// This test was run only once because there is no way to recover from StackOverflowException.
        /// </summary>
        bool CrashesOnListRecursion { get; }
    }
}
