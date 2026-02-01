// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.Interfaces;

namespace SharperHacks.CoreLibs.DelegateContainers;

// Base class for ActionParamTuple{T1..Tn} classes. Partial class.
// Static factories are in ActionParamTupleFactories.cs.
//
public abstract partial record ActionParamTuple : IInvoke
{
    /// <inheritdoc cref="IInvoke.Invoke()"/>
    public abstract void Invoke();
}

// Single parameter action container.
//
//  @T1
//
// Parameters:
//  @Action
//  @Arg1
//
public record ActionParamTuple<T1>(Action<T1> Action, T1 Arg1)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1);
}

// Two parameter action container.
//
//  @T1
//  @T2
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//
public record ActionParamTuple<T1, T2>(Action<T1, T2> Action, T1 Arg1, T2 Arg2)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2);
}

// Three parameter action container.
//
//  @T1
//  @T2
//  @T3
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//
public record ActionParamTuple<T1, T2, T3>(
    Action<T1, T2, T3> Action, T1 Arg1, T2 Arg2, T3 Arg3)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3);
}

// Four parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//
public record ActionParamTuple<T1, T2, T3, T4>(
    Action<T1, T2, T3, T4> Action, T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4);
}

// Five parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//
public record ActionParamTuple<T1, T2, T3, T4, T5>(
    Action<T1, T2, T3, T4, T5> Action, T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5);
}

// Six parameter action.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6>(
    Action<T1, T2, T3, T4, T5, T6> Action, 
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
}


// Seven parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7>(
    Action<T1, T2, T3, T4, T5, T6, T7> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
}
;

// Eight parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
}

// Nine parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//  @T9
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//  @Arg9
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
}

// Ten parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//  @T9
//  @T10
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//  @Arg9
//  @Arg10
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
}

// Eleven parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//  @T9
//  @T10
//  @T11
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//  @Arg9
//  @Arg10
//  @Arg11
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
    T11>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);
}

// Twelve parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//  @T9
//  @T10
//  @T11
//  @T12
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//  @Arg9
//  @Arg10
//  @Arg11
//  @Arg12
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
    T11, T12>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);
}

// Thirteen parameter action ctonainer.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//  @T9
//  @T10
//  @T11
//  @T12
//  @T13
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//  @Arg9
//  @Arg10
//  @Arg11
//  @Arg12
//  @Arg13
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
    T11, T12, T13>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13);
}

// Fourteen parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//  @T9
//  @T10
//  @T11
//  @T12
//  @T13
//  @T14
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//  @Arg9
//  @Arg10
//  @Arg11
//  @Arg12
//  @Arg13
//  @Arg14
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
    T11, T12, T13, T14>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13, Arg14);
}

// Fifteen parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//  @T9
//  @T10
//  @T11
//  @T12
//  @T13
//  @T14
//  @T15
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//  @Arg9
//  @Arg10
//  @Arg11
//  @Arg12
//  @Arg13
//  @Arg14
//  @Arg15
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
    T11, T12, T13, T14, T15>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14, T15 Arg15)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13, Arg14, Arg15);
}

// Sixteen parameter action container.
//
//  @T1
//  @T2
//  @T3
//  @T4
//  @T5
//  @T6
//  @T7
//  @T8
//  @T9
//  @T10
//  @T11
//  @T12
//  @T13
//  @T14
//  @T15
//  @T16
//
// Parameters:
//  @Action
//  @Arg1
//  @Arg2
//  @Arg3
//  @Arg4
//  @Arg5
//  @Arg6
//  @Arg7
//  @Arg8
//  @Arg9
//  @Arg10
//  @Arg11
//  @Arg12
//  @Arg13
//  @Arg14
//  @Arg15
//  @Arg16
//
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
    T11, T12, T13, T14, T15, T16>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14, T15 Arg15, T16 Arg16)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);
}

// Copyright Joseph W Donahue and Sharper Hacks LLC (US-WA)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SharperHacks is a trademark of Sharper Hacks LLC (US-Wa), and may not be
// applied to distributions of derivative works, without the express written
// permission of a registered officer of Sharper Hacks LLC (US-WA).
