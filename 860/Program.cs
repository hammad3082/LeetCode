using System.Collections.Generic;

int[] bills = { 5, 5, 10, 10, 20 };


bool result = LemonadeChange(bills);
Console.WriteLine(result);

bool LemonadeChange(int[] bills)
{
    Dictionary<int, int> Dic = new Dictionary<int, int>();

    int len = bills.Length;
    for (int i = 0; i < len; i++)
    {
        int Payed = bills[i];

        int Balance = Payed - 5;

        if (Balance != 0)
        {
            var list = Dic.Keys.OrderByDescending(d => d).ToList();
            foreach (var aa in list)
            {
                while (Balance != 0 && aa <= Balance && Dic[aa] != 0)
                {
                    Balance -= aa;
                    Dic[aa]--;
                }
            }
            if (Balance != 0)
            {
                return false;
            }
        }

        Dic[Payed] = Dic.GetValueOrDefault(Payed) + 1;
    }
    return true;
}

bool LemonadeChange111(int[] bills)
{
    Dictionary<int, int> Dic = new Dictionary<int, int>();

    int len = bills.Length;
    for (int i = 0; i < len; i++)
    {
        int Payed = bills[i];

        int Balance = Payed - 5;

        if (Balance != 0)
        {
            var list = Dic.Keys.OrderByDescending(d => d).ToList();
            foreach (var aa in list)
            {
                while (Balance!= 0 && aa <= Balance && Dic[aa] != 0)
                {
                    Balance -= aa;
                    Dic[aa]--;
                }
            }
            if (Balance != 0)
            {
                break;
            }
        }

        Dic[Payed] = Dic.GetValueOrDefault(Payed) + 1;

        //int j = 0;
        //    while(loop)
        //    {
        //        int Count = list[j].Value;
        //        int Change = list[j].Key;

        //        if (Change != Balance && Count == 1 && list.Count == j + 1)
        //            return false;

        //        if (Change > Balance)
        //        {
        //            j++;
        //            continue;
        //        }
        //        Balance -= Change;

        //        if (Count == 1)
        //        {
        //            Dic.Remove(list[j].Key);
        //            list.Remove(list[j]);
        //        }
        //        else
        //        {
        //            Dic[list[j].Key] = Count - 1;
        //            list[j] = new KeyValuePair<int, int>(Change, Count - 1);
        //        }
                
        //        if (Balance == 0)
        //        {
        //            break;
        //        }
        //    }
        //    if(Balance != 0)
        //    {
        //        return false;
        //    }
        //}
    }
    return true;
}


//bool LemonadeChange(int[] bills)
//{           int len = bills.Length;
//    int[] array = new int[len];
//    for (int i = 0; i < len; i++)
//    {
//        int Payed = bills[i];

//        array[i] = Payed;
//        int Balance = Payed - 5;

//        if (Balance != 0)
//        {
//            Array.Sort(array, (a, b) => b.CompareTo(a));

//            for (int j = 0; j < len; j++)
//            {
//                if (array[j] == 0 || j == len - 1)
//                {
//                    return false;
//                }
//                int Change = array[j];

//                if (Change > Balance)
//                    continue;

//                Balance -= Change;

//                array[j] = 0;
//                if (Balance == 0)
//                {
//                    break;
//                }
//            }
//        }
//    }
//    return true;
//}


//int[] bills = { 5, 5, 10, 10, 20 };


//bool result = LemonadeChange(bills);
//Console.WriteLine(result);
//bool LemonadeChange(int[] bills)
//{
//    //Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
//    int[] array = new int[bills.Length];
//    for (int i = 0; i < bills.Length; i++)
//    {
//        int key = bills[i];

//        array[i] = key;
//        //keyValuePairs[key] = keyValuePairs.GetValueOrDefault(key) + 1;

//        int dif = key - 5;

//        int dif1 = Math.Abs(5 - key);

//        if (dif != 0)
//        {
//            Array.Sort(array, (a, b) => b.CompareTo(a));

//            for (int j = 0; j < array.Length; j++)
//            {
//                if (array[j] == 0)
//                {
//                    return false;
//                }
//                int sub = array[j];

//                if (sub > dif)
//                    continue;

//                dif -= sub;

//                array[j] = 0;
//                if (dif == 0)
//                {
//                    break;
//                }
//            }

//        }

//        //int value1 = keyValuePairs.GetValueOrDefault(bills[i]);

//        //keyValuePairs.TryGetValue(bills[i], out int value);
//        //if (keyValuePairs.ContainsKey(bills[i]))
//        //{
//        //    keyValuePairs[bills[i]] = keyValuePairs[bills[i]] + 1;
//        //}
//        //else
//        //    keyValuePairs[bills[i]] = 1;
//    }

//    return true;
//}
