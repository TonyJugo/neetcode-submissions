public class Twitter {
    private Dictionary<int, List<Tweet>> dict;
    private Dictionary<int, HashSet<int>> dict2;
    private int globalTimestamp = 0;
    private class Tweet{
        public int tweetId { get; set; }
        public int timestamp { get; set; }
        public Tweet(int tweetId, int timestamp){
            this.tweetId = tweetId;
            this.timestamp = timestamp;
        }
    }
    public Twitter() {
        dict = new Dictionary<int, List<Tweet>>();
        dict2 = new Dictionary<int, HashSet<int>>();
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!dict.ContainsKey(userId)){
            dict[userId] = new List<Tweet>();
        }
        dict[userId].Add(new Tweet(tweetId, globalTimestamp++));
    }
    
    public List<int> GetNewsFeed(int userId) {
        //lay het tweet cua userid kem tweet cua followee
        HashSet<int> set = new HashSet<int>(){ userId};
        if(dict2.ContainsKey(userId)){
            foreach(int followeeId in dict2[userId]){
                set.Add(followeeId);
            }
        }
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        foreach(int id in set){
            if(dict.ContainsKey(id)){
                foreach(Tweet tweet in dict[id]){
                    queue.Enqueue(tweet.tweetId, -tweet.timestamp);
                }
            }
        }
        List<int> res = new List<int>();
        while(queue.Count > 0 && res.Count < 10){
            res.Add(queue.Dequeue());
        }
        return res;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(followerId == followeeId) return;
        if(!dict2.ContainsKey(followerId)){
            dict2[followerId] = new HashSet<int>();
        }
        dict2[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(followerId == followeeId) return;
        if(!dict2.ContainsKey(followerId)) return;
        dict2[followerId].Remove(followeeId);
    }
}
