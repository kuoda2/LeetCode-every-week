public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int area = 0;
        
        while(left != right){
            var weight = (right - left);
            var depth = 0;
            if(height[left] > height[right]){
                depth = height[right];
                right--;
            }
            else{
                depth = height[left];
                left++;
            }
            if(weight * depth > area)
                area = weight * depth;
        }
        return area;
    }
}
