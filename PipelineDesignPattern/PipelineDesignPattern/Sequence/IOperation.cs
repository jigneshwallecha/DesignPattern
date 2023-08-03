
using System;
namespace PipelineDesignPattern.Sequence
{
	/**
	 * The interface of an operation can be invoked to process data
	 */
	public interface IOperation<T>
	{
		void Invoke(T data);
	}
}

