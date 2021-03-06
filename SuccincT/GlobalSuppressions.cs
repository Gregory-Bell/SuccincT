using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
                           Justification = "Separation of concerns", Target = "SuccincT.Parsers")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
                           Justification = "Separation of concerns", Target = "SuccincT.FunctionalComposition")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type",
                           Justification = "Special-case exception", Target = "SuccincT.Unions.InvalidCaseException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type",
                           Justification = "Special-case exception",
                           Target = "SuccincT.PatternMatchers.NoMatchException")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Function",
                           Justification = "Extention method", Scope = "type",
                           Target = "SuccincT.FunctionalComposition.Function")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Option",
                           Justification = "No better name (taken from F#)", Scope = "type",
                           Target = "SuccincT.Options.Option`1")]
[assembly: SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes",
                           Justification = "Correct way to construct option", Scope = "member",
                           Target = "SuccincT.Options.Option`1.#None()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes",
                           Justification = "Correct way to construct option", Scope = "member",
                           Target = "SuccincT.Options.Option`1.#Some(!0)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member",
                           Target = "SuccincT.Unions.Union`2.#Equals(System.Object)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member",
                           Target = "SuccincT.Options.Option`1.#Equals(System.Object)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member",
                           Target = "SuccincT.Options.ValueOrError.#Equals(System.Object)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace",
                           Target = "SuccincT")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SuccincT.PatternMatchers.SpecificTypeMatcherExtensions.#Match`4(System.Tuple`4<!!0,!!1,!!2,!!3>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "SuccincT.PartialApplications.ActionWithOptionalParam`2.#Invoke(!0,!1)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "SuccincT.PartialApplications.ActionWithOptionalParam`3.#Invoke(!0,!1,!2)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "SuccincT.PartialApplications.ActionWithOptionalParam`4.#Invoke(!0,!1,!2,!3)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "SuccincT.PartialApplications.ActionWithOptionalParam`5.#Invoke(!0,!1,!2,!3,!4)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SuccincT.PatternMatchers.SpecificTypeMatcherExtensions.#Match`1(System.Tuple`1<!!0>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SuccincT.PatternMatchers.SpecificTypeMatcherExtensions.#Match`2(System.Tuple`2<!!0,!!1>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SuccincT.PatternMatchers.SpecificTypeMatcherExtensions.#Match`2(SuccincT.Tuples.ITupleMatchable`2<!!0,!!1>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SuccincT.PatternMatchers.SpecificTypeMatcherExtensions.#Match`3(SuccincT.Tuples.ITupleMatchable`3<!!0,!!1,!!2>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SuccincT.PatternMatchers.SpecificTypeMatcherExtensions.#Match`4(SuccincT.Tuples.ITupleMatchable`4<!!0,!!1,!!2,!!3>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SuccincT.PatternMatchers.SpecificTypeMatcherExtensions.#Match`3(System.Tuple`3<!!0,!!1,!!2>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SuccincT.PatternMatchers.GeneralMatcher")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SuccincT.Tuples")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "SuccincT.Unions.InvalidCaseOfTypeException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1005:AvoidExcessiveParametersOnGenericTypes", Scope = "namespace",
                           Target = "SuccincT")]
[assembly: SuppressMessage("Microsoft.Design", "CA1005:AvoidExcessiveParametersOnGenericTypes", Scope = "namespace",
                           Target = "SuccincT.Functional")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "namespace",
                           Target = "SuccincT.Functional")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Else", Scope = "namespace", Target = "SuccincT.Options")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "SuccincT.Functional.ActionWithOptionalParameter`2.#Invoke(!0,!1)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "SuccincT.Functional.ActionWithOptionalParameter`3.#Invoke(!0,!1,!2)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "SuccincT.Functional.ActionWithOptionalParameter`4.#Invoke(!0,!1,!2,!3)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "SuccincT.Functional.ActionWithOptionalParameter`5.#Invoke(!0,!1,!2,!3,!4)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1005:AvoidExcessiveParametersOnGenericTypes", Scope = "type", Target = "SuccincT.Functional.ActionWithOptionalParameter`3")]
[assembly: SuppressMessage("Microsoft.Design", "CA1005:AvoidExcessiveParametersOnGenericTypes", Scope = "type", Target = "SuccincT.Functional.ActionWithOptionalParameter`4")]
[assembly: SuppressMessage("Microsoft.Design", "CA1005:AvoidExcessiveParametersOnGenericTypes", Scope = "type", Target = "SuccincT.Functional.ActionWithOptionalParameter`5")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "f", Scope = "type", Target = "SuccincT.Functional.TypedLambdas")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "u2", Scope = "member", Target = "SuccincT.Functional.Unit.#op_Equality(SuccincT.Functional.Unit,SuccincT.Functional.Unit)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant")]

