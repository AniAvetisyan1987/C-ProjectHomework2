using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        //char ch = 'a';
        //if (ch.GetTypeCode() == TypeCode.Boolean)
        //{
        //    Console.WriteLine(ch + " is Boolean");
        //}
        //else
        //{
        //    Console.WriteLine(ch + " is Char");           
        //}

        //double db = 45;
        //switch ((db.GetTypeCode()).ToString()) {
        //    case "Boolean":
        //        Console.WriteLine("Boolean");
        //        break;
        //    case "Char":
        //        Console.WriteLine("Char");
        //        break;
        //    case "Double":
        //        Console.WriteLine("Double");
        //        break;
        //        default: 
        //        Console.WriteLine("Nothing");
        //        break;
        //}

        //byte by = 18;
        //byte by1 = 20;
        //switch (by,by1)
        //{
        //    case (18, 20) when (by != by1):
        //        Console.WriteLine("0");
        //            break;
        //    case (<78,<34): 
        //        Console.WriteLine("78");
        //            break;
        //    case (>19,>19): 
        //        Console.WriteLine("19");
        //            break;
        //    default:
        //        Console.WriteLine("Nothing");
        //        break;
        //}
        //var a = 77;
        //var b = a > 45 ? true : false;
        //var c = a < 45 && true;
        //Console.WriteLine($"{a} {b} {c}"); // a = 77 b = True c = True

        //int inc = 3;
        //Console.WriteLine(inc);
        //int inc1 = ++inc;
        //int inc2 = inc++;
        //if (inc++ == 6)
        //{
        //    ++inc;
        //}
        //Console.WriteLine(inc); // 6
        //Console.WriteLine(inc1); // 4
        //Console.WriteLine(inc2); //4

        //int dec = 8;
        //Console.WriteLine(dec);
        //int dec1 = --dec;
        //int dec2 = dec--;
        //if (dec2 == dec)
        //{
        //    Console.WriteLine(dec2);
        //}


        //////////////////////////////////////////////////////////
        //Console.Write("X= ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Y= ");
        //int y = Convert.ToInt32(Console.ReadLine());
        //int z = x + y;
        //Console.WriteLine("Sum= "+ z);
        ////////////////////////////////////////////////////////////

        //byte b = 25;
        //byte bb = 100;
        //byte bbb = Convert.ToByte(b + bb);
        //sbyte bs = Convert.ToSByte(b + bb);
        //Console.WriteLine("Byte= " + bbb);
        ////byte b4 = b + bb; Why is error here????????????

        //uint i1 = 2147483600u;
        //uint i2 = 3154565651u;
        //uint i3 = i1 + i2;
        //var x = i1 + i2;
        //Console.WriteLine("Uint= " + i3); // Uint = 1007081955
        //Console.WriteLine(i3);
        //// Uint = 1007081955 խի եմ սենց թիվ ստանում՞՞՞՞՞

        //char ch1 = 'a'; // 97
        //char ch2 = 'b'; // 98
        //char ch3 = 'c'; // 99
        //Console.WriteLine(ch1 + ch2 + ch3); // 294

        //Console.WriteLine(ch2); // b
        //Console.WriteLine(ch3); // c

        //int i =10000;
        //char ch = (char) i;
        //int ii = ch;
        //float f = ch;
        //float flo = 12.12f;
        //decimal m = 12.4m;
        //byte by = (byte)m;        


        //Console.WriteLine(ch); // ?

        //Console.WriteLine(ii); // 10000 ???? how it convert from ? to 10000 ???????????????????????
        //Console.WriteLine(f);


        //float floatNum = 234.56f;
        //short intNum = Convert.ToInt16(floatNum);
        //int intNum2 = (int)floatNum;
        //string strNum = Convert.ToString(floatNum);
        //string strNum2 = floatNum.ToString();
        //char charNum = Convert.ToChar(strNum[0]);
        //int intNum3 = 2;
        //char charNum1 = (char) intNum3;
        //long longNum = 2147483647;
        //int intNum4 = (int) longNum;

        //Console.WriteLine(charNum);
        //Console.WriteLine(charNum1);
        //Console.WriteLine(intNum4);


        //////////////////////// Convert.toString(variable) VS variable.toString()///////////////////////////

        //float floatNum2 = 23.56f;
        //bool boolNum = false;
        //string strs = null;
        //Console.WriteLine(floatNum2.ToString());
        //Console.WriteLine(Convert.ToString(floatNum2));
        ////for bool
        //Console.WriteLine(boolNum.ToString());
        //Console.WriteLine(Convert.ToString(boolNum));


        //Console.WriteLine(strs.ToString());     // returns error because ToString() doesn't handle null value
        //Console.WriteLine(Convert.ToString(strs)); // but Convert.ToString returns null


        ///////////////////////////////////Sting vs StringBuilder//////////////////////////////////////

        //StringBuilder strData = new StringBuilder("new string builder",16);
        //strData.Insert(3,"ffffffffffffffffffffff");
        //strData.Replace(" ", "&");
        //Console.WriteLine(strData);
        //Console.WriteLine(strData.MaxCapacity);


        //string stringNewData = "Barev erkir";
        //string strNewData = stringNewData.ToLower();
        //Console.WriteLine(strNewData);

        Console.ReadKey();
    }
}