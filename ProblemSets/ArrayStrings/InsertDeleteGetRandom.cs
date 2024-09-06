using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSets.ArrayStrings.RandomizedSet
{
    public class RandomizedSet
    {
        private List<int> _cache;
        private Dictionary<int, int> _index;
        private Random rand;

        public RandomizedSet()
        {
            //Instantiate
            _cache = new List<int>();
            _index = new Dictionary<int, int>();
            rand = new Random();
        }

        public bool Insert(int val)
        {
            //Check if val exists in Dictionary
            if (_index.TryGetValue(val, out int value)) return false;
            //Otherwise add val to dictionary and list
            _cache.Add(val);
            //Key = val and Value = index - hashset
            _index[val] = _cache.Count - 1;
            return true;
        }

        public bool Remove(int val)
        {
            //Check if val does not exist in Dictionary
            if (!_index.TryGetValue(val, out int value)) return false;
            //Otherwise remove from dictionary and list
            if (_cache[_cache.Count - 1] != val)
            {
                int lastEl = _cache[_cache.Count - 1];
                int valIndex = value;

                //Update the last el to the val position in both dictionary and list
                _cache[valIndex] = lastEl;
                _index[lastEl] = valIndex;

                _cache.RemoveAt(_cache.Count - 1);
                _index.Remove(val);
            }
            else
            {
                _cache.RemoveAt(_cache.Count - 1);
                _index.Remove(val);
            }
            return true;
        }

        public int GetRandom()
        {
            int randomIndex = rand.Next(_cache.Count);
            return _cache[randomIndex];
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
