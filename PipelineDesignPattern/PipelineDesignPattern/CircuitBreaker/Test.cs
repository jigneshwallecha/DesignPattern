namespace PipelineDesignPattern.CircuitBreaker
{
	class A
	{
		
	}

	public static class Test
	{
		public static void Run()
		{
            // build
            var pipeline = new Pipeline<A>();

			// register
			pipeline.Register(new CheckNotNullOperation<A>());

			A a = null;

			pipeline.Invoke(a);
        }
	}
}

