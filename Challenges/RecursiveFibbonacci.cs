        /// <summary>
        /// Returns the nth Fibbornaci number.
        /// Fn = Fn-1 + Fn-2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static public long fib(int n)
        {
            if (n - 2 <= 0)
            {
                return 1;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }