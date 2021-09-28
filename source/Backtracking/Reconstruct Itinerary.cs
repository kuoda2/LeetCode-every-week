 public class Solution{
        private Dictionary<string, SortedDictionary<string, int>> map;
        private IList<string> result;

        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            result = new List<string>();
            map = new Dictionary<string, SortedDictionary<string, int>>();
            foreach (var ticket in tickets)
            {
                if (map.ContainsKey(ticket[0]) && map[ticket[0]].ContainsKey(ticket[1]))
                {
                    map[ticket[0]][ticket[1]]++;
                }
                else if (map.ContainsKey(ticket[0]))
                {
                    map[ticket[0]][ticket[1]] = 1;
                }
                else
                {
                    map[ticket[0]] = new SortedDictionary<string, int> { { ticket[1], 1 } };
                }
            }
            result.Add("JFK");
            BackTracking(tickets.Count + 1);
            return result;
        }

        public bool BackTracking(int leftCount)
        {
            if (result.Count == leftCount)
            {
                return true;
            }

            foreach (var item in map)
            {
                if (item.Key == result.Last())
                {
                    foreach (var target in item.Value.ToDictionary(x => x.Key, x => x.Value))
                    {
                        if (target.Value > 0)
                        {
                            result.Add(target.Key);
                            item.Value[target.Key]--;
                            if (BackTracking(leftCount))
                                return true;
                            result.RemoveAt(result.Count - 1);
                            item.Value[target.Key]++;
                        }
                    }
                }
            }
            return false;
        }
}
