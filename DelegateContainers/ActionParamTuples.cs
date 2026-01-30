// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.Interfaces;

namespace SharperHacks.CoreLibs.DelegateContainers;

/// <summary>
/// Base class for ActionParamTuple{T1..Tn} classes. Partial class.
/// Static factories are in ActionParamTupleFactories.cs.
/// </summary>
public abstract partial record ActionParamTuple : IInvoke
{
    /// <inheritdoc cref="IInvoke.Invoke()"/>
    public abstract void Invoke();
}

/// <summary>
/// Single parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
public record ActionParamTuple<T1>(Action<T1> Action, T1 Arg1)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1);
}

/// <summary>
/// Two parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
public record ActionParamTuple<T1, T2>(Action<T1, T2> Action, T1 Arg1, T2 Arg2)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2);
}

/// <summary>
/// Three parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
public record ActionParamTuple<T1, T2, T3>(
    Action<T1, T2, T3> Action, T1 Arg1, T2 Arg2, T3 Arg3)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3);
}

/// <summary>
/// Four parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
public record ActionParamTuple<T1, T2, T3, T4>(
    Action<T1, T2, T3, T4> Action, T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4);
}

/// <summary>
/// Five parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
public record ActionParamTuple<T1, T2, T3, T4, T5>(
    Action<T1, T2, T3, T4, T5> Action, T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5);
}


/// <summary>
/// Six paramter action.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
public record ActionParamTuple<T1, T2, T3, T4, T5, T6>(
    Action<T1, T2, T3, T4, T5, T6> Action, 
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
}


/// <summary>
/// Seven parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7>(
    Action<T1, T2, T3, T4, T5, T6, T7> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
}
;

/// <summary>
/// Eight parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
}

/// <summary>
/// Nine parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
}

/// <summary>
/// Ten parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
public record ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
    Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Action,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10)
    : ActionParamTuple, IInvoke
{
    /// <inheritdoc cref="ActionParamTuple.Invoke()"/>
    public override void Invoke() => Action(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
}

/// <summary>
/// Eleven parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
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

/// <summary>
/// Twelve parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
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

/// <summary>
/// Thirteen parameter action ctonainer.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="T13"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
/// <param name="Arg13"></param>
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

/// <summary>
/// Fourteen parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="T13"></typeparam>
/// <typeparam name="T14"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
/// <param name="Arg13"></param>
/// <param name="Arg14"></param>
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

/// <summary>
/// Fifteen parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="T13"></typeparam>
/// <typeparam name="T14"></typeparam>
/// <typeparam name="T15"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
/// <param name="Arg13"></param>
/// <param name="Arg14"></param>
/// <param name="Arg15"></param>
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

/// <summary>
/// Sixteen parameter action container.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="T13"></typeparam>
/// <typeparam name="T14"></typeparam>
/// <typeparam name="T15"></typeparam>
/// <typeparam name="T16"></typeparam>
/// <param name="Action"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
/// <param name="Arg13"></param>
/// <param name="Arg14"></param>
/// <param name="Arg15"></param>
/// <param name="Arg16"></param>
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
