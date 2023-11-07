// https://leetcode.com/problems/eliminate-maximum-number-of-monsters

public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        int n = dist.Length;

        // Calculate the time required for each monster to reach the city
        for (int i = 0; i < n; i++) {
            dist[i] = (int)Math.Ceiling(dist[i] / (double)speed[i]);
        }
        Array.Sort(dist);

        int timeElapsed = 0;
        // Check if we can continue to eliminate
        for(int i = 0; i < n; i++) {
            if(timeElapsed >= dist[i]){
                return i;
            }
            timeElapsed++;
        }
        return n;
    }
}
