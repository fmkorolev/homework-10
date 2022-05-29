//Задача 1
/*
int VowelCount(string[] array)
{
    int count = 0;
    char[] vowels = "aeiouy".ToCharArray();
    foreach(string word in array)
        foreach(char letter in vowels)
            if(word.ToLower().StartsWith(letter))
                count++;
    return count;
}
string[] firstTaskArray1 = { "qwe", "wer", "ert", "rty", "tyu"};
Console.Write("{" + string.Join(", ", firstTaskArray1) + "} -> ");
Console.WriteLine(VowelCount(firstTaskArray1));
Console.WriteLine();
string[] firstTaskArray2 = { "ewq", "wer", "Ert", "ytr", "tyu"};
Console.Write("{" + string.Join(", ", firstTaskArray2) + "} -> ");
Console.WriteLine(VowelCount(firstTaskArray2));
Console.WriteLine();
*/

// Задача 2

string[] PairConcat(string[] array)
{
    int arLen = array.Length / 2 + array.Length % 2;
    string[] outArray = new string[arLen];
    for(int i = 0, j = 0; i < array.Length - 1; i += 2, j++)
    {
        outArray[j] = (array[i] + array[i + 1]);
        if(array.Length % 2 != 0 && j == arLen - 2)
        {
            outArray[arLen - 1] = array[array.Length-1];
            break;
        }
    }
    return outArray;
}
string[] testArray = { "qwe", "wer",
                       "ert", "rty",
                       "tyu", "yui"};
string[] testArray2 = { "qwe", "wer",
                        "ert", "rty", 
                        "tyu", "yui", 
                        "END"  
                     };
string[] testArray3 = { "Di", "an",
                        "AL", "ex", 
                        "Fil", "lip", 
                        "Max", "im",
                        "Sis", "ter", 
                        "Ke", "vin", 
                        "Jo", "hn",
                        "Ru", "ben", 
                        "Gab", "riel", 
                        "Jo", "e",
                        "Gle", "ndale", 
                        "Gen", "dalf",  
                        "Ja", "ck",
                        "Pam", "ela", 
                        "Mos", "cow", 
                        "Dip", "polog",
                        "Man", "ila", 
                        "Ce", "bu", 
                        "END"  
                     };
Console.WriteLine("{\"" + string.Join("\", \"", testArray)+ "\"" + " -> " + "\"" + string.Join("\", \"", PairConcat(testArray)) + "\"}");
Console.WriteLine();
Console.WriteLine("{\"" + string.Join("\", \"", testArray2)+ "\"" + "} -> {" + "\"" + string.Join("\", \"", PairConcat(testArray2)) + "\"}");
Console.WriteLine();
Console.WriteLine("{\"" + string.Join("\", \"", testArray3)+ "\"" + "} \n {" + "\"" + string.Join("\", \"", PairConcat(testArray3)) + "\"}");
