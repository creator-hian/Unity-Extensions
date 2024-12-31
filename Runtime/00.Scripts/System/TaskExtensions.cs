using System;
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
            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            using (
                cancellationToken.Register(
                    static s => ((TaskCompletionSource<object>)s).TrySetResult(null),
                    tcs
                )
            )
            {
                if (task != await Task.WhenAny(task, tcs.Task))
                {
                    throw new TaskCanceledException(task);
                }
            }

            return await task;
        }

        /// <summary>
        /// 태스크를 잊어버리도록 표시합니다. 이는 태스크에서 발생하는 모든 예외가 캐치되고 처리됨을 의미합니다.
        /// </summary>
        /// <param name="task">잊어버릴 태스크입니다.</param>
        /// <param name="onException">예외가 발생했을 때 실행할 선택적 액션입니다. 제공된 경우 예외가 다시 발생하지 않습니다.</param>
        public static async void Forget(this Task task, Action<Exception> onException = null)
        {
            try
            {
                await task;
            }
            catch (Exception exception)
            {
                if (onException == null)
                    throw exception;

                onException(exception);
            }
        }
    }
}
