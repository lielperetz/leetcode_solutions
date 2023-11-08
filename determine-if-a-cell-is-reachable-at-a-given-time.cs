// https://leetcode.com/problems/determine-if-a-cell-is-reachable-at-a-given-time/

public class Solution {
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t) {
        if(sx == fx && sy == fy && t == 1) return false;
        return Math.Max(Math.Abs(fx - sx), Math.Abs(fy - sy)) <= t;
    }
}
