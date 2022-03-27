using System.Collections.Generic;
using System.Linq;

namespace ReGoap.Core
{
    public class ReGoapPlan<T, W> : Queue<ReGoapActionState<T, W>>
    {
        public ReGoapActionState<T, W> Next => this.Any() ? this.Peek() : null;

        public W GetNextState(T key)
        {
            W value = default;
            foreach (var actionState in this)
            {
                if (actionState.Settings.TryGetValue(key, out value))
                    return value;
            }

            return value;
        }
    }
}