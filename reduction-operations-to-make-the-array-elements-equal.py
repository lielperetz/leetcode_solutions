// https://leetcode.com/problems/reduction-operations-to-make-the-array-elements-equal

class Solution(object):
    def reductionOperations(self, nums):
        max_size = 5 * 10 ** 4 + 1
        
        # Initialize an array to store the frequency of each number
        freq = [0] * max_size

        # Initialize counters for total operations and current counter
        for num in nums:
            freq[num] += 1

        counter = res = 0
        # Iterate through the array in reverse order
        for i in range(50000, 0, -1):
            if freq[i] > 0:
                # Increment the total operations counter and update the result
                counter += freq[i]
                res += counter - freq[i]
        
        return res
