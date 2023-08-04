using System;
namespace PipelineDesignPattern.CircuitBreaker
{
	/// <summary>
	/// Each operation will return the result: fail or sucess
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IOperation<T>
	{
		bool Invoke(T data);
	}
}

