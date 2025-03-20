namespace WebApi.Services;

    public static class Helper
    {
        public static string RandomString(int len)
        {
            string pattern = "1234567890qwertyuiopasdfghjklzxcvbnm";
            char[] arr = new char[len];
            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                arr[i] = pattern[random.Next(pattern.Length)];
            }
            return string.Join(string.Empty, arr);
        }
    }
