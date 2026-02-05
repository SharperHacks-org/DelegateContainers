// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.Interfaces;

namespace SharperHacks.CoreLibs.DelegateContainers;

// Base class for FuncParamTuple{TResult, T1..Tn}
//
public abstract partial record FuncParamTuple<TResult> : IInvokable<TResult>
{
    /// <inheritdoc cref="IInvokable{T}.Invoke()"/>
    public abstract TResult Invoke();
}

// Single parameter Func Tuple.
public record FuncParamTuple<T1, TResult>(Func<T1, TResult> Func, T1 Arg1) 
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1);
}

// Two parameter Func tuple.
public record FuncParamTuple<T1, T2, TResult>(Func<T1, T2, TResult> Func,
    T1 Arg1, T2 Arg2)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2);
}

// Three parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3);
}

// Four parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4);
}

// Five parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5);
}

// Six parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, TResult>(
    Func<T1, T2, T3, T4, T5, T6, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
}

// Seven parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
}

// Eight parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
}

// Nine paramter func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
}

// Ten parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
}

// Elleven parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11);
}

// Twelve parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12);
}

// Thirteen parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, T13, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13);
}

// Fourteen parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, T13, T14, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13, Arg14);
}

// Fifteen parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, T13, T14, T15, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14, T15 Arg15)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13, Arg14, Arg15);
}

// Sixteen parameter Func tuple.
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, T13, T14, T15, T16, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14, T15 Arg15, T16 Arg16)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
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
