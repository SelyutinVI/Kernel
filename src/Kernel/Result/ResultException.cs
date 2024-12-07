namespace RealBlank.Kernel.Result;

public class ResultException(string error) : Exception($"Attempted to use a result while an error was present. Error: {error}");
