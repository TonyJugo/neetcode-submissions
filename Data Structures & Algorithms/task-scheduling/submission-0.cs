public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        // xu ly task tan suat xuat hien cao nhat truoc
        int[] count = new int[26];
        for(int i = 0; i < tasks.Length; i++){
            count[tasks[i]-'A']++;
        }
        //xai max heap de luu count cua task tan suat lon nhat
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        foreach(int num in count){
            if(num > 0) queue.Enqueue(num, -num);
        }
        int totalCycle = 0;
        while(queue.Count > 0){
            //list cooldown
            List<int> list = new List<int>();
            //block quan ly chu ky
            for(int i = 0; i < n+1; i++){
                if(queue.Count > 0){
                    int currentCount = queue.Dequeue();
                    currentCount--;
                    totalCycle++;
                    //them vao list cooldown de lat them lai vao queue
                    if(currentCount > 0){
                        list.Add(currentCount);
                    }
                //het tac vu thi de la idle ( co nghia la con task trong list cooldown)
                }else{
                    if(list.Count > 0) totalCycle++;
                }
            }
            //het block chu ky ta them list cooldown vao lai queue
            foreach(int num in list){
                queue.Enqueue(num, -num);
            }
        }
        return totalCycle;
    }
}
