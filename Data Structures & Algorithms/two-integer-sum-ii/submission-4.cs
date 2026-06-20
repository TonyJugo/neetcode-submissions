public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //điều kiện bài này là O(1) space complexity, tạo hashmap là O(n) => sai constraint đề bài
        //hashmap - two pass
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
        //hash map - one pass
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
        int i =  0;
        int j = numbers.Length-1;
        while(i < j){
            int sum = numbers[i] + numbers[j];
            if(sum == target){
                return [i+1,j+1];
            }else if(sum > target){
                j--;
            }else{
                i++;
            }
        }
        return [];
    }
}
