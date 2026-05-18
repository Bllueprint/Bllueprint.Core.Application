using System.Runtime.CompilerServices;

namespace Bllueprint.Core.Application;

public interface IHandlerPipeline<T>
{
    IWithPipeline<T> WithCheck(Func<T, bool> predicate);

    IHandlerPipeline<TNext> Invoke<TNext>(Func<Task<TNext?>> entityTask, [CallerMemberName] string stepName = "");

    IHandlerPipeline<TNext> Invoke<TNext>(Func<T, Task<TNext?>> entityTask, [CallerMemberName] string stepName = "");

    IHandlerPipeline<T> Invoke(Action<T> transition);

    IHandlerPipeline<T> Invoke(Func<Task> guardTask, [CallerMemberName] string stepName = "");

    IHandlerPipeline<T> Invoke(Func<T, Task> entityTask, [CallerMemberName] string stepName = "");

    Task<ICommandResult<T>> ToResultAsync();
}
