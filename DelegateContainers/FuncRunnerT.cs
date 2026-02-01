// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.Constraints;

namespace SharperHacks.CoreLibs.DelegateContainers;

// Stores a list of @FuncParamTuple<TResult> for later execution.
//
public record FuncRunner<TResult>
{
    // Get the list of IFuncParamTuples.
    public List<FuncParamTuple<TResult>> FuncParamTuples { get; init; }

    // Constructor.
    //
    // Parameters:
    //  @funcParamTuples
    public FuncRunner(params FuncParamTuple<TResult>[] funcParamTuples)
    {
        Verify.AreNotNull(funcParamTuples);

        FuncParamTuples = new(funcParamTuples);
    }

    // Sequentially invoke the @FuncParamTuples and discard the results.
    public void Run()
    {
        foreach (var tuple in FuncParamTuples)
        {
            _ = tuple.Invoke();
        }
    }

    // Sequentially invoke all the FuncParamTuples, using <paramref name="eval"/>
    // to determine success or failure across the entire run.
    //
    // @eval
    //  A delegate type taking TResult and retruning true if the result of Invoke()
    //  is considered a success, false otherwise.
    //
    // Returns:
    //  The number of times <paramref name="eval"/> returned false.
    //
    public int Run(Func<TResult, bool> eval)
    {
        Verify.IsNotNull(eval);

        var failCount = 0;

        foreach(var tuple in FuncParamTuples)
        {
            if (!eval(tuple.Invoke())) failCount++;
        }

        return failCount;
    }

    // Sequentially invoke all the FuncParamTuples, storing and returning
    // the results in the <paramref name="results"/> parameter.
    //
    // Parameters:
    //  @results
    //
    public List<TResult> Run(List<TResult> results)
    {
        foreach (var tuple in FuncParamTuples)
        {
            results.Add(tuple.Invoke());
        }

        return results;
    }

    // Run the FuncParamTuple at index @idx and return the result.
    //
    // Parameters:
    //  @idx
    //
    public TResult Run(int idx)
    {
        return FuncParamTuples[idx].Invoke();
    }
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
