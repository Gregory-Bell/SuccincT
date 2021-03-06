using System;

namespace SuccincT.PatternMatchers
{
    public interface IMatcher<T1, T2, T3>
    {
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(T1 value1, T2 value2, T3 value3);
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(Any value1, T2 value2, T3 value3);
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(T1 value1, Any value2, T3 value3);
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(T1 value1, T2 value2, Any value3);
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(Any value1, Any value2, T3 value3);
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(Any value1, T2 value2, Any value3);
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(T1 value1, Any value2, Any value3);
        IActionWithHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> With(Any value1, Any value2, Any value3);

        IActionWhereHandler<IActionMatcher<T1, T2, T3>, T1, T2, T3> Where(Func<T1, T2, T3, bool> function);
        IFuncMatcher<T1, T2, T3, TR> To<TR>();
    }
}