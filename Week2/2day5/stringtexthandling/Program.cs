using System.Text;


////consntructing string

//// nyari char di index string
// Console.WriteLine ("abcd,cd, ef".IndexOfAny (new char[] {'c', 'd'} ));

// Console.Write ("pa5w0555rd".IndexOfAny ("0".ToCharArray() ));

using spellwordsclass;

spellwords sw1 = new spellwords();

string sentence = Console.ReadLine();
string word = Console.ReadLine();

// char[] kata = sw1.spelling(word);

// search word

// bool searchword = sw1.searchwordinsentence(sentence, word);

// Console.WriteLine(searchword);


////sentence builder

StringBuilder word2 = Console.ReadLine();

StringBuilder sentenceBuilder = sw1.sentenceBuilder(word2, word2);

Console.WriteLine(sentenceBuilder);

