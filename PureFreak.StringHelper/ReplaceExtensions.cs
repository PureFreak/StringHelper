namespace System
{
    public static class ReplaceExtensions
    {
        #region Extension method

        public static string ReplaceIgnoreCase(this string input, string oldValue, string newValue, bool replaceGlobal = true)
        {
            if (input == null)
                return null;

            var result = input;

            if (!replaceGlobal)
            {
                var index = input.IndexOf(oldValue, 0, StringComparison.OrdinalIgnoreCase);
                if (index != -1)
                {
                    result = result.Remove(index, oldValue.Length);
                    result = result.Insert(index, newValue);
                }
            }
            else
            {
                int index;
                int startIndex = input.Length;

                do
                {
                    index = result.LastIndexOf(oldValue, startIndex, StringComparison.OrdinalIgnoreCase);
                    if (index != -1)
                    {
                        result = result.Remove(index, oldValue.Length);
                        result = result.Insert(index, newValue);
                    }

                    startIndex = index;
                } while (index != -1 && replaceGlobal);
            }

            return result;
        }

        #endregion
    }
}