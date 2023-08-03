using PipelineDesignPattern.Sequence;

// build
var pipeline = new Pipeline<string>();

// lambda
pipeline.Register(new Operation<string>(str =>
{
    Console.WriteLine($"The string {str} contains {str.Length} characters");
}));

// class
pipeline.Register(new ReverseOperation());

// execute
pipeline.Invoke("apple");

// the pipeline operations should be registered before the pipeline is invoked.