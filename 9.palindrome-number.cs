/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        string strX = x.ToString();
        var reverseX = new string(strX.Reverse().ToArray());
        if (strX == reverseX) {
            return true;
        }
        return false;
    }
}
// @lc code=end