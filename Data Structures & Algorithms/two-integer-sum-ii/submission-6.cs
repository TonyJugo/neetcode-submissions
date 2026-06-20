public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //điều kiện bài này là O(1) space complexity, tạo hashmap là O(n) => sai constraint đề bài
        //1.hashmap - two pass
        // Dictionary<int,int> dict = new Dictionary<int,int>();
        // for(int i = 0; i < numbers.Length; i++){
        //     dict[numbers[i]] = i;
        // }
        // for(int i = 0; i < numbers.Length; i++){
        //     int diff = target - numbers[i];
        //     if(dict.ContainsKey(diff)){
        //         return [Math.Min(dict[diff],i)+1, Math.Max(dict[diff],i)+1];
        //     }
        // }
        // return [];
        //2.hash map - one pass
        // Dictionary<int,int> dict = new Dictionary<int,int>();
        // for(int i = 0; i < numbers.Length; i++){
        //     int diff = target - numbers[i];
        //     if(dict.ContainsKey(diff)){
        //         return [Math.Min(dict[diff]+1,i+1),Math.Max(dict[diff]+1,i+1)];
        //     }
        //     dict[numbers[i]] = i;
        // }
        // return [];
        //do bài đã cho dữ kiện space complexity là O(1) và array đã sort nên ta có thể dùng two pointer
        //O(n) - O(1)
        //3*. two pointers 
        // int i =  0;
        // int j = numbers.Length-1;
        // while(i < j){
        //     int sum = numbers[i] + numbers[j];
        //     if(sum == target){
        //         return [i+1,j+1];
        //     }else if(sum > target){
        //         j--;
        //     }else{
        //         i++;
        //     }
        // }
        // return [];
        //4. binary search O(nlogn)
        for(int i = 0; i < numbers.Length; i++){
            int diff = target - numbers[i];
            int l = i+1;
            int r = numbers.Length-1;
            while(l <= r){
                int mid = l + ((r-l)/2);
                if(numbers[mid] == diff){
                    return [i+1, mid+1];
                }else if(numbers[mid] < diff){
                    l = mid + 1;
                }else{
                    r = mid - 1;
                }
            }
        }
        return [];
    }
}
