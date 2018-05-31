using System.Collections.Generic;

namespace Intellisense
{
    public class Finder
    {

        private readonly Dictionary<char,List<string>> _classesNamesDictionary;
       // private readonly string[] _classesNames;

        public Finder(string[] classesNames)
        {
            _classesNamesDictionary = new Dictionary<char, List<string>>();
            foreach (var item in classesNames)
            {
                var firstChar = item[0];
                if (_classesNamesDictionary.ContainsKey(firstChar))
                    _classesNamesDictionary[firstChar].Add(item);
                else
                    _classesNamesDictionary.Add(firstChar,new List<string>{item});
                
            }

        }
        public string[] Get(string input)  
        {
            var list = new List<string>();
            var inputSplits = input.SplitCamelCase();

            var firstChar = input[0];

            if (!_classesNamesDictionary.ContainsKey(firstChar))
                return new string[0];

            var classesNames = _classesNamesDictionary[firstChar];

            foreach (var className in  classesNames)
            {
                var splitClassName = className.SplitCamelCase();
                int index = 0;
                bool exists = true;
                foreach (var i in inputSplits)
                {
                    if ( splitClassName.Length <= index || !splitClassName[index].StartsWith(i))
                    {
                        exists = false;
                        break;
                    }

                    index++;
                }
                if(exists)
                    list.Add(className);
            }

            return list.ToArray();
        }
    
    }
}
