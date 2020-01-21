namespace LongestPalindrome
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {

            var longestPalindrome = string.Empty;

            for (var i = 0; i < s.Length && s.Length - i > longestPalindrome.Length / 2; i++)
            {
                var left = i;

                var right = i;

                while (right + 1 < s.Length && s[right + 1] == s[left])
                    right++;

                var expansion = (longestPalindrome.Length - right + left) / 2;

                while (left - expansion >= 0 && right + expansion <= s.Length - 1 && this.IsPalindrome(s.Substring(left - expansion, right + 2 * expansion - left + 1)))
                {
                    longestPalindrome = s.Substring(left - expansion, right + 2 * expansion - left + 1);
                    expansion++;
                }
            }
            return longestPalindrome;
        }

        public bool IsPalindrome(string s)
        {
            for (var i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
