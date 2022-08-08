namespace CountryInfoAPILibrary.Models
{
    /// <summary>
    /// Результат выполнения/Ответ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Responce<T>
    {
        /// <summary>
        /// Результат выполнения
        /// </summary>
        public T? Result { get; set; }

        /// <summary>
        /// Обработанное исключение
        /// </summary>
        public Exception? HandledException { get; set; }

        /// <summary>
        /// Есть ли исключение
        /// </summary>
        public bool HasErrors => HandledException != null;

        /// <summary>
        /// Есть ли результат
        /// </summary>
        public bool HasResult => Result != null;

        /// <summary>
        /// Ответ
        /// </summary>
        /// <param name="result">Результат выполнения</param>
        /// <param name="exceptions">Исключение</param>
        public Responce(T? result, Exception? exception)
        {
            Result = result;
            HandledException = exception;
        }
    }
}
