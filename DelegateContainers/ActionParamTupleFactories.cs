
using SharperHacks.CoreLibs.Interfaces;

namespace SharperHacks.CoreLibs.DelegateContainers;

// Defines ActionParamTuple factories.
//
public abstract partial record ActionParamTuple : IInvoke
{
    // Create ActionParamTuple for single argument action.
    //
    // @T1 Action parameter type.
    //
    // Parameters:
    //  @action
    //  @arg1
    //
    // Returns: @ActionParamTuple, initialized from the supplied arguments.
    //
    public static ActionParamTuple Create<T1>(Action<T1> action, T1 arg1) =>
        new ActionParamTuple<T1>(action, arg1);

    // Create ActionParamTuple for two argument actions.
    public static ActionParamTuple Create<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2) =>
        new ActionParamTuple<T1, T2>(action, arg1, arg2);

    // Create ActionParamTuple for three argument actions.
    public static ActionParamTuple Create<T1, T2, T3>(
        Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3) =>
        new ActionParamTuple<T1, T2, T3>(action, arg1, arg2, arg3);

    // Create ActionParamTuple for four argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4>(
        Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
        new ActionParamTuple<T1, T2, T3, T4>(action, arg1, arg2, arg3, arg4);

    // Create ActionParamTuple for five argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5>(
        Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) =>
        new ActionParamTuple<T1, T2, T3, T4, T5>(action, arg1, arg2, arg3, arg4, arg5);

    // Create ActionParamTuple for six argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6>(
        Action<T1, T2, T3, T4, T5, T6> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6>(action, arg1, arg2, arg3, arg4, arg5, arg6);

    // Create ActionParamTuple for seven argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7>(
        Action<T1, T2, T3, T4, T5, T6, T7> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7>(
            action, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

    // Create ActionParamTuple for eight argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7, T8>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8>(
            action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

    // Create ActionParamTuple for nine argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
        T9 arg9) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

    // Create ActionParamTuple for ten argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, T10>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
        T9 arg9, T10 arg10) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

    // Create ActionParamTuple for elleven argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7,
        T8, T9, T10, T11>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
        T9 arg9, T10 arg10, T11 arg11) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            T11>(
            action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
            arg11);

    // Create ActionParamTuple for twelve argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7,
        T8, T9, T10, T11, T12>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
        T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            T11, T12>(
            action, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
            arg11, arg12);

    // Create ActionParamTuple for thirteen argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7,
        T8, T9, T10, T11, T12, T13>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
        T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            T11, T12, T13>(action,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
            arg11, arg12, arg13);

    // Create ActionParamTuple for fourteen argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7,
        T8, T9, T10, T11, T12, T13, T14>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
        T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            T11, T12, T13, T14>(action,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
            arg11, arg12, arg13, arg14);

    // Create ActionParamTuple for fifteen argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7,
        T8, T9, T10, T11, T12, T13, T14, T15>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
        T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            T11, T12, T13, T14, T15>(action,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
            arg11, arg12, arg13, arg14, arg15);

    // Create ActionParamTuple for sixteen argument actions.
    public static ActionParamTuple Create<T1, T2, T3, T4, T5, T6, T7,
        T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
        T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
        T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) =>
        new ActionParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            T11, T12, T13, T14, T15, T16>(action,
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10,
            arg11, arg12, arg13, arg14, arg15, arg16);
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
