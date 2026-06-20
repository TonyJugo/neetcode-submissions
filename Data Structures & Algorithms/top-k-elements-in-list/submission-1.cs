 class Solution {
   public int[] TopKFrequent(int[] nums, int k) {
        //1 sort O(nlogn)
        // var dict = new Dictionary<int,int>();
        // for(int i = 0; i < nums.Length; i++){
        //     dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;
        // }
        // //var list = dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
        // List<int[]> list = dict.Select(kv => new int[2] {kv.Key, kv.Value}).ToList();
        // list.Sort((a,b) => b[1].CompareTo(a[1]));
        // int[] result = new int[k];
        // //tìm frequency max và trả về key
        // for(int i = 0; i < k; i++){
        //     result[i] = list[i][0];
        // }
        // return result;
        //2.min heap O(nlogk)
        // var dict = new Dictionary<int,int>();
        // for(int i = 0; i < nums.Length; i++){
        //     if(dict.ContainsKey(nums[i])){
        //         dict[nums[i]]++;
        //     }else{
        //         dict[nums[i]] = 1;   
        //     }
        // }
        // var heap = new PriorityQueue<int,int>();
        // foreach(var kv in dict){
        //     heap.Enqueue(kv.Key, kv.Value);
        //     if(heap.Count > k){
        //         heap.Dequeue();
        //     }
        // }
        // int[] result = new int[k];
        // for(int i = 0; i < k; i++){
        //     result[i] = heap.Dequeue();
        // }
        // return result;

        //3. bucket sort O(n)
        //ý tưởng bỏ frequency vào giỏ
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;
        }
        List<int>[] freqs = new List<int>[nums.Length + 1];
        for(int i = 0; i < freqs.Length; i++){
            freqs[i] = new List<int>();
        }
        foreach(var kv in dict){
            freqs[kv.Value].Add(kv.Key);
        }

        int[] res = new int[k];
        int c = 0;
        for(int i = freqs.Length-1; i >= 0; i--){
            foreach(var num in freqs[i]){
                res[c] = num;
                c++;
                if(c == k){
                    return res;
                }
            }  
        }
        return [0];
    }
}
