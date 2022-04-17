using BasicConcepts.StateActionsReducersTutorial.Store.CounterUseCase;
using Fluxor;

namespace BasicConcepts.StateActionsReducersTutorial.Store
{
	public class IncrementCounterAction
	{
		public int Step { get; }

		public IncrementCounterAction(int step)
		{
			Step = step;
		}

		[ReducerMethod]
		public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
			new(clickCount: state.ClickCount + action.Step);
	}
}
