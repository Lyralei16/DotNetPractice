public class Solution {
    
    public int[] TwoSum(int[] nums, int target) {
        
        int result = 0;
        int i, j;
        for (j = nums.Length; j > 0; j--){
            
            for (i = 0; i < nums.Length; i++){
                int sum = nums[i] + nums[j];
                if (sum != target){
                    i--;
                } 
                else{
                    result = sum;
                }
            }
        }
        return target;
    }
}

//
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].