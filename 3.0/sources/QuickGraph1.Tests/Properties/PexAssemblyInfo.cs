// This file should only contain assembly level attributes.
// Do not add any class or struct definitions as it may disable the ability of the tool to
// update the file.

using System;

using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Framework.Suppression;

[assembly: PexAssemblyUnderTest("QuickGraph")]

[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(Math))]
