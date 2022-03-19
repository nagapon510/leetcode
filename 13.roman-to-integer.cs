/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start

using System;
using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        var romanTable = new Dictionary<string, int>() {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000},
            {"IV", 4},
            {"IX", 9},
            {"XL", 40},
            {"XC", 90},
            {"CD", 400},
            {"CM", 900}
        };
        Nullable<int> charS = romanTable[s];
        if (charS.HasValue == true){
            return romanTable[s];
        }

        int sLength = s.Length;




        return romanTable[s];
    }
}
// @lc code=end

