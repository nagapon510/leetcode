/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++) {
            for(int j = i + 1; j < nums.Length; j++) {
                if(nums[i] + nums[j] == target) {
                    return new int[] {i,j};
                }
            }
        }
        return null;
    }
}


//LINQ検証中
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numsList = nums.toList();
        numsList.where(i, j => nums[i] + nums[j] == target);
        return new int[] {i,j};
    }
}
// @lc code=end

