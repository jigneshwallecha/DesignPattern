using System;
namespace PipelineDesignPattern.Sequence
{
	public class ReverseOperation : IOperation<string>
	{
		public void Invoke(string data) => Console.WriteLine($"The string is reversed: ${data.Reverse()}");
	}
}

