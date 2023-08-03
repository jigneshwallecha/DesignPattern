using System;
namespace PipelineDesignPattern.Sequence
{
	/**
	 * The pipeline processes each operation one by one. 
	 */
	public class Pipeline<T> : IOperation<T>
	{
		public readonly List<IOperation<T>> _operations = new List<IOperation<T>>();

		// add/register operation at the end of the pipeline
		public void Register(IOperation<T> operation)
		{
			_operations.Add(operation);
		}

		// invoke every operations
		public void Invoke(T data)
		{
			foreach (var operation in _operations) operation.Invoke(data);
 		}
	}
}

