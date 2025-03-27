using System.Security.Cryptography;
using System.Text;

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
        public static string? Upload(IFormFile f, string root)
        {
            if (f is null)
                return null;

            string ext = Path.GetExtension(f.FileName);
            string fileName = RandomString(32 - ext.Length) + ext;
            string path = Path.Combine(root, fileName);

            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                f.CopyTo(stream);
            }

            return fileName;
        }

        public static string? Upload(IFormFile f)
        {
            return Upload(f, Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images"));
        }

        public static IEnumerable<string>? Upload(IFormFile[] af, string root)
        {
            if (af is null)
                return null;

            List<string> list = new List<string>(af.Length);
            foreach (var f in af)
            {
                string? fileName = Upload(f, root);
                if (fileName != null)
                {
                    list.Add(fileName);
                }
            }

            return list;
        }

        public static IEnumerable<string>? Upload(IFormFile[] af)
        {
            return Upload(af, Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images"));
        }
        public static byte[] Hash(string plaintext)
        {
            using (SHA256 algorithm = SHA256.Create())
            {
                return algorithm.ComputeHash(Encoding.ASCII.GetBytes(plaintext));
            }
        }

    }
