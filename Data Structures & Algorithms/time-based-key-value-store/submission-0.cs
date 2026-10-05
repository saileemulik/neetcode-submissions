public class TimeMap
{
    private Dictionary<string, List<(int timestamp, string value)>> dict;

    public TimeMap()
    {
        dict = new Dictionary<string, List<(int timestamp, string value)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!dict.ContainsKey(key))
        {
            dict[key] = new List<(int timestamp, string value)>();
        }

        dict[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!dict.ContainsKey(key))
        {
            return "";
        }

        var values = dict[key];

        int left = 0;
        int right = values.Count - 1;
        string res = "";

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (values[mid].timestamp <= timestamp)
            {
                res = values[mid].value;

                // Try finding a later valid timestamp
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return res;
    }
}