using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Hian.Extensions
{
    public static class AsyncOperationExtensions
    {
        /// <summary>
        /// Converts a Unity AsyncOperation to a Task.
        /// </summary>
        public static Task AsTask(this AsyncOperation asyncOp)
        {
            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();

            asyncOp.completed += (operation) =>
            {
                if (asyncOp.isDone)
                {
                    tcs.SetResult(null);
                }
                else
                {
                    tcs.SetException(
                        new Exception($"AsyncOperation failed to complete. {asyncOp}")
                    );
                }
            };

            return tcs.Task;
        }
    }
}
