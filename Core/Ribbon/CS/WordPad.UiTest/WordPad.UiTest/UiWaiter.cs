// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace WordPad.UiTest
{
    /// <summary>
    /// Provides utility methods for waiting until a specified condition is met within a given timeout period.
    /// </summary>
    public static class UiWaiter
    {
        /// <summary>
        /// Repeatedly evaluates the specified condition until it returns <see langword="true"/>
        /// or the timeout period expires.
        /// </summary>
        /// <param name="condition">
        /// A delegate that evaluates the condition to wait for.
        /// </param>
        /// <param name="timeout">
        /// The maximum amount of time to wait for the condition to become <see langword="true"/>.
        /// </param>
        /// <param name="interval">
        /// The time to wait between successive evaluations of <paramref name="condition"/>.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if the condition is met before the timeout expires;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public static bool Until(
            Func<bool> condition,
            TimeSpan timeout,
            TimeSpan interval)
        {
            var endTime = DateTime.UtcNow + timeout;

            while (DateTime.UtcNow < endTime)
            {
                if (condition())
                    return true;

                Thread.Sleep(interval);
            }

            return false;
        }
    }
}
