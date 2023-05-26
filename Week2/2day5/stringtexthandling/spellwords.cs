using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace spellwordsclass;


	public class spellwords
	{
		public string word;
		
		
		public char[] spelling(string word)
		
		{
			char[] char1 = word.ToCharArray();
			return char1;
			
		}
		
		public bool searchwordinsentence(string sentence, string word)
		
		{
			return sentence.Contains(word);
		}
		
		public StringBuilder sentenceBuilder(StringBuilder word1, StringBuilder word2)
		
		{
			
			StringBuilder sentence = word1.Append(word1);
			// StringBuilder sentence = word2.Append(word2);
			return sentence;
		}
		
		
	}
