public class Node{
    public int Key { get; set; }
    public int Value { get; set; }
    public Node Prev { get; set; }
    public Node Next { get; set; }
    public Node(int key, int val){
        Key = key;
        Value = val;
        Prev = null;
        Next = null;
    }
}
public class LRUCache {
    private Dictionary<int, Node> dict;
    private Node head;
    private Node tail;
    private int capacity;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        dict = new Dictionary<int, Node>();
        head = new Node(0,0);
        tail = new Node(0,0);
        head.Next = tail;
        tail.Prev = head;
    }
    
    public int Get(int key) {
        if(!dict.ContainsKey(key)) return -1;
        Node a = dict[key];
        Remove(a);
        InsertHead(a);
        return a.Value;
    }
    
    public void Put(int key, int value) {
        if(dict.ContainsKey(key)){
            Node a = dict[key];
            a.Value = value;
            Remove(a);
            InsertHead(a);
        }else{
            if(dict.Count == capacity){
                dict.Remove(tail.Prev.Key);
                Remove(tail.Prev);
            }
            dict[key] = new Node(key, value);
            InsertHead(dict[key]);
        }
    }
    public void Remove(Node node){
        node.Next.Prev = node.Prev;
        node.Prev.Next = node.Next;
        node.Next = null;
        node.Prev = null;
    }
    public void InsertHead(Node node){
        node.Next = head.Next;
        head.Next.Prev = node;
        head.Next = node;
        node.Prev = head;
    }
}
