using System;
namespace PipelineDesignPattern.Sequence
{
	// a wrapper to automatically create an operation from a lambda
	public class Operation<T> : IOperation<T>
	{
		private readonly Action<T> action;

		public Operation(Action<T> action)
		{
			this.action = action;
		}

		public void Invoke(T data) => action(data);
	}
}

