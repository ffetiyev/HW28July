
//string name = "Farid";

//string surname = "Fatiyev";

//string fullname = name + " " + surname;

//string fullname = $"{name} {surname}";

//Console.WriteLine(fullname);

//Console.WriteLine(name.Length);

//Console.WriteLine(name.ToLower());

//Console.WriteLine(name.ToUpper());

//string word = "";
//string word = string.Empty;



//Console.WriteLine(word.Trim());
//Console.WriteLine(word.TrimStart());
//Console.WriteLine(word.TrimEnd());

//string word2 = "azerbaycan";

//Console.WriteLine(word.Trim().ToLower()==word2);

//Console.WriteLine(word.Contains("gozel"));

//string[] datas=word.Split(" ");

//for (int i = 0; i < datas.Length; i++)
//{
//    if (datas[i] == "gozel")
//    {
//        Console.WriteLine(true);
//        break;
//    }

//}



//Console.WriteLine(word.Substring(0,7));

//Console.WriteLine(word.Substring(0, 7) + "...");

//Console.WriteLine(word.Substring(0, 7) + "..." + "For read more click 5");

//string number=Console.ReadLine();

//if(number == "5")
//{
//    Console.WriteLine(word);
//}

//string[] students = { "Nizami", "Fuad", "Oruc", "Ferid", "Mehemmed", "Turan" };

//string names = string.Join("-", students);

//Console.WriteLine(names);

//Console.WriteLine(students.GetType());

//string word = "Azerbaycan gozel olkedir";

//Console.WriteLine(word.StartsWith("Az"));

//var res = word.Replace("gozel","mukemmel");

//Console.WriteLine(res);

//static int GetCountOfStrWithCondition(string[] words,string pattern)
//{
//    int count = 0;
//    for (int i = 0; i < words.Length; i++)
//    {
//        if (words[i].ToLower().StartsWith(pattern.ToLower()))
//        {
//            count++;
//        }
//    }
//    return count;
//}

//string[] words = { "Aztest", "azyes", "testtest", "salamaz" };

//Console.WriteLine(GetCountOfStrWithCondition(words,"az"));



//int[] nums2 = new int[5];

//int[] nums3= new int[6] {1,2,3,4,5,6};

//int[,] nums3 = { { 1, 2, 3 }, { 3, 65, 23 }, { 23, 21, 65 } };

//Console.WriteLine(nums3.Rank);

//Array.Sort(nums);

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}

//int[] newArr = { 2, 3, 4, 5, 6 };

//Array.Copy(nums, 1,newArr, 1, 3);

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(newArr[i]);
//}

int[] nums = { 1, 7,3,4,5 };

//Console.WriteLine(Array.IndexOf(nums,5));

//var data = Array.Find(nums, m => m == 7);
//Console.WriteLine(data);

//int[] datas = Array.FindAll(nums, m => m > 1);

//for (int i = 0; i < datas.Length; i++)
//{
//    Console.WriteLine(datas[i]);
//}


static string[] Search(string[] students)
{
    return Array.FindAll(students, m => m.Contains("s"));
}

string[] names = { "Reshad", "Sebine", "Gulay", "Elnare", "Nigar", "Mehriban", "Nicat" };

var datas =Search(names);

for (int i = 0; i < datas.Length; i++)
{
    Console.WriteLine(datas[i]);
}

