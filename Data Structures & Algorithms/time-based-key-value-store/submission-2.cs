public class TimeMap {
    private Dictionary<string, Dictionary<int, string>> dict = new Dictionary<string, Dictionary<int, string>>();
    public TimeMap() {
        dict = new Dictionary<string, Dictionary<int, string>>();        
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!dict.ContainsKey(key)){
            dict[key] = new Dictionary<int,string>(){ {timestamp, value} };     
        }
        dict[key][timestamp] = value;
    }
    
    public string Get(string key, int timestamp) {
        if(dict.ContainsKey(key)){
            if(dict[key].ContainsKey(timestamp)){
                return dict[key][timestamp];
            }else{
                while(timestamp > 0 && !dict[key].ContainsKey(timestamp)){
                    timestamp--;
                }
                if(dict[key].ContainsKey(timestamp)) return dict[key][timestamp];
            }
        }
        return string.Empty;
    }
}
