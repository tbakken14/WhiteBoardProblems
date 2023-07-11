using System.Collections.Generic;

namespace Project {
    public class Anagram {
        public static bool isAnagram(string word1, string word2) {
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < word1.Length; i++) {
                char c = word1[i];
                if (!d.ContainsKey(c)) {
                    d[c] = 0;
                }
                d[c]++;
            }
            for (int i = 0; i < word2.Length; i++) {
                char c = word2[i];
                if (!d.ContainsKey(c)) {
                    return false;
                }
                d[c]--;
                if (d[c] == 0) {
                    d.Remove(c);
                }
            }
            return d.Count == 0;
        }
    }
}