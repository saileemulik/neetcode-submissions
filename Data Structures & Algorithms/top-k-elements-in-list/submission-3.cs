public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] res = new int[k];
        // int idx = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            if(!dict.ContainsKey(num))
            {
                dict[num] = 0;
            }
            dict[num] += 1;
        }
       PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
       foreach(var item in dict)
       {
        pq.Enqueue(item.Key, -item.Value);
       }
       for(int i=0;i<k; i++)
       {
        res[i] = pq.Dequeue();
       }
        return res;
    }
}
