using System;
namespace PipelineDesignPattern.CircuitBreaker
{
	public class Pipeline<T> : IOperation<T>
	{
        public readonly List<IOperation<T>> _operations = new List<IOperation<T>>();

        // add/register operation at the end of the pipeline
        public void Register(IOperation<T> operation)
        {
            _operations.Add(operation);
        }

        // if an operation fails, the pipeline execution should stop.
        public bool Invoke(T data)
        {
            foreach (var operation in _operations)
            {
                if (!operation.Invoke(data))
                {
                    Console.WriteLine("Aborting pipeline....");
                    return false;
                }
            }
            return true;
        }
	}
}

