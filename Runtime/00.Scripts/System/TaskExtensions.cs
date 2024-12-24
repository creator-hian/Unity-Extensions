using System.Threading;
using System.Threading.Tasks;

namespace Hian.Extensions
{
    public static class TaskExtensions
    {
        public static async Task<T> WithCancellation<T>(
            this Task<T> task,
            CancellationToken cancellationToken
        )
        {
            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>(); // 불필요한 bool 대신 object 사용
            using (
                cancellationToken.Register(
                    static s => ((TaskCompletionSource<object>)s).TrySetResult(null),
                    tcs
                )
            )
            {
                if (task != await Task.WhenAny(task, tcs.Task))
                {
                    throw new TaskCanceledException(task); // OperationCanceledException 대신 TaskCanceledException 사용
                }
            }

            return await task;
        }
    }
}
