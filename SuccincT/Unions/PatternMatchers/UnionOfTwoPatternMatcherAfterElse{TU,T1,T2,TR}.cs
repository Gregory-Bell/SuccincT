﻿using System;
using System.Collections.Generic;
using SuccincT.Options;

namespace SuccincT.Unions.PatternMatchers
{
    public class UnionOfTwoPatternMatcherAfterElse<TUnion, T1, T2, TReturn> where TUnion : Union<T1, T2>
    {
        private readonly TUnion _union;
        private readonly Dictionary<Variant, Func<Option<TReturn>>> _resultActions;
        private readonly Func<TUnion, TReturn> _elseAction;

        internal UnionOfTwoPatternMatcherAfterElse(TUnion union,
                                              UnionCaseActionSelector<T1, TReturn> case1ActionSelector,
                                              UnionCaseActionSelector<T2, TReturn> case2ActionSelector,
                                              Func<TUnion, TReturn> elseAction)
        {
            _union = union;
            _elseAction = elseAction;
            _resultActions = new Dictionary<Variant, Func<Option<TReturn>>>
            {
                { Variant.Case1, () => case1ActionSelector.DetermineResult(_union.Case1) },
                { Variant.Case2, () => case2ActionSelector.DetermineResult(_union.Case2) }
            };
        }

        public TReturn Result()
        {
            return _resultActions[_union.Case]().Match<TReturn>()
                                .Some().Do(x => x)
                                .None().Do(() => _elseAction(_union))
                                .Result();
        }
    }
}