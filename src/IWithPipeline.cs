namespace Bllueprint.Core.Application;

public interface IWithPipeline<T>
{
    IWithPipeline<T> WithMessage(string message);

    IHandlerPipeline<TNext> Invoke<TNext>(Func<Task<TNext?>> entityTask);

    IHandlerPipeline<TNext> Invoke<TNext>(Func<T, Task<TNext?>> entityTask);

    IHandlerPipeline<T> Invoke(Action<T> transition);

    IHandlerPipeline<T> Invoke(Func<Task> guardTask);

    IHandlerPipeline<T> Invoke(Func<T, Task> entityTask);

    Task<ICommandResult<T>> ToResultAsync();
}
