public class TimeMap {
    // private Dictionary<string, Dictionary<int, string>> dict = new Dictionary<string, Dictionary<int, string>>();
    private readonly Dictionary<string, List<Tuple<int,string>>> dict = null;
    public TimeMap() {
        // dict = new Dictionary<string, Dictionary<int, string>>();        
        dict = new Dictionary<string, List<Tuple<int,string>>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        // if(!dict.ContainsKey(key)){
        //     dict[key] = new Dictionary<int,string>(){ {timestamp, value} };     
        // }
        // dict[key][timestamp] = value;
        if(!dict.ContainsKey(key)){
            dict[key] = new List<Tuple<int, string>>();
        }
        dict[key].Add(Tuple.Create(timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        // if(dict.ContainsKey(key)){
        //     if(dict[key].ContainsKey(timestamp)){
        //         return dict[key][timestamp];
        //     }else{
        //         while(timestamp > 0 && !dict[key].ContainsKey(timestamp)){
        //             timestamp--;
        //         }
        //         if(dict[key].ContainsKey(timestamp)) return dict[key][timestamp];
        //     }
        // }
        // return string.Empty;
        if(!dict.ContainsKey(key)){
            return string.Empty;
        }
        int l = 0;
        var list = dict[key];
        int r = dict[key].Count-1;
        string res = "";
        while(l <= r){
            int mid = l + (r-l)/2;
            if(list[mid].Item1 < timestamp){
                res = list[mid].Item2;
                l = mid + 1;
            }else if(list[mid].Item1 > timestamp){
                r = mid - 1;
            }else{
                return list[mid].Item2;
            }
        }
        return res;
    }
}
