public class MedianFinder {
    private List<int> list;
    public MedianFinder() {
        list = new List<int>();
    }
    
    public void AddNum(int num) {
        list.Add(num);
    }
    
    public double FindMedian() {
        int n = list.Count;
        list.Sort();
        if(n % 2 == 1){
            return list[n/2];
        }else{
            double res = (list[n/2 - 1] + list[n/2])/2.0;
            return res;
        }
    }
}
